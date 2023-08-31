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
        private VisualizarAluno instanciaDoForm1; //crio um objeto do tipo FORM 1, que será usado dentro da classe
        private char[] delimitarchars = { '-', ',' };

        public EditarAluno(VisualizarAluno InstanciaVisualizar)
        {
            InitializeComponent();
            CarregarComboBox();
            Validar.FormatarData(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            instanciaDoForm1 = InstanciaVisualizar; //passo o valor do form1 para o objeto criado
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
            string endereco = instanciaDoForm1.gridBoletim.CurrentRow.Cells[12].Value.ToString();
            string[] enderecoSeparado = endereco.Split(delimitarchars);
            txtCidade.Text = enderecoSeparado[0];
            txtEstado.Text = enderecoSeparado[1];
            txtBairro.Text = enderecoSeparado[2];
            txtRua.Text = enderecoSeparado[3];
            txtNum.Text = enderecoSeparado[4];
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
                        Aluno alunos = new Aluno();
                        Editar(alunos);
                        MessageBox.Show("Aluno editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar aluno!" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Editar(Aluno aluno)
        {
            try
            {
                aluno.RA = Convert.ToInt32(txtRA.Text);
                aluno.Nome = txtNome.Text;
                aluno.Curso = Convert.ToInt32(cbCurso.SelectedValue);
                aluno.Periodo = cbPeriodo.Text;
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
                    Aluno alunos = new Aluno();
                    ExcluirAluno(alunos);
                    MessageBox.Show("Aluno excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaLetra(e);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.VerificaNumero(e);
        }

        private void FormAbrir()
        {
            VisualizarAluno formB = new VisualizarAluno();
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(formB);
        }
    }
}