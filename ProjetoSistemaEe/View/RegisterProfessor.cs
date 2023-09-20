using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            validate.FormatDate(DtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            SubjectsGrid.AutoGenerateColumns = false;
            SubjectsGrid.DataSource = subjectModel.GetSubjects();
        }

        private void BtnSave_Click(object sender, EventArgs e)
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
                string name = TxtName.Text;
                List<Subjects> subjects = GetSeletectedSubjects();
                string martialStatus = CbMartialStatus.Text;
                string gender = CbGender.Text;
                string email = txtEmail.Text;
                string zipCode = TxtZipCode.Text;
                string state = TxtState.Text;
                string salary = TxtSalary.Text;
                string city = TxtCity.Text;
                string district = TxtDistrict.Text;
                string street = TxtStreet.Text;
                string streetNumber = TxtNum.Text;
                string phone = TxtPhone.Text;
                DateTime birchDate = DtProfessor.Value;
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
                foreach (DataGridViewRow row in SubjectsGrid.Rows)
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
            foreach (DataGridViewRow row in SubjectsGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells[0].Value = false;
                }
            }
        }

        #region Validations

        private void TxtSalary_Leave(object sender, EventArgs e)
        {
            validate.ValidateSalary(TxtSalary);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void TxtZipCode_TextChanged(object sender, EventArgs e)
        {
            validate.ValidateCEP(TxtZipCode, TxtState, TxtCity, TxtDistrict, TxtStreet, TxtNum);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.BlockSpaceBar(e);
        }

        public bool ValidateGridSelected()
        {
            foreach (DataGridViewRow row in SubjectsGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    return true;
                }
            }
            MessageBox.Show("Selecione pelo menos uma matéria!");
            return false;
        }

        #endregion Validations

        #region Buttons

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            MainMenu Mainmenu = new MainMenu();
            Mainmenu.TopLevel = true;
            Mainmenu.Show();
            Close();
        }

        #endregion Buttons

        private void BtnTest_Click(object sender, EventArgs e)
        {
            TxtName.Text = "Teste";
            txtEmail.Text = "Teste@teste.com";
            TxtZipCode.Text = "13254685";
            TxtSalary.Text = "R$ 9.999,00";
            TxtNum.Text = "123";
            TxtPhone.Text = "11971258656";
            CbMartialStatus.Text = "Solteiro";
            CbGender.Text = "Masculino";
            DtProfessor.Value = new DateTime(1999, 12, 31);
        }
    }
}