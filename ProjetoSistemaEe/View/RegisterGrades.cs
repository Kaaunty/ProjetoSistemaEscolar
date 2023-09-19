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
        private Calculations calculate = new Calculations();
        private CourseModel courseModel = new CourseModel();
        private ProfessorModel professorModel = new ProfessorModel();
        private ReportCardModel reportCardModel = new ReportCardModel();
        private Validations validate = new Validations();

        public CadastrarNotas()
        {
            InitializeComponent();
        }

        private void CadastrarNotas_Load(object sender, EventArgs e)
        {
            validate.ClearControls(this);
            PopulateComboBox();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja adicionar a grade ao student?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Register();
                        MessageBox.Show("Boletim cadastrado com sucesso!");
                        validate.ClearControls(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar: " + ex.Message);
                }
            }
        }

        private void Register()
        {
            try
            {
                int ra = Convert.ToInt32(cbAluno.SelectedValue);
                int professorId = Convert.ToInt32(cbProfessor.SelectedValue);
                int subjectId = Convert.ToInt32(cbMateria.SelectedValue);
                int courseId = Convert.ToInt32(cbCurso.SelectedValue);
                double grade1 = Convert.ToDouble(txtN1.Text);
                double grade2 = Convert.ToDouble(txtN2.Text);
                double grade3 = Convert.ToDouble(txtN3.Text);
                double grade4 = Convert.ToDouble(txtN4.Text);
                double average = Convert.ToDouble(txtMedia.Text);
                string situation = calculate.CheckSituation(average);

                ReportCard boletim = new ReportCard(ra, professorId, subjectId, courseId, grade1, grade2, grade3, grade4, average, situation);
                reportCardModel.Register(boletim);
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
                double grade = Convert.ToDouble(txt.Text);
                if (grade < 0 || grade > 10)
                {
                    MessageBox.Show("Nota Invalida, digite um valor de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Clear();
                    txt.Focus();
                    return;
                }
            }

            if (txtN1.Text != "" && txtN2.Text != "" && txtN3.Text != "" && txtN4.Text != "")
            {
                calculate.CalculateAverage(txtN1, txtN2, txtN3, txtN4, txtMedia);
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
            validate.PermitNumber(e);
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

        private void PopulateComboBox()
        {   //
            cbCurso.ValueMember = "courseId";
            cbCurso.DisplayMember = "Nome_curso";
            cbCurso.DropDownHeight = cbCurso.Height * 5;
            cbCurso.DataSource = courseModel.GetCoursesByStudents();
            //
            cbAluno.ValueMember = "RA";
            cbAluno.DisplayMember = "Nome";
            cbAluno.DropDownHeight = cbAluno.Height * 5;
            cbAluno.DataSource = courseModel.GetStudentsByCourse(Convert.ToInt32(cbCurso.SelectedValue));
            //

            cbProfessor.ValueMember = "id";
            cbProfessor.DisplayMember = "nome";
            cbProfessor.DropDownHeight = cbProfessor.Height * 5;
            cbProfessor.DataSource = professorModel.GetEntities();
            //
            cbMateria.ValueMember = "Materiaid";
            cbMateria.DisplayMember = "Nome";
            cbMateria.DropDownHeight = cbMateria.Height * 5;
            cbMateria.DataSource = courseModel.GetSubjectsByProfessorAndCourse(Convert.ToInt32(cbProfessor.SelectedValue), Convert.ToInt32(cbCurso.SelectedValue));
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            int id_curso = Convert.ToInt32(cbCurso.SelectedValue);
            int id_professor = Convert.ToInt32(cbProfessor.SelectedValue);
            cbAluno.ValueMember = "RA";
            cbAluno.DisplayMember = "Nome";
            cbAluno.DropDownHeight = cbAluno.Height * 5;
            cbAluno.DataSource = courseModel.GetStudentsByCourse(id_curso);
            //
            cbMateria.ValueMember = "Materiaid";
            cbMateria.DisplayMember = "Nome";
            cbMateria.DropDownHeight = cbMateria.Height * 5;
            cbMateria.DataSource = courseModel.GetSubjectsByProfessorAndCourse(Convert.ToInt32(id_professor), Convert.ToInt32(id_curso));
        }

        private void cbProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMateria.ValueMember = "Materiaid";
            cbMateria.DisplayMember = "Nome";
            cbMateria.DropDownHeight = cbMateria.Height * 5;
            cbMateria.DataSource = courseModel.GetSubjectsByProfessorAndCourse(Convert.ToInt32(cbProfessor.SelectedValue), Convert.ToInt32(cbCurso.SelectedValue));
        }
    }
}