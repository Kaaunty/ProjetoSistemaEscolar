using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class ReportCardView : Form
    {
        private ReportCardModel reportCardModel = new ReportCardModel();

        public ReportCardView()
        {
            InitializeComponent();
        }

        private void ReportCardView_Load(object sender, EventArgs e)
        {
            GetReportCard();
        }

        public void GetReportCard()
        {
            ReportCardGrid.AutoGenerateColumns = false;
            ReportCardGrid.DataSource = reportCardModel.GetEntities();
        }

        private void ReportCardGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ReportCard reportCard = (ReportCard)ReportCardGrid.Rows[e.RowIndex].DataBoundItem;
            EditGrade editGrade = new EditGrade(reportCard);
            editGrade.ShowDialog();
            GetReportCard();
        }

        private void ReportCardGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach (DataGridViewRow row in gridBoletim.Rows)
            //{
            //    if (row.Cells[6].Value.ToString() == "Reprovado")
            //    {
            //        row.Cells[6].Style.ForeColor = Color.DarkRed;
            //    }
            //    else if (row.Cells[6].Value.ToString() == "Aprovado")
            //    {
            //        row.Cells[6].Style.ForeColor = Color.DarkGreen;
            //    }
            //    else if (row.Cells[6].Value.ToString() == "Recuperação")
            //    {
            //        row.Cells[6].Style.ForeColor = Color.DarkOrange;
            //    }
            //    else
            //    {
            //        row.Cells[6].Style.ForeColor = Color.Black;
            //    }
            //}

            ReportCard reportCard = (ReportCard)ReportCardGrid.Rows[e.RowIndex].DataBoundItem;

            if (reportCard.Situation == "Reprovado")
            {
                ReportCardGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            else if (reportCard.Situation == "Aprovado")
            {
                ReportCardGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
            }
            else if (reportCard.Situation == "Recuperação")
            {
                ReportCardGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkOrange;
            }
            else
            {
                ReportCardGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }

            ReportCardGrid.Rows[e.RowIndex].Cells[0].Value = reportCard.Student.Ra;
        }

        #region Buttons

        private void BtnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnPreviousMenu_Click(object sender, System.EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            Close();
            MainMenu.TopLevel = true;
            MainMenu.Show();
        }

        #endregion Buttons
    }
}