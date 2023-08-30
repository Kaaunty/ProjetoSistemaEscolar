﻿using ProjetoSistemaEe.Model;
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
        }

        private void GridBoletim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 13) // Verifica se é uma célula válida na coluna "Situação"
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

        private void gridBoletim_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarNotas formB = new EditarNotas(this);
            formB.ShowDialog();
            this.Hide();
        }
    }
}