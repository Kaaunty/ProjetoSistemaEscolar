using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System.Collections.Generic;
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
            gridBoletim.DataSource = model.ListarBoletim();
            gridBoletim.Columns[13].Visible = false;
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

        private void gridBoletim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 10)
            {
                string cellValue = e.Value.ToString();

                if (cellValue == "Aprovado")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (cellValue == "Reprovado")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (cellValue == "Recuperação")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                }
            }
        }
    }
}