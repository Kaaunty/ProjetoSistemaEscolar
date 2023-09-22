using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditStudent : Form
    {
        private CourseModel courseModel = new CourseModel();
        private StudentModel studentModel = new StudentModel();
        private Validations validate = new Validations();
        private Student student;

        public EditStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
            PopulateComboBox();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void PopulateFields()
        {
            txtRA.Text = student.Ra.ToString();
            TxtName.Text = student.Name;
            CbCourse.SelectedValue = student.Course.CourseId;
            CbPeriod.Text = student.Period;
            CbMartialStatus.Text = student.MaritalStatus;
            CbGender.Text = student.Gender;
            DtStudent.Text = student.BirthDate.ToString();
            TxtEmail.Text = student.Email;
            CbShift.Text = student.Shift;
            TxtPhone.Text = student.Phone;
            TxtZipCode.Text = student.ZipCode;
            TxtCity.Text = student.City;
            TxtState.Text = student.State;
            TxtDistrict.Text = student.District;
            TxtStreet.Text = student.Street;
            TxtNum.Text = student.StreetNumber;
        }

        private void PopulateComboBox()
        {
            CbCourse.DataSource = courseModel.GetCourses();
            CbCourse.DisplayMember = "CourseName";
            CbCourse.ValueMember = "CourseId";
            CbCourse.DropDownHeight = CbCourse.ItemHeight * 5;
            CbCourse.SelectedIndex = -1;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o estudante?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        EditStudents();
                        MessageBox.Show("Aluno editado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar estudante!" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditStudents()
        {
            try
            {
                int ra = Convert.ToInt32(txtRA.Text);
                string name = TxtName.Text;
                Course course = new Course(Convert.ToInt32(CbCourse.SelectedValue));
                string period = CbPeriod.Text;
                string martialStatus = CbMartialStatus.Text;
                string gender = CbGender.Text;
                DateTime birthDate = Convert.ToDateTime(DtStudent.Text);
                string email = TxtEmail.Text;
                string shift = CbShift.Text;
                string phone = TxtPhone.Text;
                string zipCode = TxtZipCode.Text;
                string city = TxtCity.Text;
                string state = TxtState.Text;
                string district = TxtDistrict.Text;
                string street = TxtStreet.Text;
                string streetNumber = TxtNum.Text;
                Student student = new Student(ra, name, course, period, martialStatus, gender, birthDate, email, shift, phone, zipCode, city, state, district, street, streetNumber);
                studentModel.Edit(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja excluir o estudante?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteStudent();
                    MessageBox.Show("Aluno excluido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir estudante!" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteStudent()
        {
            try
            {
                student.Ra = Convert.ToInt32(txtRA.Text);
                studentModel.Delete(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Validations

        private void TxtZipCode_TextChanged(object sender, EventArgs e)
        {
            validate.ValidateCEP(TxtZipCode, TxtState, TxtCity, TxtDistrict, TxtStreet, TxtNum);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.BlockSpaceBar(e);
        }

        #endregion Validations

        #region Buttons

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Buttons
    }
}