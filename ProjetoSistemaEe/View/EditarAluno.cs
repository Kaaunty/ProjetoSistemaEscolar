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
        private VisualizarAluno instanciaDoForm1;

        public EditarAluno(VisualizarAluno InstanciaVisualizar)
        {
            InitializeComponent();
            CarregarComboBox();
            Validar.FormatarData(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            instanciaDoForm1 = InstanciaVisualizar;
            txtRA.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[1].Value.ToString();
            cbCurso.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[2].Value.ToString();
            cbPeriodo.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[3].Value.ToString();
            cbEstadoCivil.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[4].Value.ToString();
            cbGenero.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[5].Value.ToString();
            dtAluno.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[7].Value.ToString();
            cbTurno.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[8].Value.ToString();
            txtTelefone.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[9].Value.ToString();
            txtCEP.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[11].Value.ToString();
            txtEstado.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[12].Value.ToString();
            txtBairro.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[13].Value.ToString();
            txtRua.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[14].Value.ToString();
            txtNum.Text = instanciaDoForm1.gridBoletim.CurrentRow.Cells[15].Value.ToString();
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
                string curso = cbCurso.SelectedValue.ToString();
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
                    MessageBox.Show("Aluno excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno!" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirAluno(Aluno aluno)
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
            Close();
            MenuPrincipal main_Menu = new MenuPrincipal();
            main_Menu.TopLevel = true;
            main_Menu.Show();
        }

        #endregion Botões
    }
}