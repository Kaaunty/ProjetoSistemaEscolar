using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditarAluno : Form
    {
        private CursoModel cursoModel = new CursoModel();
        private AlunoModel alunoModel = new AlunoModel();
        private VisualizarAluno instanciaDoForm1; //crio um objeto do tipo FORM 1, que será usado dentro da classe
        private char[] delimitarchars = { '-', ',' };

        public EditarAluno(VisualizarAluno InstanciaVisualizar)
        {
            InitializeComponent();
            CarregarComboBox();
            instanciaDoForm1 = InstanciaVisualizar; //passo o valor do form1 para o objeto criado
            txtRA.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[1].Value.ToString();
            cbCurso.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[2].Value.ToString();
            cbPeriodo.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[3].Value.ToString();
            cbMateria.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[4].Value.ToString();
            cbEstadoCivil.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[5].Value.ToString();
            cbGenero.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[6].Value.ToString();
            dtAluno.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[8].Value.ToString();
            cbTurno.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[9].Value.ToString();
            txtTelefone.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[10].Value.ToString();
            txtCEP.Text = instanciaDoForm1.gridAluno.CurrentRow.Cells[11].Value.ToString();
            string endereco = instanciaDoForm1.gridAluno.CurrentRow.Cells[12].Value.ToString();
            string[] enderecoSeparado = endereco.Split(delimitarchars);
            txtCidade.Text = enderecoSeparado[0];
            txtEstado.Text = enderecoSeparado[1];
            txtBairro.Text = enderecoSeparado[2];
            txtRua.Text = enderecoSeparado[3];
            txtNum.Text = enderecoSeparado[4];
        }

        public EditarAluno()
        {
        }

        private void EditarAluno_Load(object sender, EventArgs e)
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            DataTable materia_curso = cursoModel.BuscarMateria(Convert.ToInt32(cbCurso.SelectedValue));
            cbMateria.DataSource = materia_curso;
        }

        private void CarregarComboBox()
        {
            //
            cbCurso.DataSource = cursoModel.ListarCursos();
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            cbCurso.DropDownHeight = cbCurso.ItemHeight * 5;
            cbCurso.SelectedIndex = -1;
            //
            int cursoid = Convert.ToInt32(cbCurso.SelectedValue);
            DataTable materia_curso = cursoModel.BuscarMateria(cursoid);
            cbMateria.DataSource = materia_curso;
            cbMateria.DisplayMember = "Nome";
            cbMateria.ValueMember = "id";
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            DataTable materia_curso = cursoModel.BuscarMateria(Convert.ToInt32(cbCurso.SelectedValue));
            cbMateria.DataSource = materia_curso;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Aluno alunos = new Aluno();
            Editar(alunos);
        }

        private void Editar(Aluno aluno)
        {
            if (VerificarEspacos())
            {
                try
                {
                    aluno.RA = Convert.ToInt32(txtRA.Text);
                    aluno.Nome = txtNome.Text;
                    aluno.Curso = cbCurso.Text;
                    aluno.Periodo = cbPeriodo.Text;
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
                    alunoModel.Editar(aluno);
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    this.Close();
                }
            }
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
            if (cbPeriodo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo Periodo");
                cbPeriodo.Focus();
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
    }
}