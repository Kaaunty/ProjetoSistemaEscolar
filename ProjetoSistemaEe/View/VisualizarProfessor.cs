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
            gridProfessor.Columns[11].DisplayIndex = 2;
            gridProfessor.Columns[12].DisplayIndex = 3;
            gridProfessor.Columns[0].HeaderText = "Código";
            gridProfessor.Columns[0].Visible = false;
            gridProfessor.Columns[1].HeaderText = "Nome";
            gridProfessor.Columns[2].HeaderText = "Curso";
            gridProfessor.Columns[2].Visible = false;
            gridProfessor.Columns[3].HeaderText = "Salario";
            gridProfessor.Columns[4].HeaderText = "Materia";
            gridProfessor.Columns[4].Visible = false;
            gridProfessor.Columns[5].HeaderText = "Estado Civil";
            gridProfessor.Columns[6].HeaderText = "Gênero";
            gridProfessor.Columns[7].HeaderText = "Data de Nascimento";
            gridProfessor.Columns[8].HeaderText = "Email";
            gridProfessor.Columns[9].HeaderText = "Telefone";
            gridProfessor.Columns[10].HeaderText = "CEP";
            gridProfessor.Columns[11].HeaderText = "Curso";
            gridProfessor.Columns[12].HeaderText = "Materia";
            gridProfessor.Columns[13].HeaderText = "Endereço";
        }

        private void gridProfessor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarProfessor formB = new EditarProfessor(this);
            formB.ShowDialog();
            this.Hide();
        }
    }
}