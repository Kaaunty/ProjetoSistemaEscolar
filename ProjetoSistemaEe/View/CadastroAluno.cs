using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using ProjetoSistemaEe.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSistemaEe
{
    public partial class CadastroAluno : Form
    {
        private AlunoModel alunoM = new AlunoModel();
        private Validar validar = new Validar();
        private CursoModel cursoM = new CursoModel();
        private Calculos calcular = new Calculos();

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
                        SalvarAluno();
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

        private void SalvarAluno()
        {
            try
            {
                int ra = calcular.GerarRA();
                string nome = txtNome.Text;
                int id_curso = Convert.ToInt32(cbCurso.SelectedValue);
                Curso curso = new Curso(id_curso);
                string periodo = CbPeriodo.Text;
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

        #region Validações

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaLetra(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.BloqueiaEspaco(e);
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal main_Menu = new MenuPrincipal();
            main_Menu.TopLevel = true;
            main_Menu.Show();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Teste";
            txtEmail.Text = "Teste@teste.com";
            txtCEP.Text = "13254685";
            cbTurno.Text = "Diurno";
            cbCurso.Text = "Arqueologia";
            CbPeriodo.SelectedValue = "1°";
            txtNum.Text = "123";
            txtTelefone.Text = "11971258656";
            cbEstadoCivil.Text = "Solteiro";
            cbGenero.Text = "Masculino";
            dtAluno.Value = new DateTime(1999, 12, 31);
        }
    }
}