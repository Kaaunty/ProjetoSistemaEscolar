using ProjetoSistemaEe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class VisualizarProfessor : Form
    {
        private ProfessorModel professorModel = new ProfessorModel();

        public VisualizarProfessor()
        {
            InitializeComponent();
        }

        private void VisualizarProfessor_Load(object sender, EventArgs e)
        {
            ListarProfessor();
        }

        private void ListarProfessor()
        {
            gridAluno.DataSource = professorModel.ListarProfessor();
            gridAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridAluno.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridAluno.BorderStyle = BorderStyle.None;
            gridAluno.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridAluno.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gridAluno.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridAluno.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridAluno.BackgroundColor = Color.White;
            gridAluno.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridAluno.EnableHeadersVisualStyles = false;
            gridAluno.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            gridAluno.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            gridAluno.Font = new Font("Segoe UI", 9);
            gridAluno.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
            gridAluno.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            gridAluno.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridAluno.EnableHeadersVisualStyles = false;
            gridAluno.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridAluno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridAluno.Columns[0].HeaderText = "Código";
            gridAluno.Columns[1].HeaderText = "Nome";
            gridAluno.Columns[2].HeaderText = "Curso";
            gridAluno.Columns[3].HeaderText = "Salario";
            gridAluno.Columns[4].HeaderText = "Materia";
            gridAluno.Columns[5].HeaderText = "Estado Civil";
            gridAluno.Columns[6].HeaderText = "Gênero";
            gridAluno.Columns[7].HeaderText = "Data de Nascimento";
            gridAluno.Columns[8].HeaderText = "Email";
            gridAluno.Columns[9].HeaderText = "Telefone";
            gridAluno.Columns[10].HeaderText = "CEP";
            gridAluno.Columns[11].HeaderText = "Endereço";
        }
    }
}