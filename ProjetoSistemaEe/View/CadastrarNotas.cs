using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;
using System.Drawing.Design;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class CadastrarNotas : Form
    {
        private BoletimModel model = new BoletimModel();

        public CadastrarNotas()
        {
            InitializeComponent();
        }

        private void CadastrarNotas_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarGrid();
        }

        #region Habilitar,Limpar Campos

        private void HabilitarCampos()
        {
            txtN1.Enabled = true;
            txtN2.Enabled = true;
            txtN3.Enabled = true;
            txtN4.Enabled = true;
        }

        private void LimparCampos()
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtMedia.Clear();
            txtNome.Clear();
            txtMateria.Clear();
            txtRA.Clear();
            txtNomeProfessor.Clear();
        }

        #endregion Habilitar,Limpar Campos

        #region Botão e Função Adicionar

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Calcular();
            Boletim boletim = new Boletim();
            Adicionar(boletim);
        }

        private void Adicionar(Boletim boletim)
        {
            if (VerificarCampos())
            {
                try
                {
                    boletim.IdDisciplina = gridAlunoProfessor.CurrentRow.Cells[2].Value.ToString();
                    boletim.IdAluno = Convert.ToInt32(gridAlunoProfessor.CurrentRow.Cells[0].Value.ToString());
                    boletim.Idprofessor = Convert.ToInt32(gridAlunoProfessor.CurrentRow.Cells[3].Value.ToString());
                    boletim.Nota1 = Convert.ToDouble(txtN1.Text);
                    boletim.Nota2 = Convert.ToDouble(txtN2.Text);
                    boletim.Nota3 = Convert.ToDouble(txtN3.Text);
                    boletim.Nota4 = Convert.ToDouble(txtN4.Text);
                    boletim.Media = Convert.ToDouble(txtMedia.Text);

                    if (boletim.Media >= 7)
                    {
                        boletim.Situacao = "Aprovado";
                    }
                    else
                    {
                        boletim.Situacao = "Reprovado";
                    }
                    model.CadastrarBoletim(boletim);

                    MessageBox.Show("Boletim cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    LimparCampos();
                    CarregarGrid();
                }
            }
        }

        #endregion Botão e Função Adicionar

        public void Calcular()
        {
            {
                {
                    try
                    {
                        double nota1, nota2, nota3, nota4, media;

                        if (txtN1.Text == "" || txtN2.Text == "" || txtN3.Text == "" || txtN4.Text == "")
                        {
                            MessageBox.Show("Digite todas as notas");
                            return;
                        }
                        else
                        {
                            if (!double.TryParse(txtN1.Text, out nota1) || nota1 < 0 || nota1 > 10)
                            {
                                MessageBox.Show(
                                    "Digite um número de 0 a 10 para a nota 1",
                                    "Mensagem do Sistema");
                                txtN1.Focus();
                                txtN1.Clear();
                                return;
                            }
                            if (!double.TryParse(txtN2.Text, out nota2) || nota2 < 0 || nota2 > 10)
                            {
                                MessageBox.Show(
                                    "Digite um número de 0 a 10 para a nota 2",
                                    "Mensagem do Sistema");
                                txtN2.Focus();
                                txtN2.Clear();
                                return;
                            }
                            if (!double.TryParse(txtN3.Text, out nota3) || nota3 < 0 || nota3 > 10)
                            {
                                MessageBox.Show(
                                    "Digite um número de 0 a 10 para a nota 3",
                                    "Mensagem do Sistema");
                                txtN3.Focus();
                                txtN3.Clear();
                                return;
                            }
                            if (!double.TryParse(txtN4.Text, out nota4) || nota4 < 0 || nota4 > 10)
                            {
                                MessageBox.Show(
                                    "Digite um número de 0 a 10 para a nota 4",
                                    "Mensagem do Sistema");
                                txtN4.Focus();
                                txtN4.Clear();
                                return;
                            }

                            media = (nota1 + nota2 + nota3 + nota4) / 4;
                            txtMedia.Text = media.ToString("N2");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Digite números válidos para as notas", "Mensagem do Sistema");
                    }
                }
            }
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            if (txtN1.Text != "" && txtN2.Text != "" && txtN3.Text != "" && txtN4.Text != "")
            {
                Calcular();
                btnAdicionar.Enabled = true;
            }
            else
            {
                txtMedia.Clear();
                btnAdicionar.Enabled = false;
            }
        }

        #region Grid

        private void CarregarGrid()
        {
            gridAlunoProfessor.DataSource = model.ListarAlunoPorMateria();
            gridAlunoProfessor.Columns[0].HeaderText = "RA Aluno";
            gridAlunoProfessor.Columns[1].HeaderText = "Nome do Aluno";
            gridAlunoProfessor.Columns[2].HeaderText = "Curso do Aluno";
            gridAlunoProfessor.Columns[4].HeaderText = "Nome do Professor";
            gridAlunoProfessor.Columns[6].HeaderText = "Materia";
            gridAlunoProfessor.Columns[3].Visible = false;
            gridAlunoProfessor.Columns[5].Visible = false;
        }

        private void gridAlunoProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRA.Text = gridAlunoProfessor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridAlunoProfessor.CurrentRow.Cells[1].Value.ToString();
            txtCurso.Text = gridAlunoProfessor.CurrentRow.Cells[2].Value.ToString();
            txtNomeProfessor.Text = gridAlunoProfessor.CurrentRow.Cells[4].Value.ToString();
            txtMateria.Text = gridAlunoProfessor.CurrentRow.Cells[6].Value.ToString();
            HabilitarCampos();
        }

        #endregion Grid

        private bool VerificarCampos()
        {
            if (txtN1.Text == "")
            {
                MessageBox.Show("Preencha o campo Nota 1");
                txtN1.Focus();
                return false;
            }
            if (txtN2.Text == "")
            {
                MessageBox.Show("Preencha o campo Nota 2");
                txtN2.Focus();
                return false;
            }
            if (txtN3.Text == "")
            {
                MessageBox.Show("Preencha o campo Nota 3");
                txtN3.Focus();
                return false;
            }
            if (txtN4.Text == "")
            {
                MessageBox.Show("Preencha o campo Nota 4");
                txtN4.Focus();
                return false;
            }
            return true;
        }
    }
}