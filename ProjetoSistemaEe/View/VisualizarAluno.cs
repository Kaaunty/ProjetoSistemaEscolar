using ProjetoSistemaEe.Model;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class VisualizarAluno : Form
    {
        private AlunoModel alunoModel = new AlunoModel();

        public VisualizarAluno()
        {
            InitializeComponent();
        }

        public void VisualizarAluno_Load(object sender, EventArgs e)
        {
            ListarAluno();
        }

        private void ListarAluno()
        {
            gridAluno.DataSource = alunoModel.Listar();
            gridAluno.Columns[0].HeaderText = "Código RA";
            gridAluno.Columns[1].HeaderText = "Nome";
            gridAluno.Columns[2].HeaderText = "Curso";
            gridAluno.Columns[3].HeaderText = "Periodo";
            gridAluno.Columns[4].HeaderText = "Estado Civil";
            gridAluno.Columns[5].HeaderText = "Gênero";
            gridAluno.Columns[6].HeaderText = "Data de Nascimento";
            gridAluno.Columns[7].HeaderText = "Email";
            gridAluno.Columns[8].HeaderText = "Turno";
            gridAluno.Columns[9].HeaderText = "Telefone";
            gridAluno.Columns[10].HeaderText = "CEP";
            gridAluno.Columns[11].HeaderText = "Endereço";
        }

        private void gridAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarAluno formB = new EditarAluno(this);
            var principal = this.ParentForm as MenuPrincipal; // Pega o formulário pai
            principal.AbrirFormNoPainel(formB); // Chama o método para abrir o formulário B
        }
    }
}