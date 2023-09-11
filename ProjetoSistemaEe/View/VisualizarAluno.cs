using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
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
            gridBoletim.AutoGenerateColumns = false;
            gridBoletim.DataSource = alunoModel.Listar();
        }

        private void gridAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarAluno editarAluno = new EditarAluno(this);
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(editarAluno);
        }
    }
}