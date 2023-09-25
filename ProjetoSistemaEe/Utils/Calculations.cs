using ProjetoSistemaEe.DAO;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Utils
{
    internal class Calculations
    {
        private StudentDAO studentDAO = new StudentDAO();

        public int GenerateRA()
        {
            string raStr;
            int ra;
            try
            {
                do
                {
                    string raYear = DateTime.Now.Year.ToString();
                    string raNum = new Random().Next(100000, 999999).ToString();
                    raStr = raYear + raNum;
                    ra = int.Parse(raStr);
                } while (studentDAO.CheckRA(ra));
                return ra;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string CalculateAverage(string N1, string N2, string N3, string N4, out string MessageError)
        {
            MessageError = "";
            if (double.TryParse(N1, out double n1) && double.TryParse(N2, out double n2) && double.TryParse(N3, out double n3) && double.TryParse(N4, out double n4))
            {
                if (n1 >= 0 && n1 <= 10 && n2 >= 0 && n2 <= 10 && n3 >= 0 && n3 <= 10 && n4 >= 0 && n4 <= 10)
                {
                    double average = (n1 + n2 + n3 + n4) / 4;
                    return average.ToString();
                }
                else
                {
                    MessageError = "As notas devem ser entre 0 e 10";
                }
            }
            return MessageError;
        }
    }
}