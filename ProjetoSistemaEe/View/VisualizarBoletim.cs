using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class VisualizarBoletim : Form
    {
        private BoletimModel model = new BoletimModel();

        public VisualizarBoletim()
        {
            InitializeComponent();
        }

        private void VisualizarBoletim_Load(object sender, System.EventArgs e)
        {
            ListarNotas();
        }

        public void ListarNotas()
        {
            gridBoletim.AutoGenerateColumns = false;
            gridBoletim.DataSource = model.Listar();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, System.EventArgs e)
        {
            MenuPrincipal main_Menu = new MenuPrincipal();
            Close();
            main_Menu.TopLevel = true;
            main_Menu.Show();
        }

        private void gridBoletim_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Boletim boletim = (Boletim)gridBoletim.Rows[e.RowIndex].DataBoundItem;
            EditarNotas EditarNotas = new EditarNotas(boletim);
            EditarNotas.ShowDialog();
            ListarNotas();
        }
    }
}