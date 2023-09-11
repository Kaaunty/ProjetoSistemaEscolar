using ProjetoSistemaEe.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Controls;
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
            gridProfessor.AutoGenerateColumns = false;
        }

        private void gridProfessor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarProfessor editarProfessor = new EditarProfessor(this);
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(editarProfessor);
        }
    }
}