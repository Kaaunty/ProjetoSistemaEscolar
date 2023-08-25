using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class CadastroProfessor : Form
    {
        private ProfessorModel professorM = new ProfessorModel();
        private Validar validar = new Validar();
        private CursoModel cursoM = new CursoModel();

        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            Validar.FormatarData(dtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            CarregarComboBox();
        }

        #region Habilitar, Limpar, Desabilitar Campos

        public void HabilitarCampos()
        {
            try
            {
                txtNome.Enabled = true;
                cbCurso.Enabled = true;
                cbMateria.Enabled = true;
                cbEstadoCivil.Enabled = true;
                cbGenero.Enabled = true;
                txtEmail.Enabled = true;
                txtCEP.Enabled = true;
                txtEstado.Enabled = true;
                txtSalario.Enabled = true;
                txtCidade.Enabled = true;
                txtBairro.Enabled = true;
                txtRua.Enabled = true;
                txtNum.Enabled = true;
                txtTelefone.Enabled = true;
                dtProfessor.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            cbCurso.SelectedValue = 0;
            cbMateria.SelectedValue = 0;
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

        public void DesabilitarCampos()
        {
            try
            {
                txtNome.Enabled = false;
                cbCurso.Enabled = false;
                cbMateria.Enabled = false;
                cbEstadoCivil.Enabled = false;
                cbGenero.Enabled = false;
                txtEmail.Enabled = false;
                txtCEP.Enabled = false;
                txtEstado.Enabled = false;
                txtSalario.Enabled = false;
                txtCidade.Enabled = false;
                txtBairro.Enabled = false;
                txtRua.Enabled = false;
                txtNum.Enabled = false;
                txtTelefone.Enabled = false;
                dtProfessor.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Habilitar, Limpar, Desabilitar Campos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnSalvar.Enabled = true;
            HabilitarCampos();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor professores = new Professor();
            Salvar(professores);
        }

        private void Salvar(Professor professor)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    professor.Nome = txtNome.Text;
                    professor.Curso = cbCurso.Text;
                    professor.Materia = cbMateria.Text;
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
                    MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LimparCampos();
                    DesabilitarCampos();
                    btnSalvar.Enabled = false;
                }
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCEP.Text))
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

        #region Carregar ComboBox e Verificar Espaços

        private void CarregarComboBox()
        {
            //
            cbCurso.DataSource = cursoM.ListarCursos();
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.SelectedIndex = -1;
            //
            int cursoid = Convert.ToInt32(cbCurso.SelectedValue);
            DataTable materia_curso = cursoM.BuscarMateria(cursoid);
            cbMateria.DataSource = materia_curso;
            cbMateria.DisplayMember = "Nome";
            cbMateria.ValueMember = "id";
        }

        #endregion Carregar ComboBox e Verificar Espaços

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            DataTable materia_curso = cursoM.BuscarMateria(Convert.ToInt32(cbCurso.SelectedValue));
            cbMateria.DataSource = materia_curso;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            VisualizarProfessor visualizarProfessor = new VisualizarProfessor();
            visualizarProfessor.ShowDialog();
        }
    }
}