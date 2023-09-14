using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

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
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            validar.LimparControles(this);
            Validar.FormatarData(dtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            PopularGrid();
        }

        private void PopularGrid()
        {
            gridMaterias.AutoGenerateColumns = false;
            gridMaterias.DataSource = materiaM.ListarMateria();
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
                        Salvar();
                        MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validar.LimparControles(this);
                        LimparDataGrid();
                        PopularGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o professor:" + ex.Message);
                }
            }
        }

        private void Salvar()
        {
            try
            {
                string nome = txtNome.Text;
                List<Materia> materia = ReceberMateriasSelecionadas();
                string estadocivil = cbEstadoCivil.Text;
                string genero = cbGenero.Text;
                string email = txtEmail.Text;
                string cep = txtCEP.Text;
                string uf = txtEstado.Text;
                string salario = txtSalario.Text;
                string cidade = txtCidade.Text;
                string bairro = txtBairro.Text;
                string rua = txtRua.Text;
                string numerorua = txtNum.Text;
                string telefone = txtTelefone.Text;
                DateTime datanascimento = dtProfessor.Value;
                Professor professor = new Professor(nome, materia, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua);
                professorM.Salvar(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Materia> ReceberMateriasSelecionadas()
        {
            try
            {
                List<Materia> materias = new List<Materia>();
                foreach (DataGridViewRow row in gridMaterias.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        Materia materia = new Materia();
                        materia.Materiaid = Convert.ToInt32(row.Cells[2].Value);
                        materias.Add(materia);
                    }
                }
                return materias;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LimparDataGrid()
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
            validar.ValidarSalario(txtSalario);
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
            validar.VerificaCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.BloqueiaEspaco(e);
        }

        #endregion Botões

        private void BtnTest_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Teste";
            txtEmail.Text = "Teste@teste.com";
            txtCEP.Text = "13254685";
            txtSalario.Text = "9999";
            txtNum.Text = "123";
            txtTelefone.Text = "11971258656";
            cbEstadoCivil.Text = "Solteiro";
            cbGenero.Text = "Masculino";
            dtProfessor.Value = new DateTime(1999, 12, 31);
        }
    }
}