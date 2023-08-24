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
            gridProfessor.DataSource = professorModel.Listar();
            gridProfessor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridProfessor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridProfessor.BorderStyle = BorderStyle.None;
            gridProfessor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridProfessor.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gridProfessor.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridProfessor.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridProfessor.BackgroundColor = Color.White;
            gridProfessor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridProfessor.EnableHeadersVisualStyles = false;
            gridProfessor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            gridProfessor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            gridProfessor.Font = new Font("Segoe UI", 9);
            gridProfessor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
            gridProfessor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            gridProfessor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridProfessor.EnableHeadersVisualStyles = false;
            gridProfessor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridProfessor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridProfessor.Columns[0].HeaderText = "Código";
            gridProfessor.Columns[1].HeaderText = "Nome";
            gridProfessor.Columns[2].HeaderText = "Curso";
            gridProfessor.Columns[3].HeaderText = "Salario";
            gridProfessor.Columns[4].HeaderText = "Materia";
            gridProfessor.Columns[5].HeaderText = "Estado Civil";
            gridProfessor.Columns[6].HeaderText = "Gênero";
            gridProfessor.Columns[7].HeaderText = "Data de Nascimento";
            gridProfessor.Columns[8].HeaderText = "Email";
            gridProfessor.Columns[9].HeaderText = "Telefone";
            gridProfessor.Columns[10].HeaderText = "CEP";
            gridProfessor.Columns[11].HeaderText = "Endereço";
        }
    }
}