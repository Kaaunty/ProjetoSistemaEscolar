using MySqlX.XDevAPI.Relational;
using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditarProfessor : Form
    {
        private MateriaModel materiaM = new MateriaModel();
        private ProfessorModel professormodel = new ProfessorModel();
        private Validar validar = new Validar();
        private VisualizarProfessor instanciaDoForm2;
        private char[] delimitarchars = { '-', ',' };

        public EditarProfessor(VisualizarProfessor InstanciaVisualizar)
        {
            InitializeComponent();
            gridMaterias.DataSource = materiaM.ListarMateria();
            ListaMaterias.Visible = false;
            instanciaDoForm2 = InstanciaVisualizar; //passo o valor do form1 para o objeto criado
            txtID.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[1].Value.ToString();
            txtSalario.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[3].Value.ToString();
            cbEstadoCivil.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[4].Value.ToString();
            cbGenero.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[5].Value.ToString();
            dtProfessor.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[8].Value.ToString();
            txtCEP.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[9].Value.ToString();

            foreach (DataGridViewRow rowprofessor in instanciaDoForm2.gridProfessor.Rows)
            {
                if (rowprofessor.Cells[0].Value.ToString() == txtID.Text)
                {
                    foreach (DataGridViewRow rowmateria in gridMaterias.Rows)
                    {
                        if (rowmateria.Cells[1].Value.ToString() == rowprofessor.Cells[10].Value.ToString())
                        {
                            rowmateria.Cells[0].Value = true;
                        }
                    }
                }
            }
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            Validar.FormatarData(dtProfessor, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            SelecionarMaterias();
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
                        MessageBox.Show("Professor editado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar professor: " + ex.Message);
                }
            }
        }

        private void Editar(Professor professor)
        {
            try
            {
                professor.Id = Convert.ToInt32(txtID.Text);
                professor.Nome = txtNome.Text;
                // VERIFICAR ISSO -->
                for (int i = 0; i < gridMaterias.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(gridMaterias.Rows[i].Cells[0].Value) == true)
                    {
                        //professor.Materia.Add(Convert.ToInt32(gridMaterias.Rows[i].Cells[1].Value));
                    }
                    else if (Convert.ToBoolean(gridMaterias.Rows[i].Cells[0].Value) == false)
                    {
                    }
                }
                professor.EstadoCivil = cbEstadoCivil.Text;
                professor.Genero = cbGenero.Text;
                professor.Salario = txtSalario.Text;
                professor.Datanascimento = Convert.ToDateTime(dtProfessor.Text);
                professor.Email = txtEmail.Text;
                professor.Telefone = txtTelefone.Text;
                professor.Cep = txtCEP.Text;
                professor.Cidade = txtCidade.Text;
                professor.Uf = txtEstado.Text;
                professor.Bairro = txtBairro.Text;
                professor.Rua = txtRua.Text;
                professor.Numerorua = txtNum.Text;

                professormodel.Editar(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o professor?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Professor excluido com sucesso!");
            }
        }

        private void Excluir(Professor professor)
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

        #endregion Validações

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
    }
}