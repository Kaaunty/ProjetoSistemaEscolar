using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;

using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class ProfessorView : Form
    {
        private ProfessorModel professorModel = new ProfessorModel();

        public ProfessorView()
        {
            InitializeComponent();
        }

        private void ProfessorView_Load(object sender, EventArgs e)
        {
            GetProfessor();
        }

        private void GetProfessor()
        {
            ProfessorGrid.AutoGenerateColumns = false;
            ProfessorGrid.DataSource = professorModel.GetEntities();
        }

        private void ProfessorGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Professor professor = (Professor)ProfessorGrid.Rows[e.RowIndex].DataBoundItem;
            EditProfessor EditProfessor = new EditProfessor(professor);
            EditProfessor.ShowDialog();
            GetProfessor();
        }

        #region Buttons

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            Close();
            MainMenu.TopLevel = true;
            MainMenu.Show();
        }

        #endregion Buttons
    }
}