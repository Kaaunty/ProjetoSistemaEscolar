using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditarProfessor : Form
    {
        private CursoModel cursoModel = new CursoModel();
        private ProfessorModel professormodel = new ProfessorModel();
        private Validar validar = new Validar();
        private VisualizarProfessor instanciaDoForm2; //crio um objeto do tipo FORM 1, que será usado dentro da classe
        private char[] delimitarchars = { '-', ',' };

        public EditarProfessor(VisualizarProfessor InstanciaVisualizar)
        {
            InitializeComponent();
            CarregarComboBox();
            instanciaDoForm2 = InstanciaVisualizar; //passo o valor do form1 para o objeto criado
            txtID.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[1].Value.ToString();
            cbCurso.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[2].Value.ToString();
            txtSalario.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[3].Value.ToString();
            cbMateria.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[4].Value.ToString();
            cbEstadoCivil.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[5].Value.ToString();
            cbGenero.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[6].Value.ToString();
            dtProfessor.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[8].Value.ToString();
            txtTelefone.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[9].Value.ToString();
            txtCEP.Text = instanciaDoForm2.gridProfessor.CurrentRow.Cells[10].Value.ToString();
            string endereco = instanciaDoForm2.gridProfessor.CurrentRow.Cells[11].Value.ToString();
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
            int cursoid = Convert.ToInt32(cbCurso.SelectedValue);
            DataTable materia_curso = cursoModel.BuscarMateria(cursoid);
            cbMateria.DataSource = materia_curso;
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            DataTable materia_curso = cursoModel.BuscarMateria(Convert.ToInt32(cbCurso.SelectedValue));
            cbMateria.DataSource = materia_curso;
            cbMateria.DisplayMember = "Nome";
            cbMateria.ValueMember = "id";
            Validar.FormatarData(dtProfessor, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
            cbCurso.DisplayMember = "Nome";
            cbCurso.ValueMember = "id";
            DataTable materia_curso = cursoModel.BuscarMateria(Convert.ToInt32(cbCurso.SelectedValue));
            cbMateria.DataSource = materia_curso;
            cbMateria.DisplayMember = "Nome";
            cbMateria.ValueMember = "id";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Professor professores = new Professor();
            Editar(professores);
        }

        private void Editar(Professor professor)
        {
            if (validar.ValidateControls(this))
            {
                try
                {
                    professor.Id = Convert.ToInt32(txtID.Text);
                    professor.Nome = txtNome.Text;
                    professor.Curso = cbCurso.Text;
                    professor.Materia = cbMateria.Text;
                    professor.EstadoCivil = cbEstadoCivil.Text;
                    professor.Genero = cbGenero.Text;
                    professor.Salario = txtSalario.Text;
                    professor.Datanascimento = Convert.ToDateTime(dtProfessor.Text);
                    professor.Email = txtEmail.Text;
                    professor.Telefone = txtTelefone.Text;
                    professor.Cep = txtCEP.Text;
                    professor.Cidade = txtCidade.Text;
                    professor.Uf = txtEstado.Text;
                    professor.Bairro = txtBairro.Text;
                    professor.Rua = txtRua.Text;
                    professor.Numerorua = txtNum.Text;
                    professormodel.Editar(professor);
                    MessageBox.Show("Professor editado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar professor: " + ex.Message);
                }
                finally
                {
                    FormAbrir();
                }
            }
        }

        private void FormAbrir()
        {
            VisualizarProfessor formB = new VisualizarProfessor();
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(formB);
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

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            double salario;
            if (Double.TryParse(txtSalario.Text, out salario))
            {
                txtSalario.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", salario);

                if (salario <= 2000)
                {
                    MessageBox.Show("Salário Inválido (Menor que R$ 2.000)");
                    txtSalario.Text = "";
                    txtSalario.Focus();
                    return;
                }
                if (salario >= 10001)
                {
                    MessageBox.Show("Salário Inválido (Maior que R$ 10.000)");
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
    }
}