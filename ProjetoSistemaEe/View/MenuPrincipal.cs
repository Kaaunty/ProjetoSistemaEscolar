using ProjetoSistemaEe.Utils;
using System;
using System.Drawing;
using System.Linq;
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

        private void HabilitarBotao()
        {
            BtnCadastrarAluno.Enabled = true;
            BtnCadastrarAluno.BackColor = Color.FromArgb(43, 7, 94);
            BtnVisualizarAluno.Enabled = true;
            BtnVisualizarAluno.BackColor = Color.FromArgb(43, 7, 94);
            BtnCadastrarProf.Enabled = true;
            BtnCadastrarProf.BackColor = Color.FromArgb(43, 7, 94);
            BtnVisualizarProf.Enabled = true;
            BtnVisualizarProf.BackColor = Color.FromArgb(43, 7, 94);
            BtnVisualizarProf.Enabled = true;
            BtnVisualizarProf.BackColor = Color.FromArgb(43, 7, 94);
            BtnCadastrarNotas.Enabled = true;
            BtnCadastrarNotas.BackColor = Color.FromArgb(43, 7, 94);
            BtnVisualizaBoletim.Enabled = true;
            BtnVisualizaBoletim.BackColor = Color.FromArgb(43, 7, 94);
        }

        private void BtnCadastrarAluno_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastroAluno());
            HabilitarBotao();
            BtnCadastrarAluno.Enabled = false;
            BtnCadastrarAluno.BackColor = Color.FromArgb(54, 7, 94);
        }

        private void BtnVisualizarAluno_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new VisualizarAluno());
            HabilitarBotao();
            BtnVisualizarAluno.Enabled = false;
            BtnVisualizarAluno.BackColor = Color.FromArgb(54, 7, 94);
        }

        private void BtnCadastrarProf_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastroProfessor());
            HabilitarBotao();
            BtnCadastrarProf.Enabled = false;
            BtnCadastrarProf.BackColor = Color.FromArgb(54, 7, 94);
        }

        private void BtnVisualizarProf_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new VisualizarProfessor());
            HabilitarBotao();
            BtnVisualizarProf.Enabled = false;
            BtnVisualizarProf.BackColor = Color.FromArgb(54, 7, 94);
        }

        private void BtnCadastrarNotas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastrarNotas());
            HabilitarBotao();
            BtnCadastrarNotas.Enabled = false;
            BtnCadastrarNotas.BackColor = Color.FromArgb(54, 7, 94);
        }

        private void BtnVisualizaBoletim_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new VisualizarBoletim());
            HabilitarBotao();
            BtnVisualizaBoletim.Enabled = false;
            BtnVisualizaBoletim.BackColor = Color.FromArgb(54, 7, 94);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}