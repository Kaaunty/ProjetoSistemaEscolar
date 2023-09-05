using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class CadastrarNotas : Form
    {
        private BoletimModel model = new BoletimModel();

        private ProfessorModel modelprofessor = new ProfessorModel();

        private CursoModel modelcurso = new CursoModel();
        private AlunoModel modelaluno = new AlunoModel();

        private Validar validar = new Validar();

        public CadastrarNotas()
        {
            InitializeComponent();
        }

        private void CadastrarNotas_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarComboBox();
        }

        private void LimparCampos()
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtMedia.Clear();
            cbCurso.SelectedValue = 0;
            cbMateria.SelectedValue = 0;
            cbAluno.SelectedValue = 0;
            cbProfessor.SelectedValue = 0;
        }

        private void DesabilitarCampos()
        {
            txtN1.Enabled = false;
            txtN2.Enabled = false;
            txtN3.Enabled = false;
            txtN4.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja adicionar a nota ao aluno?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Boletim boletim = new Boletim();
                        Adicionar(boletim);
                        MessageBox.Show("Boletim cadastrado com sucesso!");
                        LimparCampos();
                        DesabilitarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar: " + ex.Message);
                }
            }
        }

        private void Adicionar(Boletim boletim)
        {
            try
            {
                boletim.IdCurso = cbCurso.SelectedValue.ToString();
                boletim.IdDisciplina = cbMateria.SelectedValue.ToString();
                boletim.IdAluno = Convert.ToInt32(cbAluno.SelectedValue.ToString());
                boletim.Idprofessor = Convert.ToInt32(cbProfessor.SelectedValue.ToString());
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
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Calcular()
        {
            {
                {
                    try
                    {
                        double nota1, nota2, nota3, nota4, media;

                        if (!double.TryParse(txtN1.Text, out nota1) || nota1 < 0 || nota1 > 10)
                        {
                            txtN1.Focus();
                            txtN1.Clear();
                            return;
                        }
                        if (!double.TryParse(txtN2.Text, out nota2) || nota2 < 0 || nota2 > 10)
                        {
                            txtN2.Focus();
                            txtN2.Clear();
                            return;
                        }
                        if (!double.TryParse(txtN3.Text, out nota3) || nota3 < 0 || nota3 > 10)
                        {
                            txtN3.Focus();
                            txtN3.Clear();
                            return;
                        }
                        if (!double.TryParse(txtN4.Text, out nota4) || nota4 < 0 || nota4 > 10)
                        {
                            txtN4.Focus();
                            txtN4.Clear();
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

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text))
            {
                double nota = Convert.ToDouble(txt.Text);
                if (nota < 0 || nota > 10)
                {
                    MessageBox.Show("Nota Invalida, digite um valor de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Clear();
                    txt.Focus();
                    return;
                }
            }

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

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void CarregarComboBox()
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.DataSource = modelcurso.ListarCursos();

            //
            cbAluno.DisplayMember = "Nome";
            cbAluno.ValueMember = "RA_Aluno";
            int id_curso = Convert.ToInt32(cbCurso.SelectedValue);
            cbAluno.DataSource = model.ListarAlunoPorCurso(id_curso);

            cbProfessor.DisplayMember = "Nome";
            cbProfessor.ValueMember = "id";
            cbProfessor.DataSource = modelprofessor.Listar();
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            //
            cbAluno.DisplayMember = "Nome_Aluno";
            cbAluno.ValueMember = "RA_Aluno";
            int id_curso = Convert.ToInt32(cbCurso.SelectedValue);
            cbAluno.DataSource = model.ListarAlunoPorCurso(id_curso);
            //
        }

        private void cbProfessor_TextChanged(object sender, EventArgs e)
        {
            cbMateria.DisplayMember = "Nome";
            cbMateria.ValueMember = "id_materia";
            int id_professor = Convert.ToInt32(cbProfessor.SelectedValue);
            cbMateria.DataSource = model.ListarMateriaPorProfessor(id_professor);
        }
    }
}