using ProjetoSistemaEe.DAO;
using System;
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

        public void CalculateAverage(TextBox N1, TextBox N2, TextBox N3, TextBox N4, TextBox TxtAverage)
        {
            {
                {
                    try
                    {
                        double grade1, grade2, grade3, grade4, average;

                        if (!double.TryParse(N1.Text, out grade1) || grade1 < 0 || grade1 > 10)
                        {
                            N1.Focus();
                            N1.Clear();
                            return;
                        }
                        if (!double.TryParse(N2.Text, out grade2) || grade2 < 0 || grade2 > 10)
                        {
                            N2.Focus();
                            N2.Clear();
                            return;
                        }
                        if (!double.TryParse(N3.Text, out grade3) || grade3 < 0 || grade3 > 10)
                        {
                            N3.Focus();
                            N3.Clear();
                            return;
                        }
                        if (!double.TryParse(N4.Text, out grade4) || grade4 < 0 || grade4 > 10)
                        {
                            N4.Focus();
                            N4.Clear();
                            return;
                        }

                        average = (grade1 + grade2 + grade3 + grade4) / 4;
                        TxtAverage.Text = average.ToString("N2");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nota Invalida, digite um valor de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public string CheckSituation(double average)
        {
            if (average < 5)
            {
                return "Reprovado";
            }
            else if (average >= 5 && average <= 7)
            {
                return "Recuperação";
            }
            else
            {
                return "Aprovado";
            }
        }
    }
}