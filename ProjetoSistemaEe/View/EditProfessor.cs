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
            gridMaterias.AutoGenerateColumns = false;
            gridMaterias.DataSource = subjectModel.GetSubjects();
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            validate.FormatDate(dtProfessor, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            PopulateFields();
            SelectSubjects();
        }

        private void PopulateFields()
        {
            txtID.Text = professor.Id.ToString();
            txtNome.Text = professor.Name;
            cbEstadoCivil.Text = professor.MartialStatus;
            txtSalario.Text = professor.Salary;
            cbGenero.Text = professor.Gender;
            dtProfessor.Text = professor.BirthDate.ToString();
            txtEmail.Text = professor.Email;
            txtTelefone.Text = professor.Phone;
            txtCEP.Text = professor.ZipCode;
            txtCidade.Text = professor.City;
            txtEstado.Text = professor.State;
            txtBairro.Text = professor.District;
            txtRua.Text = professor.Street;
            txtNum.Text = professor.StreetNumber;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validate.ValidateControls(this) && ValidateGridSelected())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o professor?", "EditStudent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                string name = txtNome.Text;
                string martialStatus = cbEstadoCivil.Text;
                string gender = cbGenero.Text;
                DateTime birchDate = dtProfessor.Value;
                string email = txtEmail.Text;
                string phone = txtTelefone.Text;
                string zipCode = txtCEP.Text;
                string city = txtCidade.Text;
                string state = txtEstado.Text;
                string district = txtBairro.Text;
                string street = txtRua.Text;
                string streetNumber = txtNum.Text;
                string salary = txtSalario.Text;
                List<Subjects> subjects = GetSeletectedSubjects();

                Professor professor = new Professor(id, name, subjects, salary, martialStatus, gender, birchDate, email, phone, zipCode, city, state, district, street, streetNumber);

                professorModel.Edit(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Subjects> GetSeletectedSubjects()
        {
            List<Subjects> materias = new List<Subjects>();
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int materiaid = Convert.ToInt32(row.Cells[3].Value);
                    string nome = row.Cells[1].Value.ToString();
                    Subjects materia = new Subjects(materiaid, nome);
                    materias.Add(materia);
                }
            }
            return materias;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o professor?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Excluir();
                MessageBox.Show("Professor excluido com sucesso!");
                Close();
            }
        }

        private void Excluir()
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
                foreach (DataGridViewRow row in gridMaterias.Rows)
                {
                    if (item.SubjectName == row.Cells[1].Value.ToString())
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }
        }

        #region Validações

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            validate.ValidateSalary(txtSalario);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
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

        #region Botões Menu

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Botões Menu
    }
}