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
        private Validar validar = new Validar();
        private CursoModel cursoM = new CursoModel();
        private Calcular calcular = new Calcular();

        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            validar.LimparControles(this);
            Validar.FormatarData(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            PolularComboBox();
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
                        validar.LimparControles(this);
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
                aluno.RA = calcular.GerarRA();
                aluno.Nome = txtNome.Text;
                aluno.Curso = Convert.ToInt32(cbCurso.SelectedValue);
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

        private void PolularComboBox()
        {
            cbCurso.DataSource = cursoM.ListarCursos();
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.SelectedIndex = -1;
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
    }
}