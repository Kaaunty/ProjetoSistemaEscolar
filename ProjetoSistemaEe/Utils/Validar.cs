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
    }
}