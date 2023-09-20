using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class MainMenu : Form
    {
        public MainMenu()
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
            RegisterStudent cadastroAluno = new RegisterStudent();
            Hide();
            cadastroAluno.TopLevel = true;
            cadastroAluno.Show();
        }

        private void BtnTeacherRegister_Click(object sender, EventArgs e)
        {
            RegisterProfessor cadastroProfessor = new RegisterProfessor();
            Hide();
            cadastroProfessor.TopLevel = true;
            cadastroProfessor.Show();
        }

        private void BtntranscriptAdd_Click(object sender, EventArgs e)
        {
            RegisterGrades cadastrarNotas = new RegisterGrades();
            Hide();
            cadastrarNotas.TopLevel = true;
            cadastrarNotas.Show();
        }

        private void BtnStudentView_Click(object sender, EventArgs e)
        {
            StudentView visualizarAluno = new StudentView();
            Hide();
            visualizarAluno.TopLevel = true;
            visualizarAluno.Show();
        }

        private void BtnTeacherView_Click(object sender, EventArgs e)
        {
            ProfessorView visualizarProfessor = new ProfessorView();
            Hide();
            visualizarProfessor.TopLevel = true;
            visualizarProfessor.Show();
        }

        private void BtntranscriptView_Click(object sender, EventArgs e)
        {
            ReportCardView visualizarBoletim = new ReportCardView();
            Hide();
            visualizarBoletim.TopLevel = true;
            visualizarBoletim.Show();
        }
    }
}