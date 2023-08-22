using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using ProjetoSistemaEe.View;
using System;
using System.Data;
using System.Management;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetoSistemaEe
{
    public partial class CadastroAluno : Form
    {
        private AlunoModel alunoM = new AlunoModel();
        private AlunoDAO alunoDAO = new AlunoDAO();
        private CursoModel cursoM = new CursoModel();

        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            Validar.FormatarData(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            CarregarComboBox();
            GerarRA();
        }

        #region Habilitar, Limpar, Desabilitar Campos

        public void HabilitarCampos()
        {
            try
            {
                txtNome.Enabled = true;
                cbCurso.Enabled = true;
                CbPeriodo.Enabled = true;
                cbMateria.Enabled = true;
                cbEstadoCivil.Enabled = true;
                cbGenero.Enabled = true;
                txtEmail.Enabled = true;
                txtCEP.Enabled = true;
                txtEstado.Enabled = true;
                cbTurno.Enabled = true;
                txtCidade.Enabled = true;
                txtBairro.Enabled = true;
                txtRua.Enabled = true;
                txtNum.Enabled = true;
                txtTelefone.Enabled = true;
                dtAluno.Enabled = true;
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
            CbPeriodo.SelectedValue = 0;
            cbMateria.SelectedValue = 0;
            cbEstadoCivil.SelectedValue = 0;
            cbGenero.SelectedValue = 0;
            txtEmail.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
            cbTurno.SelectedValue = 0;
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
            txtRA.Clear();
        }

        public void DesabilitarCampos()
        {
            try
            {
                txtNome.Enabled = false;
                cbCurso.Enabled = false;
                CbPeriodo.Enabled = false;
                cbMateria.Enabled = false;
                cbEstadoCivil.Enabled = false;
                cbGenero.Enabled = false;
                txtEmail.Enabled = false;
                txtCEP.Enabled = false;
                txtEstado.Enabled = false;
                cbTurno.Enabled = false;
                txtCidade.Enabled = false;
                txtBairro.Enabled = false;
                txtRua.Enabled = false;
                txtNum.Enabled = false;
                txtTelefone.Enabled = false;
                dtAluno.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Habilitar, Limpar, Desabilitar Campos

        #region Botões

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnSalvar.Enabled = true;

            HabilitarCampos();
            txtNome.Focus();
            GerarRA();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno alunos = new Aluno();
            Salvar(alunos);
        }

        private void Salvar(Aluno aluno)
        {
            if (VerificarEspacos())
            {
                try
                {
                    aluno.RA = Convert.ToInt32(txtRA.Text);
                    aluno.Nome = txtNome.Text;
                    aluno.Curso = cbCurso.Text;
                    aluno.Periodo = CbPeriodo.Text;
                    aluno.Materia = cbMateria.Text;
                    aluno.EstadoCivil = cbEstadoCivil.Text;
                    aluno.Genero = cbGenero.Text;
                    aluno.Email = txtEmail.Text;
                    aluno.Turno = cbTurno.Text;
                    aluno.Telefone = txtTelefone.Text;
                    aluno.Cep = txtCEP.Text;
                    aluno.Cidade = txtCidade.Text;
                    aluno.Uf = txtEstado.Text;
                    aluno.Bairro = txtBairro.Text;
                    aluno.Rua = txtRua.Text;
                    aluno.Numerorua = txtNum.Text;
                    aluno.Datanascimento = Convert.ToDateTime(dtAluno.Text);
                    alunoM.Salvar(aluno);
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    LimparCampos();
                    DesabilitarCampos();
                    btnSalvar.Enabled = false;
                }
            }
        }

        #endregion Botões

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

        private bool VerificarEspacos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome");
                txtNome.Focus();
                return false;
            }
            if (cbCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Curso");
                cbCurso.Focus();
                return false;
            }
            if (cbCurso.Text == "")
            {
                MessageBox.Show("Preencha o campo Curso");
                cbCurso.Focus();
                return false;
            }
            if (cbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Materia");
                cbMateria.Focus();
                return false;
            }
            if (cbMateria.Text == "")
            {
                MessageBox.Show("Preencha o campo Materia");
                cbMateria.Focus();
                return false;
            }
            if (cbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Genero");
                cbGenero.Focus();
                return false;
            }
            if (cbGenero.Text == "")
            {
                MessageBox.Show("Preencha o campo Genero");
                cbGenero.Focus();
                return false;
            }
            if (cbEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Estado Civil");
                cbEstadoCivil.Focus();
                return false;
            }
            if (cbEstadoCivil.Text == "")
            {
                MessageBox.Show("Preencha o campo Estado Civil");
                cbEstadoCivil.Focus();
                return false;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome");
                txtNome.Focus();
                return false;
            }
            if (CbPeriodo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Periodo");
                CbPeriodo.Focus();
                return false;
            }
            if (cbTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Turno");
                cbTurno.Focus();
                return false;
            }
            if (txtTelefone.Text == "(  )     -")
            {
                MessageBox.Show("Preencha o campo Telefone");
                txtTelefone.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email");
                txtEmail.Focus();
                return false;
            }
            if (txtTelefone.TextLength < 14)
            {
                MessageBox.Show("Preencha o campo Telefone");
                txtTelefone.Focus();
                return false;
            }
            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo Telefone");
                txtTelefone.Focus();
                return false;
            }
            if (txtCEP.TextLength < 9)
            {
                MessageBox.Show("Preencha o campo CEP");
                txtCEP.Focus();
                return false;
            }
            if (txtCEP.Text == "     -")
            {
                MessageBox.Show("Preencha o campo CEP");
                txtCEP.Focus();
                return false;
            }
            if (txtEstado.Text == "")
            {
                MessageBox.Show("Preencha o campo Estado");
                txtEstado.Focus();
                return false;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Preencha o campo Cidade");
                txtCidade.Focus();
                return false;
            }

            if (txtRua.Text == "")
            {
                MessageBox.Show("Preencha o campo Endereço");
                txtRua.Focus();
                return false;
            }
            if (txtNum.Text == "")
            {
                MessageBox.Show("Preencha o campo Número");
                txtNum.Focus();
                return false;
            }
            if (txtRA.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para editar!");
                txtRA.Focus();
                return false;
            }
            return true;
        }

        #endregion Carregar ComboBox e Verificar Espaços

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

        private int GerarRA()
        {
            string raStr;
            int ra;
            try
            {
                do
                {
                    string raAno = DateTime.Now.Year.ToString();
                    string raNum = new Random().Next(100000, 999999).ToString();
                    raStr = raAno + raNum;
                    ra = int.Parse(raStr);
                } while (alunoDAO.VerificarRA(ra));
                txtRA.Text = raStr;
                return ra;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #region TextChanged

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            DataTable materia_curso = cursoM.BuscarMateria(Convert.ToInt32(cbCurso.SelectedValue));
            cbMateria.DataSource = materia_curso;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nomeOriginal = txtNome.Text;
            string nomeModificado = nomeOriginal;

            while (Validar.ValidaNumeroOuCaracterEspecial(nomeModificado))
            {
                nomeModificado = Regex.Replace(nomeModificado, @"\d", "");
                nomeModificado = Regex.Replace(nomeModificado, @"[^\w\s]", "");
                nomeModificado = nomeModificado.Replace("_", "");

                if (nomeModificado == nomeOriginal)
                    break;

                nomeOriginal = nomeModificado;
            }

            txtNome.Text = nomeModificado;
            txtNome.SelectionStart = nomeModificado.Length;
        }

        #endregion TextChanged

        private void BtnMouseDown(object sender, MouseEventArgs e)
        {
            ButtonHelper.ChangeButtonBackgroundImageOnMouseDown((Button)sender);
        }

        private void BtnLeave(object sender, EventArgs e)
        {
            ButtonHelper.ChangeButtonBackgroundImageOnLeave((Button)sender);
        }

        private void BtnHover(object sender, EventArgs e)
        {
            ButtonHelper.ChangeButtonBackgroundImageOnHover((Button)sender);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            VisualizarAluno visualizarAluno = new VisualizarAluno();
            visualizarAluno.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            CadastroProfessor cadastroProfessor = new CadastroProfessor();
            cadastroProfessor.ShowDialog();
        }
    }
}