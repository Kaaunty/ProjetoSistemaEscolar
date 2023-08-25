using System;
using System.Text.RegularExpressions;
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

        public static bool ValidaNumeroOuCaracterEspecial(string nome)
        {
            return Regex.IsMatch(nome, @"[\d\W]");
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
                else if (control is MaskedTextBox maskedTextBox && string.IsNullOrWhiteSpace(maskedTextBox.Text))
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
    }
}