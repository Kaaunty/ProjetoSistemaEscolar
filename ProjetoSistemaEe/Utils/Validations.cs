using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Utils
{
    public class Validations
    {
        public bool ValidateControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"Por favor, preencha o campo", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (control is MaskedTextBox maskedTextBox && (string.IsNullOrWhiteSpace(maskedTextBox.Text) || maskedTextBox.Text == "(  )     -" || !maskedTextBox.MaskCompleted))
                {
                    MessageBox.Show($"Por favor, preencha o campo", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show($"Por favor, selecione um valor.", "Seleção Necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (control.HasChildren)
                {
                    if (!ValidateControls(control))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void PermitNumber(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void PermitNumberAndComma(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Apenas um ponto é permitido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PermitLetter(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        public void BlockSpaceBar(KeyPressEventArgs e)
        {
            if (!(e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        public void ValidateCEP(MaskedTextBox textBox, TextBox state, TextBox city, TextBox district, TextBox street, TextBox streetNumber)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.MaskCompleted)
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var address = ws.consultaCEP(textBox.Text.Trim());
                        state.Text = address.uf;
                        city.Text = address.cidade;
                        district.Text = address.bairro;
                        street.Text = address.end;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("CEP não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Clear();
                        textBox.Focus();
                    }
                }
            }
            streetNumber.Clear();
        }

        public void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    ClearControls(c);
                }
                else
                {
                    switch (c.GetType().ToString())
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)c).Clear();
                            break;

                        case "System.Windows.Forms.MaskedTextBox":
                            ((MaskedTextBox)c).Clear();
                            break;

                        case "System.Windows.Forms.ComboBox":
                            ((ComboBox)c).SelectedIndex = -1;
                            break;
                    }
                }
            }
        }

        public void ValidateSalary(TextBox text)
        {
            double salary;
            if (Double.TryParse(text.Text, out salary))
            {
                text.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", salary);

                if (salary < 2000)
                {
                    MessageBox.Show("Salário Inválido (Menor que R$ 2.000)");
                    text.Text = "";
                    text.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite um valor numérico válido.");
                text.Text = "";
            }
        }
    }
}