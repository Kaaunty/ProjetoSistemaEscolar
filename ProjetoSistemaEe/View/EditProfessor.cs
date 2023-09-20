using MySqlX.XDevAPI.Relational;
using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditProfessor : Form
    {
        private ProfessorModel professorModel = new ProfessorModel();
        private SubjectsModel subjectModel = new SubjectsModel();
        private Validations validate = new Validations();
        private Professor professor;

        public EditProfessor(Professor professor)
        {
            this.professor = professor;
            InitializeComponent();
            SubjectsGrid.AutoGenerateColumns = false;
            SubjectsGrid.DataSource = subjectModel.GetSubjects();
        }

        private void EditProfessor_Load(object sender, EventArgs e)
        {
            validate.FormatDate(DtProfessor, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            PopulateFields();
            SelectSubjects();
        }

        private void PopulateFields()
        {
            txtID.Text = professor.Id.ToString();
            TxtName.Text = professor.Name;
            CbMartialStatus.Text = professor.MaritalStatus;
            TxtSalary.Text = professor.Salary;
            CbGender.Text = professor.Gender;
            DtProfessor.Text = professor.BirthDate.ToString();
            txtEmail.Text = professor.Email;
            TxtPhone.Text = professor.Phone;
            TxtZipCode.Text = professor.ZipCode;
            TxtCity.Text = professor.City;
            TxtState.Text = professor.State;
            TxtDistrict.Text = professor.District;
            TxtStreet.Text = professor.Street;
            TxtNum.Text = professor.StreetNumber;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this) && ValidateGridSelected())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o professor?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        EditGrade();
                        MessageBox.Show("Professor editado com sucesso!");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar professor: " + ex.Message);
                }
            }
        }

        private void EditGrade()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string name = TxtName.Text;
                string martialStatus = CbMartialStatus.Text;
                string gender = CbGender.Text;
                DateTime birthDate = DtProfessor.Value;
                string email = txtEmail.Text;
                string phone = TxtPhone.Text;
                string zipCode = TxtZipCode.Text;
                string city = TxtCity.Text;
                string state = TxtState.Text;
                string district = TxtDistrict.Text;
                string street = TxtStreet.Text;
                string streetNumber = TxtNum.Text;
                string salary = TxtSalary.Text;
                List<Subjects> subjects = GetSeletectedSubjects();

                Professor professor = new Professor(id, name, subjects, salary, martialStatus, gender, birthDate, email, phone, zipCode, city, state, district, street, streetNumber);

                professorModel.Edit(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Subjects> GetSeletectedSubjects()
        {
            List<Subjects> subjects = new List<Subjects>();
            foreach (DataGridViewRow row in SubjectsGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int subjectId = Convert.ToInt32(row.Cells[3].Value);
                    string name = row.Cells[1].Value.ToString();
                    Subjects subject = new Subjects(subjectId, name);
                    subjects.Add(subject);
                }
            }
            return subjects;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o professor?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Delete();
                MessageBox.Show("Professor excluido com sucesso!");
                Close();
            }
        }

        private void Delete()
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    professor.Id = Convert.ToInt32(txtID.Text);
                    professorModel.Delete(professor);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void SelectSubjects()
        {
            foreach (Subjects item in professor.Subjects)
            {
                foreach (DataGridViewRow row in SubjectsGrid.Rows)
                {
                    if (item.SubjectName == row.Cells[1].Value.ToString())
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }
        }

        #region Validations

        private void TxtSalary_Leave(object sender, EventArgs e)
        {
            validate.ValidateSalary(TxtSalary);
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
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