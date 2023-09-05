using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class CadastroProfessor : Form
    {
        private ProfessorModel professorM = new ProfessorModel();
        private Validar validar = new Validar();
        private MateriaModel materiaM = new MateriaModel();

        public CadastroProfessor()
        {
            InitializeComponent();
            gridMaterias.DataSource = materiaM.ListarMateria();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            LimparCampos();
            Validar.FormatarData(dtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            LoadGrid();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            cbEstadoCivil.SelectedValue = 0;
            cbGenero.SelectedValue = 0;
            txtEmail.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
            txtSalario.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja cadastrar o professor?", "Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Professor professores = new Professor();
                        Salvar(professores);
                        MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o profesor:" + ex.Message);
                }
            }
        }

        private void Salvar(Professor professor)
        {
            try
            {
                professor.Nome = txtNome.Text;

                for (int i = 0; i < gridMaterias.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(gridMaterias.Rows[i].Cells[0].Value) == true)
                    {
                        professor.ListaDemateria.Add(Convert.ToInt32(gridMaterias.Rows[i].Cells[1].Value));
                    }
                }
                professor.EstadoCivil = cbEstadoCivil.Text;
                professor.Genero = cbGenero.Text;
                professor.Email = txtEmail.Text;
                professor.Cep = txtCEP.Text;
                professor.Uf = txtEstado.Text;
                professor.Salario = txtSalario.Text;
                professor.Cidade = txtCidade.Text;
                professor.Bairro = txtBairro.Text;
                professor.Rua = txtRua.Text;
                professor.Numerorua = txtNum.Text;
                professor.Telefone = txtTelefone.Text;
                professor.Datanascimento = dtProfessor.Value;

                professorM.Salvar(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            double salario;
            if (Double.TryParse(txtSalario.Text, out salario))
            {
                txtSalario.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", salario);

                if (salario < 2000)
                {
                    MessageBox.Show("Salário Inválido (Menor que R$ 2.000)");
                    txtSalario.Text = "";
                    txtSalario.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite um valor numérico válido.");
                txtSalario.Text = "";
                txtSalario.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaLetra(e);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCEP.Text) && txtCEP.MaskCompleted)
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());
                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("CEP não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCEP.Clear();
                        txtCEP.Focus();
                    }
                }
            }
            txtNum.Clear();
        }

        public void LoadGrid()
        {
            gridMaterias.DataSource = materiaM.ListarMateria();
            gridMaterias.Columns[0].HeaderText = "Escolher";
            gridMaterias.Columns[0].Width = 30;
            gridMaterias.Columns[1].Visible = false;
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

        private void gridMaterias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AddOnList();
            RemoveOnList();
        }
    }
}