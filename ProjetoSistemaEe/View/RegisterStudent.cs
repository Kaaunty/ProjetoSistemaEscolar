using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;
using MainMenu = ProjetoSistemaEe.View.MainMenu;

namespace ProjetoSistemaEe
{
    public partial class RegisterStudent : Form
    {
        private StudentModel studentModel = new StudentModel();
        private Validations validate = new Validations();
        private CourseModel courseModel = new CourseModel();
        private Calculations calculate = new Calculations();

        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            validate.ClearControls(this);
            PopulateComboBox();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja cadastrar o estudante?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RegisterStudents();
                        MessageBox.Show("Aluno cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validate.ClearControls(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o estudante:" + ex.Message);
                }
            }
        }

        private void RegisterStudents()
        {
            try
            {
                int ra = calculate.GenerateRA();
                string name = TxtName.Text;
                int courseId = Convert.ToInt32(CbCourse.SelectedValue);
                Course course = new Course(courseId);
                string period = CbPeriod.Text;
                string martialStatus = CbMartialStatus.Text;
                string gender = CbGender.Text;
                DateTime birchDate = Convert.ToDateTime(DtStudent.Text);
                string email = TxtEmail.Text;
                string shift = CbShift.Text;
                string phone = TxtPhone.Text;
                string zipCode = TxtZipCode.Text;
                string city = TxtCity.Text;
                string state = TxtState.Text;
                string district = TxtDistrict.Text;
                string street = TxtStreet.Text;
                string streetNumber = TxtNum.Text;
                Student student = new Student(ra, name, course, period, martialStatus, gender, birchDate, email, shift, phone, zipCode, city, state, district, street, streetNumber);
                studentModel.Register(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateComboBox()
        {
            CbCourse.DataSource = courseModel.GetCourses();
            CbCourse.ValueMember = "CourseId";
            CbCourse.DisplayMember = "CourseName";
            CbCourse.DropDownHeight = CbCourse.ItemHeight * 5;
            CbCourse.SelectedIndex = -1;
        }

        #region Validations

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.BlockSpaceBar(e);
        }

        private void TxtZipCode_TextChanged(object sender, EventArgs e)
        {
            validate.ValidateCEP(TxtZipCode, TxtState, TxtCity, TxtDistrict, TxtStreet, TxtNum);
        }

        #endregion Validations

        #region Buttons

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu Mainmenu = new MainMenu();
            Mainmenu.TopLevel = true;
            Mainmenu.Show();
        }

        #endregion Buttons
    }
}