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
    public partial class EditarProfessor : Form
    {
        private ProfessorModel professormodel = new ProfessorModel();
        private MateriaModel materiamodel = new MateriaModel();
        private Validar validar = new Validar();
        private Professor professor;

        public EditarProfessor(Professor professor)
        {
            this.professor = professor;
            InitializeComponent();
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            Validar.FormatarData(dtProfessor, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            gridMaterias.DataSource = materiamodel.ListarMateria();
            AdicionarMateriasNaLista();
            PopularCampos();
            SelecionarMaterias();
        }

        private void PopularCampos()
        {
            txtID.Text = professor.Id.ToString();
            txtNome.Text = professor.Nome;
            cbEstadoCivil.Text = professor.Estadocivil;
            txtSalario.Text = professor.Salario;
            cbGenero.Text = professor.Genero;
            dtProfessor.Text = professor.Datanascimento.ToString();
            txtEmail.Text = professor.Email;
            txtTelefone.Text = professor.Telefone;
            txtCEP.Text = professor.Cep;
            txtCidade.Text = professor.Cidade;
            txtEstado.Text = professor.Uf;
            txtBairro.Text = professor.Bairro;
            txtRua.Text = professor.Rua;
            txtNum.Text = professor.Numerorua;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o professor?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Editar();
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

        private void Editar()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string nome = txtNome.Text;
                string estadocivil = cbEstadoCivil.Text;
                string genero = cbGenero.Text;
                DateTime datanascimento = dtProfessor.Value;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string cep = txtCEP.Text;
                string cidade = txtCidade.Text;
                string uf = txtEstado.Text;
                string bairro = txtBairro.Text;
                string rua = txtRua.Text;
                string numerorua = txtNum.Text;
                string salario = txtSalario.Text;
                List<Materia> materias = ReceberMateriasSelecionadas();

                Professor professor = new Professor(id, nome, materias, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua);

                professormodel.Editar(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Materia> ReceberMateriasSelecionadas()
        {
            List<Materia> materias = new List<Materia>();
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    Materia materia = new Materia(Convert.ToInt32(row.Cells[1].Value), row.Cells[2].Value.ToString());
                    materias.Add(materia);
                }
                else if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    Materia materia = new Materia(Convert.ToInt32(row.Cells[1].Value), row.Cells[2].Value.ToString());
                    materias.Remove(materia);
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
            if (validar.ValidateControls(this))
            {
                try
                {
                    professor.Id = Convert.ToInt32(txtID.Text);
                    professormodel.Excluir(professor);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        #region Validações

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            validar.ValidarSalario(txtSalario);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaLetra(e);
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            validar.VerificaCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.BloqueiaEspaco(e);
        }

        #endregion Validações

        private void SelecionarMaterias()
        {
            foreach (string item in ListaMaterias.Items)
            {
                foreach (DataGridViewRow row in gridMaterias.Rows)
                {
                    if (row.Cells[2].Value.ToString() == item)
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }
        }

        private void AdicionarMateriasNaLista()
        {
            foreach (Materia item in professor.Materia)
            {
                ListaMaterias.Items.Add(item.Nome);
            }
        }

        private void AddOnList()
        {
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    if (!ListaMaterias.Items.Contains(row.Cells[2].Value))
                    {
                        ListaMaterias.Items.Add(row.Cells[2].Value);
                    }
                }
            }
        }

        private void RemoveOnList()
        {
            foreach (DataGridViewRow row in gridMaterias.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    if (ListaMaterias.Items.Contains(row.Cells[2].Value))
                    {
                        ListaMaterias.Items.Remove(row.Cells[2].Value);
                    }
                }
            }
        }

        private void gridMaterias_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            AddOnList();
            RemoveOnList();
        }

        private void gridMaterias_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            AddOnList();
            RemoveOnList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}