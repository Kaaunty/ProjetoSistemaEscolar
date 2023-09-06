using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class CadastroProfessor : Form
    {
        private ProfessorModel professorM = new ProfessorModel();
        private Validar validar = new Validar();
        private MateriaModel materiaM = new MateriaModel();

        public CadastroProfessor()
        {
            InitializeComponent();
            gridMaterias.DataSource = materiaM.ListarMateria();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            validar.LimparControles(this);
            Validar.FormatarData(dtProfessor, new DateTime(2000, 12, 31), new DateTime(1953, 01, 01));
            gridMaterias.DataSource = materiaM.ListarMateria();
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
                        validar.LimparControles(this);
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
                for (int i = 0; i < gridMaterias.Rows.Count; i++) //percorre o grid de materias
                {
                    if (Convert.ToBoolean(gridMaterias.Rows[i].Cells[0].Value) == true)//verifica se a linha esta selecionada
                    {
                        professor.ListaDemateria.Add(Convert.ToInt32(gridMaterias.Rows[i].Cells[1].Value)); //adiciona o id da materia na lista
                    }
                }
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

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            validar.ValidarSalario(txtSalario);
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
            validar.VerificaCEP(txtCEP, txtEstado, txtCidade, txtBairro, txtRua, txtNum);
        }
    }
}