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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnStudentRegister_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();
            Hide();
            cadastroAluno.TopLevel = true;
            cadastroAluno.Show();
        }

        private void BtnTeacherRegister_Click(object sender, EventArgs e)
        {
            CadastroProfessor cadastroProfessor = new CadastroProfessor();
            Hide();
            cadastroProfessor.TopLevel = true;
            cadastroProfessor.Show();
        }

        private void BtntranscriptAdd_Click(object sender, EventArgs e)
        {
            CadastrarNotas cadastrarNotas = new CadastrarNotas();
            Hide();
            cadastrarNotas.TopLevel = true;
            cadastrarNotas.Show();
        }

        private void BtnStudentView_Click(object sender, EventArgs e)
        {
            VisualizarAluno visualizarAluno = new VisualizarAluno();
            Hide();
            visualizarAluno.TopLevel = true;
            visualizarAluno.Show();
        }

        private void BtnTeacherView_Click(object sender, EventArgs e)
        {
            VisualizarProfessor visualizarProfessor = new VisualizarProfessor();
            Hide();
            visualizarProfessor.TopLevel = true;
            visualizarProfessor.Show();
        }

        private void BtntranscriptView_Click(object sender, EventArgs e)
        {
            VisualizarBoletim visualizarBoletim = new VisualizarBoletim();
            Hide();
            visualizarBoletim.TopLevel = true;
            visualizarBoletim.Show();
        }
    }
}