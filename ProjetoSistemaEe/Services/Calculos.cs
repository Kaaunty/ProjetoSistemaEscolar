using ProjetoSistemaEe.DAO;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Utils
{
    internal class Calculos
    {
        private AlunoDAO alunoDAO = new AlunoDAO();

        public int GerarRA()
        {
            string raStr;
            int ra;
            try
            {
                do
                {
                    string raAno = DateTime.Now.Year.ToString();
                    string raNum = new Random().Next(100000, 999999).ToString();
                    raStr = raAno + raNum;
                    ra = int.Parse(raStr);
                } while (alunoDAO.VerificarRA(ra));
                return ra;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CalcularMedia(TextBox N1, TextBox N2, TextBox N3, TextBox N4, TextBox txtMedia)
        {
            {
                {
                    try
                    {
                        double nota1, nota2, nota3, nota4, media;

                        if (!double.TryParse(N1.Text, out nota1) || nota1 < 0 || nota1 > 10)
                        {
                            N1.Focus();
                            N1.Clear();
                            return;
                        }
                        if (!double.TryParse(N2.Text, out nota2) || nota2 < 0 || nota2 > 10)
                        {
                            N2.Focus();
                            N2.Clear();
                            return;
                        }
                        if (!double.TryParse(N3.Text, out nota3) || nota3 < 0 || nota3 > 10)
                        {
                            N3.Focus();
                            N3.Clear();
                            return;
                        }
                        if (!double.TryParse(N4.Text, out nota4) || nota4 < 0 || nota4 > 10)
                        {
                            N4.Focus();
                            N4.Clear();
                            return;
                        }

                        media = (nota1 + nota2 + nota3 + nota4) / 4;
                        txtMedia.Text = media.ToString("N2");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nota Invalida, digite um valor de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public string VerificarSituacao(double media)
        {
            if (media < 5)
            {
                return "Reprovado";
            }
            else if (media >= 5 && media <= 7)
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