using ProjetoSistemaEe.Model;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class VisualizarProfessor : Form
    {
        private ProfessorModel professorModel = new ProfessorModel();

        public VisualizarProfessor()
        {
            InitializeComponent();
        }

        private void VisualizarProfessor_Load(object sender, EventArgs e)
        {
            ListarProfessor();
        }

        private void ListarProfessor()
        {
            gridProfessor.DataSource = professorModel.Listar();
            gridProfessor.Columns[0].HeaderText = "Nome";
            gridProfessor.Columns[1].HeaderText = "Materia";
            gridProfessor.Columns[2].HeaderText = "Salario";
            gridProfessor.Columns[3].HeaderText = "Estado Civil";
            gridProfessor.Columns[4].HeaderText = "Gênero";
            gridProfessor.Columns[5].HeaderText = "Data de Nascimento";
            gridProfessor.Columns[6].HeaderText = "Email";
            gridProfessor.Columns[7].HeaderText = "Telefone";
            gridProfessor.Columns[8].HeaderText = "CEP";
            gridProfessor.Columns[9].HeaderText = "Endereço";
        }

        private void gridProfessor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarProfessor editarProfessor = new EditarProfessor(this);
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(editarProfessor);
        }
    }
}