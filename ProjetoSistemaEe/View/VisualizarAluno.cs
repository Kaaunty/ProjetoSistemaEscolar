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
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal main_Menu = new MenuPrincipal();
            Close();
            main_Menu.TopLevel = true;
            main_Menu.Show();
        }
    }
}