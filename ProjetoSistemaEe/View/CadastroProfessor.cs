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
            gridMaterias.DataSource = materiaM.ListarMateria();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            validar.LimparControles(this);
            Validar.FormatarData(dtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            PopularGrid();
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
                    MessageBox.Show("Erro ao cadastrar o profesor:" + ex.Message);
                }
            }
        }

        private void Salvar()
        {
            try
            {
                Professor professor = new Professor
                {
                    Nome = txtNome.Text,
                    Materia = ReceberMateriasSelecionadas(),
                    Estadocivil = cbEstadoCivil.Text,
                    Genero = cbGenero.Text,
                    Email = txtEmail.Text,
                    Cep = txtCEP.Text,
                    Uf = txtEstado.Text,
                    Salario = txtSalario.Text,
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    Rua = txtRua.Text,
                    Numerorua = txtNum.Text,
                    Telefone = txtTelefone.Text,
                    Datanascimento = dtProfessor.Value
                };
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
                        materia.Cursoid = Convert.ToInt32(row.Cells[1].Value);
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

        private void PopularGrid()
        {
            try
            {
                gridMaterias.DataSource = materiaM.ListarMateria();
            }
            catch (Exception)
            {
                throw;
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
    }
}