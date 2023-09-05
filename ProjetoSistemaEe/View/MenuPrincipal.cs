﻿using ProjetoSistemaEe.Utils;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirFormNoPainel(object FormSeg)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = FormSeg as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastroAluno());
            //
            btnVisualizarAluno.Enabled = true;
            btnVisualizarAluno.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarProf.Enabled = true;
            btnCadastrarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizarProf.Enabled = true;
            btnVisualizarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarNotas.Enabled = true;
            btnCadastrarNotas.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizaBoletim.Enabled = true;
            btnVisualizaBoletim.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarAluno.Enabled = false;
            btnCadastrarAluno.BackColor = Color.FromArgb(54, 7, 94);
        }

        private void btnVisualizarAluno_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new VisualizarAluno());
            btnVisualizarAluno.Enabled = false;
            btnVisualizarAluno.BackColor = Color.FromArgb(54, 7, 94);
            //
            btnCadastrarProf.Enabled = true;
            btnCadastrarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizarProf.Enabled = true;
            btnVisualizarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarNotas.Enabled = true;
            btnCadastrarNotas.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizaBoletim.Enabled = true;
            btnVisualizaBoletim.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarAluno.Enabled = true;
            btnCadastrarAluno.BackColor = Color.FromArgb(43, 7, 94);
        }

        private void btnCadastrarProf_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastroProfessor());
            btnVisualizarAluno.Enabled = true;
            btnVisualizarAluno.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarProf.Enabled = false;
            btnCadastrarProf.BackColor = Color.FromArgb(54, 7, 94);
            //
            btnVisualizarProf.Enabled = true;
            btnVisualizarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarNotas.Enabled = true;
            btnCadastrarNotas.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizaBoletim.Enabled = true;
            btnVisualizaBoletim.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarAluno.Enabled = true;
            btnCadastrarAluno.BackColor = Color.FromArgb(43, 7, 94);
        }

        private void btnVisualizarProf_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new VisualizarProfessor());
            btnVisualizarAluno.Enabled = true;
            btnVisualizarAluno.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarProf.Enabled = true;
            btnCadastrarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizarProf.Enabled = false;
            btnVisualizarProf.BackColor = Color.FromArgb(54, 7, 94);
            //
            btnCadastrarNotas.Enabled = true;
            btnCadastrarNotas.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizaBoletim.Enabled = true;
            btnVisualizaBoletim.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarAluno.Enabled = true;
            btnCadastrarAluno.BackColor = Color.FromArgb(43, 7, 94);
        }

        private void btnCadastrarNotas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastrarNotas());
            btnVisualizarAluno.Enabled = true;
            btnVisualizarAluno.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarProf.Enabled = true;
            btnCadastrarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizarProf.Enabled = true;
            btnVisualizarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarNotas.Enabled = false;
            btnCadastrarNotas.BackColor = Color.FromArgb(54, 7, 94);
            //
            btnVisualizaBoletim.Enabled = true;
            btnVisualizaBoletim.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarAluno.Enabled = true;
            btnCadastrarAluno.BackColor = Color.FromArgb(43, 7, 94);
        }

        private void btnVisualizaBoletim_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new VisualizarBoletim());
            btnVisualizarAluno.Enabled = true;
            btnVisualizarAluno.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarProf.Enabled = true;
            btnCadastrarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizarProf.Enabled = true;
            btnVisualizarProf.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnCadastrarNotas.Enabled = true;
            btnCadastrarNotas.BackColor = Color.FromArgb(43, 7, 94);
            //
            btnVisualizaBoletim.Enabled = false;
            btnVisualizaBoletim.BackColor = Color.FromArgb(54, 7, 94);
            //
            btnCadastrarAluno.Enabled = true;
            btnCadastrarAluno.BackColor = Color.FromArgb(43, 7, 94);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}