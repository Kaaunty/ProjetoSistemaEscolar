using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPainel(object FormSeg)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastroAluno());
        }

        private void btnCadastrarProf_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastroProfessor());
        }

        private void btnCadastrarNotas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CadastrarNotas());
        }
    }
}