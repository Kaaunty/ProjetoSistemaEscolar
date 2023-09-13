using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Utils
{
    internal class Validar
    {
        public static void FormatarData(DateTimePicker dateTimePicker, DateTime maxDate, DateTime minDate)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.MaxDate = maxDate;
            dateTimePicker.MinDate = minDate;
        }

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

        public void VerificaNumero(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void VerificaLetra(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        public void BloqueiaEspaco(KeyPressEventArgs e)
        {
            if (!(e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        public void VerificaCEP(MaskedTextBox textBox, TextBox estado, TextBox cidade, TextBox bairro, TextBox rua, TextBox numrua)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.MaskCompleted)
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(textBox.Text.Trim());
                        estado.Text = endereco.uf;
                        cidade.Text = endereco.cidade;
                        bairro.Text = endereco.bairro;
                        rua.Text = endereco.end;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("CEP não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Clear();
                        textBox.Focus();
                    }
                }
            }
            numrua.Clear();
        }

        public void LimparControles(Control controle)
        {
            foreach (Control c in controle.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    LimparControles(c);
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

        public void ValidarSalario(TextBox text)
        {
            double salario;
            if (Double.TryParse(text.Text, out salario))
            {
                text.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", salario);

                if (salario < 2000)
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