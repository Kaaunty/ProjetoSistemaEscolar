using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class StudentView : Form
    {
        private StudentModel studentModel = new StudentModel();

        public StudentView()
        {
            InitializeComponent();
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void GetStudents()
        {
            StudentGrid.AutoGenerateColumns = false;
            StudentGrid.DataSource = studentModel.GetEntities();
        }

        private void StudentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student = (Student)StudentGrid.Rows[e.RowIndex].DataBoundItem;
            EditStudent editStudent = new EditStudent(student);
            editStudent.ShowDialog();
            GetStudents();
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