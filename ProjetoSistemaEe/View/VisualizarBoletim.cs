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
            ListarNotas();
        }

        public void ListarNotas()
        {
            gridBoletim.DataSource = model.ListarNotas();
            gridBoletim.Columns[0].Visible = false;
            gridBoletim.Columns[1].HeaderText = "RA";
            gridBoletim.Columns[2].HeaderText = "Nome";
            gridBoletim.Columns[3].Visible = false;
            gridBoletim.Columns[4].Visible = false;
            gridBoletim.Columns[5].HeaderText = "Professor";
            gridBoletim.Columns[6].HeaderText = "Materia";
            gridBoletim.Columns[7].HeaderText = "Nota 1";
            gridBoletim.Columns[8].HeaderText = "Nota 2";
            gridBoletim.Columns[9].HeaderText = "Nota 3";
            gridBoletim.Columns[10].HeaderText = "Nota 4";
            gridBoletim.Columns[11].HeaderText = "Nota Final";
            gridBoletim.Columns[12].HeaderText = "Situação";
            gridBoletim.CellFormatting += GridBoletim_CellFormatting;
        }

        private void GridBoletim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 12) // Verifica se é uma célula válida na coluna "Situação"
            {
                string cellValue = e.Value.ToString();

                if (cellValue == "Aprovado")
                {
                    e.CellStyle.ForeColor = Color.Green; // Altera a cor do texto para verde
                }
                else if (cellValue == "Reprovado")
                {
                    e.CellStyle.ForeColor = Color.Red; // Altera a cor do texto para vermelho
                }
            }
        }
    }
}