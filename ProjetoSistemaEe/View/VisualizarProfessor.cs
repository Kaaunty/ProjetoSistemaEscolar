﻿using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;
using System.Linq;
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
            gridProfessor.AutoGenerateColumns = false;
            gridProfessor.DataSource = professorModel.Listar();
        }

        private void gridProfessor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Professor professor = (Professor)gridProfessor.Rows[e.RowIndex].DataBoundItem;
            EditarProfessor editarProfessor = new EditarProfessor(professor);
            editarProfessor.ShowDialog();
            ListarProfessor();
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