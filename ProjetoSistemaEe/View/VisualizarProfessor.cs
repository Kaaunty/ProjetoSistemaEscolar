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
            gridProfessor.Columns[0].HeaderText = "Código";
            gridProfessor.Columns[0].Visible = false;
            gridProfessor.Columns[1].HeaderText = "Nome";
            gridProfessor.Columns[2].HeaderText = "Curso";
            gridProfessor.Columns[3].HeaderText = "Salario";
            gridProfessor.Columns[4].HeaderText = "Materia";
            gridProfessor.Columns[5].HeaderText = "Estado Civil";
            gridProfessor.Columns[6].HeaderText = "Gênero";
            gridProfessor.Columns[7].HeaderText = "Data de Nascimento";
            gridProfessor.Columns[8].HeaderText = "Email";
            gridProfessor.Columns[9].HeaderText = "Telefone";
            gridProfessor.Columns[10].HeaderText = "CEP";
            gridProfessor.Columns[11].HeaderText = "Endereço";
        }

        private void gridProfessor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarProfessor formB = new EditarProfessor(this);
            var principal = this.ParentForm as MenuPrincipal; // Pega o formulário pai
            principal.AbrirFormNoPainel(formB); // Chama o método para abrir o formulário B
        }
    }
}