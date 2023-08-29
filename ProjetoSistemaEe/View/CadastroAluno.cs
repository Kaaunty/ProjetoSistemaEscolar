using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe
{
    public partial class CadastroAluno : Form
    {
        private AlunoModel alunoM = new AlunoModel();
        private AlunoDAO alunoDAO = new AlunoDAO();
        private Validar validar = new Validar();
        private CursoModel cursoM = new CursoModel();

        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparCampos();
            Validar.FormatarData(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            CarregarComboBox();
            GerarRA();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            cbCurso.SelectedValue = 0;
            CbPeriodo.SelectedValue = 0;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja cadastrar o aluno?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        Aluno alunos = new Aluno();
                        Salvar(alunos);
                        MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o aluno:" + ex.Message);
                }
            }
        }

        private void Salvar(Aluno aluno)
        {
            try
            {
                aluno.RA = Convert.ToInt32(txtRA.Text);
                aluno.Nome = txtNome.Text;
                aluno.Curso = cbCurso.Text;
                aluno.Periodo = CbPeriodo.Text;
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
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboBox()
        {
            cbCurso.DataSource = cursoM.ListarCursos();
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.SelectedIndex = -1;
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
    }
}