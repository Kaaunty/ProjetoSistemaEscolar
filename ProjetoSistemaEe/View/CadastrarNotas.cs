using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class CadastrarNotas : Form
    {
        private Calculos calcular = new Calculos();
        private CursoModel cursoModel = new CursoModel();
        private ProfessorModel professorModel = new ProfessorModel();
        private BoletimModel boletimModel = new BoletimModel();

        private Validar validar = new Validar();

        public CadastrarNotas()
        {
            InitializeComponent();
        }

        private void CadastrarNotas_Load(object sender, EventArgs e)
        {
            validar.LimparControles(this);
            CarregarComboBox();
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
                        Adicionar();
                        MessageBox.Show("Boletim cadastrado com sucesso!");
                        validar.LimparControles(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar: " + ex.Message);
                }
            }
        }

        private void Adicionar()
        {
            try
            {
                int ra = Convert.ToInt32(cbAluno.SelectedValue);
                int id_professor = Convert.ToInt32(cbProfessor.SelectedValue);
                int id_disciplina = Convert.ToInt32(cbMateria.SelectedValue);
                int id_curso = Convert.ToInt32(cbCurso.SelectedValue);
                double nota1 = Convert.ToDouble(txtN1.Text);
                double nota2 = Convert.ToDouble(txtN2.Text);
                double nota3 = Convert.ToDouble(txtN3.Text);
                double nota4 = Convert.ToDouble(txtN4.Text);
                double media = Convert.ToDouble(txtMedia.Text);
                string situacao = calcular.VerificarSituacao(media);

                Boletim boletim = new Boletim(ra, id_professor, id_disciplina, id_curso, nota1, nota2, nota3, nota4, media, situacao);
                boletimModel.CadastrarBoletim(boletim);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
        }

        #region Validações

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
                calcular.CalcularMedia(txtN1, txtN2, txtN3, txtN4, txtMedia);
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

        #endregion Validações

        #region Menu

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal mainMenu = new MenuPrincipal();
            Close();
            mainMenu.TopLevel = true;
            mainMenu.Show();
        }

        #endregion Menu

        private void CarregarComboBox()
        {   //
            cbCurso.ValueMember = "id_curso";
            cbCurso.DisplayMember = "Nome_curso";
            cbCurso.DropDownHeight = cbCurso.Height * 5;
            cbCurso.DataSource = cursoModel.ListarCursosSeTiverAluno();
            //
            cbAluno.ValueMember = "RA";
            cbAluno.DisplayMember = "Nome";
            cbAluno.DropDownHeight = cbAluno.Height * 5;
            cbAluno.DataSource = cursoModel.ListarAlunoPorCurso(Convert.ToInt32(cbCurso.SelectedValue));
            //

            cbProfessor.ValueMember = "id";
            cbProfessor.DisplayMember = "nome";
            cbProfessor.DropDownHeight = cbProfessor.Height * 5;
            cbProfessor.DataSource = professorModel.Listar();
            //
            cbMateria.ValueMember = "Materiaid";
            cbMateria.DisplayMember = "Nome";
            cbMateria.DropDownHeight = cbMateria.Height * 5;
            cbMateria.DataSource = cursoModel.ListarMateriaPorProfessorECurso(Convert.ToInt32(cbProfessor.SelectedValue), Convert.ToInt32(cbCurso.SelectedValue));
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            int id_curso = Convert.ToInt32(cbCurso.SelectedValue);
            int id_professor = Convert.ToInt32(cbProfessor.SelectedValue);
            cbAluno.ValueMember = "RA";
            cbAluno.DisplayMember = "Nome";
            cbAluno.DropDownHeight = cbAluno.Height * 5;
            cbAluno.DataSource = cursoModel.ListarAlunoPorCurso(id_curso);
            //
            cbMateria.ValueMember = "Materiaid";
            cbMateria.DisplayMember = "Nome";
            cbMateria.DropDownHeight = cbMateria.Height * 5;
            cbMateria.DataSource = cursoModel.ListarMateriaPorProfessorECurso(Convert.ToInt32(id_professor), Convert.ToInt32(id_curso));
        }

        private void cbProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMateria.ValueMember = "Materiaid";
            cbMateria.DisplayMember = "Nome";
            cbMateria.DropDownHeight = cbMateria.Height * 5;
            cbMateria.DataSource = cursoModel.ListarMateriaPorProfessorECurso(Convert.ToInt32(cbProfessor.SelectedValue), Convert.ToInt32(cbCurso.SelectedValue));
        }
    }
}