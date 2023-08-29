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
            gridBoletim.DataSource = alunoModel.Listar();
            gridBoletim.Columns[0].HeaderText = "Código RA";
            gridBoletim.Columns[1].HeaderText = "Nome";
            gridBoletim.Columns[2].HeaderText = "Curso";
            gridBoletim.Columns[3].HeaderText = "Periodo";
            gridBoletim.Columns[4].HeaderText = "Estado Civil";
            gridBoletim.Columns[5].HeaderText = "Gênero";
            gridBoletim.Columns[6].HeaderText = "Data de Nascimento";
            gridBoletim.Columns[7].HeaderText = "Email";
            gridBoletim.Columns[8].HeaderText = "Turno";
            gridBoletim.Columns[9].HeaderText = "Telefone";
            gridBoletim.Columns[10].HeaderText = "CEP";
            gridBoletim.Columns[11].HeaderText = "Endereço";
        }

        private void gridAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarAluno formB = new EditarAluno(this);
            var principal = this.ParentForm as MenuPrincipal; // Pega o formulário pai
            principal.AbrirFormNoPainel(formB); // Chama o método para abrir o formulário B
        }
    }
}