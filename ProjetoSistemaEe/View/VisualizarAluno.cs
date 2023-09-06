using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class VisualizarAluno : Form
    {
        private AlunoModel alunoModel = new AlunoModel();
        private List<Aluno> alunos = new List<Aluno>();

        public VisualizarAluno()
        {
            InitializeComponent();
        }

        public void VisualizarAluno_Load(object sender, EventArgs e)
        {
            ListarAluno();
            alunos = alunoModel.ListarPorList();
        }

        private void ListarAluno()
        {
            gridBoletim.DataSource = alunoModel.ListarPorList();
        }

        private void gridAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarAluno editarAluno = new EditarAluno(this);
            var principal = this.ParentForm as MenuPrincipal;
            principal.AbrirFormNoPainel(editarAluno);
        }
    }
}