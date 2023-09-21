using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class RegisterGrades : Form
    {
        private Calculations calculate = new Calculations();
        private CourseModel courseModel = new CourseModel();
        private ProfessorModel professorModel = new ProfessorModel();
        private ReportCardModel reportCardModel = new ReportCardModel();
        private Validations validate = new Validations();

        public RegisterGrades()
        {
            InitializeComponent();
        }

        private void RegisterGrades_Load(object sender, EventArgs e)
        {
            validate.ClearControls(this);
            PopulateComboBox();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja adicionar a media ao estudante?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                int ra = Convert.ToInt32(CbStudent.SelectedValue);
                int professorId = Convert.ToInt32(CbProfessor.SelectedValue);
                int subjectId = Convert.ToInt32(CbSubject.SelectedValue);
                int courseId = Convert.ToInt32(CbCourse.SelectedValue);
                double grade1 = Convert.ToDouble(TxtN1.Text);
                double grade2 = Convert.ToDouble(TxtN2.Text);
                double grade3 = Convert.ToDouble(TxtN3.Text);
                double grade4 = Convert.ToDouble(TxtN4.Text);
                double average = Convert.ToDouble(TxtAverage.Text);
                string situation = calculate.CheckSituation(average);

                ReportCard boletim = new ReportCard(ra, professorId, subjectId, courseId, grade1, grade2, grade3, grade4, average, situation);
                reportCardModel.Register(boletim);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Validations

        private void TxtN_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text) && txt.Text != ",")
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

            if (TxtN1.Text != "" && TxtN2.Text != "" && TxtN3.Text != "" && TxtN4.Text != "")
            {
                calculate.CalculateAverage(TxtN1, TxtN2, TxtN3, TxtN4, TxtAverage);
                BtnAdd.Enabled = true;
            }
            else
            {
                TxtAverage.Clear();
                BtnAdd.Enabled = false;
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumberAndComma(sender, e);
        }

        #endregion Validations

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
            MainMenu mainMenu = new MainMenu();
            Close();
            mainMenu.TopLevel = true;
            mainMenu.Show();
        }

        #endregion Menu

        #region ComboBox

        private void PopulateComboBox()
        {   //
            CbCourse.ValueMember = "courseId";
            CbCourse.DisplayMember = "courseName";
            CbCourse.DropDownHeight = CbCourse.Height * 5;
            CbCourse.DataSource = courseModel.GetCoursesByStudents();
            //
            CbStudent.ValueMember = "RA";
            CbStudent.DisplayMember = "Name";
            CbStudent.DropDownHeight = CbStudent.Height * 2;
            CbStudent.DataSource = courseModel.GetStudentsByCourse(Convert.ToInt32(CbCourse.SelectedValue));
            //

            CbProfessor.ValueMember = "Id";
            CbProfessor.DisplayMember = "Name";
            CbProfessor.DropDownHeight = CbProfessor.Height * 5;
            CbProfessor.DataSource = professorModel.GetEntities();
            //
            CbSubject.ValueMember = "SubjectId";
            CbSubject.DisplayMember = "SubjectName";
            CbSubject.DropDownHeight = CbSubject.Height * 5;
            CbSubject.DataSource = courseModel.GetSubjectsByProfessorAndCourse(Convert.ToInt32(CbProfessor.SelectedValue), Convert.ToInt32(CbCourse.SelectedValue), Convert.ToInt32(CbStudent.SelectedValue));
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(CbCourse.SelectedValue);
            int professorId = Convert.ToInt32(CbProfessor.SelectedValue);
            CbStudent.ValueMember = "RA";
            CbStudent.DisplayMember = "Name";
            CbStudent.DropDownHeight = CbStudent.Height * 5;
            CbStudent.DataSource = courseModel.GetStudentsByCourse(courseId);
            //
            CbSubject.ValueMember = "SubjectId";
            CbSubject.DisplayMember = "SubjectName";
            CbSubject.DropDownHeight = CbSubject.Height * 5;
            CbSubject.DataSource = courseModel.GetSubjectsByProfessorAndCourse(Convert.ToInt32(professorId), Convert.ToInt32(courseId), Convert.ToInt32(CbStudent.SelectedValue));
        }

        private void cbProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbSubject.ValueMember = "SubjectId";
            CbSubject.DisplayMember = "SubjectName";
            CbSubject.DropDownHeight = CbSubject.Height * 5;
            CbSubject.DataSource = courseModel.GetSubjectsByProfessorAndCourse(Convert.ToInt32(CbProfessor.SelectedValue), Convert.ToInt32(CbCourse.SelectedValue), Convert.ToInt32(CbStudent.SelectedValue));
        }
    }

    #endregion ComboBox
}