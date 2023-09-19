using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using ProjetoSistemaEe.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            validate.ClearControls(this);
            Validations.FormatDate(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            PopulateComboBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja cadastrar o student?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        RegisterStudents();
                        MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validate.ClearControls(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o student:" + ex.Message);
                }
            }
        }

        private void RegisterStudents()
        {
            try
            {
                int ra = calculate.GenerateRA();
                string name = txtNome.Text;
                int courseId = Convert.ToInt32(cbCurso.SelectedValue);
                Course course = new Course(courseId);
                string period = CbPeriodo.Text;
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
                studentModel.Register(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PopulateComboBox()
        {
            cbCurso.DataSource = courseModel.GetCourses();
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.SelectedIndex = -1;
        }

        #region Validações

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.BlockSpaceBar(e);
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            validate.ValidateCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
        }

        #endregion Validações

        #region Botões

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal main_Menu = new MenuPrincipal();
            main_Menu.TopLevel = true;
            main_Menu.Show();
        }

        #endregion Botões

        private void BtnTest_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Teste";
            txtEmail.Text = "Teste@teste.com";
            txtCEP.Text = "13254685";
            cbTurno.Text = "Diurno";
            cbCurso.Text = "Arqueologia";
            CbPeriodo.SelectedValue = "1°";
            txtNum.Text = "123";
            txtTelefone.Text = "11971258656";
            cbEstadoCivil.Text = "Solteiro";
            cbGenero.Text = "Masculino";
            dtAluno.Value = new DateTime(1999, 12, 31);
        }
    }
}