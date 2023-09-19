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

        public EditStudent(Student aluno)
        {
            this.student = aluno;
            InitializeComponent();
            PopulateComboBox();
        }

        private void EditarAluno_Load(object sender, EventArgs e)
        {
            PopularCampos();
        }

        private void PopularCampos()
        {
            txtRA.Text = student.RA.ToString();
            txtNome.Text = student.Name;
            cbCurso.SelectedValue = student.Course.CourseId;
            cbPeriodo.Text = student.Period;
            cbEstadoCivil.Text = student.MartialStatus;
            cbGenero.Text = student.Gender;
            dtAluno.Text = student.BirthDate.ToString();
            txtEmail.Text = student.Email;
            cbTurno.Text = student.Shift;
            txtTelefone.Text = student.Phone;
            txtCEP.Text = student.ZipCode;
            txtCidade.Text = student.City;
            txtEstado.Text = student.State;
            txtBairro.Text = student.District;
            txtRua.Text = student.Street;
            txtNum.Text = student.StreetNumber;
        }

        private void PopulateComboBox()
        {
            cbCurso.DataSource = courseModel.GetCourses();
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o student?", "EditStudent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        EditStudent();
                        MessageBox.Show("Aluno editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar student!" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditStudent()
        {
            try
            {
                int ra = Convert.ToInt32(txtRA.Text);
                string name = txtNome.Text;
                Course course = new Course(Convert.ToInt32(cbCurso.SelectedValue));
                string period = cbPeriodo.Text;
                string martialStatus = cbEstadoCivil.Text;
                string gender = cbGenero.Text;
                DateTime birchDate = Convert.ToDateTime(dtAluno.Text);
                string email = txtEmail.Text;
                string shift = cbTurno.Text;
                string phone = txtTelefone.Text;
                string zipCode = txtCEP.Text;
                string city = txtCidade.Text;
                string state = txtEstado.Text;
                string district = txtBairro.Text;
                string street = txtRua.Text;
                string streetNumber = txtNum.Text;
                Student student = new Student(ra, name, course, period, martialStatus, gender, birchDate, email, shift, phone, zipCode, city, state, district, street, streetNumber);
                studentModel.Edit(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja excluir o student?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteStudent();
                    MessageBox.Show("Aluno excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir student!" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteStudent()
        {
            try
            {
                student.RA = Convert.ToInt32(txtRA.Text);
                studentModel.Delete(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Validações

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            validate.ValidateCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.BlockSpaceBar(e);
        }

        #endregion Validações

        #region Botões

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal main_Menu = new MenuPrincipal();
            main_Menu.TopLevel = true;
            main_Menu.Show();
        }

        #endregion Botões
    }
}