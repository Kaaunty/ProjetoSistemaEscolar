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
            LimparCampos();
            Validar.FormatarData(dtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            CarregarComboBox();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Deseja cadastrar o professor?", "Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Professor professores = new Professor();
                        Salvar(professores);
                        MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o profesor:" + ex.Message);
                }
            }
        }

        private void Salvar(Professor professor)
        {
            try
            {
                professor.Nome = txtNome.Text;
                professor.Curso = Convert.ToInt32(cbCurso.SelectedValue);
                professor.Materia = Convert.ToInt32(cbMateria.SelectedValue);
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
            int cursoid = Convert.ToInt32(cbCurso.SelectedValue);
            DataTable materia_curso = cursoM.BuscarMateria(cursoid);
            cbMateria.DataSource = materia_curso;
            cbMateria.DisplayMember = "Nome";
            cbMateria.ValueMember = "id";
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            DataTable materia_curso = cursoM.BuscarMateria(Convert.ToInt32(cbCurso.SelectedValue));
            cbMateria.DataSource = materia_curso;
            cbMateria.DisplayMember = "Nome";
            cbMateria.ValueMember = "id";
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            double salario;
            if (Double.TryParse(txtSalario.Text, out salario))
            {
                txtSalario.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", salario);

                if (salario < 2000)
                {
                    MessageBox.Show("Salário Inválido (Menor que R$ 2.000)");
                    txtSalario.Text = "";
                    txtSalario.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite um valor numérico válido.");
                txtSalario.Text = "";
                txtSalario.Focus();
            }
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