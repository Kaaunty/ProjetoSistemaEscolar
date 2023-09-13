using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditarAluno : Form
    {
        private CursoModel cursoModel = new CursoModel();
        private AlunoModel alunoModel = new AlunoModel();
        private Validar validar = new Validar();
        private Aluno aluno;

        public EditarAluno(Aluno aluno)
        {
            this.aluno = aluno;
            InitializeComponent();
            CarregarComboBox();
            Validar.FormatarData(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
        }

        private void EditarAluno_Load(object sender, EventArgs e)
        {
            PopularCampos();
        }

        private void PopularCampos()
        {
            txtRA.Text = aluno.RA.ToString();
            txtNome.Text = aluno.Nome;
            cbCurso.SelectedValue = aluno.Curso.Id_curso;
            cbPeriodo.Text = aluno.Periodo;
            cbEstadoCivil.Text = aluno.Estadocivil;
            cbGenero.Text = aluno.Genero;
            dtAluno.Text = aluno.Datanascimento.ToString();
            txtEmail.Text = aluno.Email;
            cbTurno.Text = aluno.Turno;
            txtTelefone.Text = aluno.Telefone;
            txtCEP.Text = aluno.Cep;
            txtCidade.Text = aluno.Cidade;
            txtEstado.Text = aluno.Uf;
            txtBairro.Text = aluno.Bairro;
            txtRua.Text = aluno.Rua;
            txtNum.Text = aluno.Numerorua;
        }

        private void CarregarComboBox()
        {
            cbCurso.DataSource = cursoModel.ListarCursos();
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja editar o aluno?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Editar();
                        MessageBox.Show("Aluno editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar aluno!" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Editar()
        {
            try
            {
                int ra = Convert.ToInt32(txtRA.Text);
                string nome = txtNome.Text;
                Curso curso = new Curso(Convert.ToInt32(cbCurso.SelectedValue));
                string periodo = cbPeriodo.Text;
                string estadocivil = cbEstadoCivil.Text;
                string genero = cbGenero.Text;
                DateTime datanascimento = Convert.ToDateTime(dtAluno.Text);
                string email = txtEmail.Text;
                string turno = cbTurno.Text;
                string telefone = txtTelefone.Text;
                string cep = txtCEP.Text;
                string cidade = txtCidade.Text;
                string uf = txtEstado.Text;
                string bairro = txtBairro.Text;
                string rua = txtRua.Text;
                string numerorua = txtNum.Text;
                Aluno aluno = new Aluno(ra, nome, curso, periodo, estadocivil, genero, datanascimento, email, turno, telefone, cep, cidade, uf, bairro, rua, numerorua);
                alunoModel.Editar(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja excluir o aluno?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ExcluirAluno();
                    MessageBox.Show("Aluno excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno!" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirAluno()
        {
            try
            {
                aluno.RA = Convert.ToInt32(txtRA.Text);
                alunoModel.Excluir(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Validações

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            validar.VerificaCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaLetra(e);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.BloqueiaEspaco(e);
        }

        #endregion Validações

        #region Botões

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal main_Menu = new MenuPrincipal();
            main_Menu.TopLevel = true;
            main_Menu.Show();
        }

        #endregion Botões
    }
}