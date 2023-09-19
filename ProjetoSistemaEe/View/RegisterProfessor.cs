using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ProjetoSistemaEe.View
{
    public partial class RegisterProfessor : Form
    {
        private ProfessorModel professorModel = new ProfessorModel();
        private Validations validate = new Validations();
        private SubjectsModel subjectModel = new SubjectsModel();

        public RegisterProfessor()
        {
            InitializeComponent();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            validate.ClearControls(this);
            validate.FormatDate(dtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            gridMaterias.AutoGenerateColumns = false;
            gridMaterias.DataSource = subjectModel.GetSubjects();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this) && ValidateGridSelected())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja cadastrar o professor?", "Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Register();
                        MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validate.ClearControls(this);
                        ClearDataGrid();
                        PopulateGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o professor:" + ex.Message);
                }
            }
        }

        private void Register()
        {
            try
            {
                string name = txtNome.Text;
                List<Subjects> subjects = GetSeletectedSubjects();
                string martialStatus = cbEstadoCivil.Text;
                string gender = cbGenero.Text;
                string email = txtEmail.Text;
                string zipCode = txtCEP.Text;
                string state = txtEstado.Text;
                string salary = txtSalario.Text;
                string city = txtCidade.Text;
                string district = txtBairro.Text;
                string street = txtRua.Text;
                string streetNumber = txtNum.Text;
                string phone = txtTelefone.Text;
                DateTime birchDate = dtProfessor.Value;
                Professor professor = new Professor(name, subjects, salary, martialStatus, gender, birchDate, email, phone, zipCode, city, state, district, street, streetNumber);
                professorModel.Register(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Subjects> GetSeletectedSubjects()
        {
            try
            {
                List<Subjects> subjects = new List<Subjects>();
                foreach (DataGridViewRow row in gridMaterias.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        Subjects subject = new Subjects();
                        subject.SubjectId = Convert.ToInt32(row.Cells[3].Value);
                        subjects.Add(subject);
                    }
                }
                return subjects;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ClearDataGrid()
        {
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells[0].Value = false;
                }
            }
        }

        #region Validações

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            validate.ValidateSalary(txtSalario);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            validate.ValidateCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.BlockSpaceBar(e);
        }

        public bool ValidateGridSelected()
        {
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    return true;
                }
            }
            MessageBox.Show("Selecione pelo menos uma matéria!");
            return false;
        }

        #endregion Validações

        #region Botões

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
            MenuPrincipal main_Menu = new MenuPrincipal();
            main_Menu.TopLevel = true;
            main_Menu.Show();
            Close();
        }

        #endregion Botões

        private void BtnTest_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Teste";
            txtEmail.Text = "Teste@teste.com";
            txtCEP.Text = "13254685";
            txtSalario.Text = "R$ 9.999,00";
            txtNum.Text = "123";
            txtTelefone.Text = "11971258656";
            cbEstadoCivil.Text = "Solteiro";
            cbGenero.Text = "Masculino";
            dtProfessor.Value = new DateTime(1999, 12, 31);
        }
    }
}