using ProjetoSistemaEe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class VisualizarAluno : Form
    {
        private AlunoModel alunoModel = new AlunoModel();

        public VisualizarAluno()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        public void VisualizarAluno_Load(object sender, EventArgs e)
        {
            ListarAluno();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();
            cadastroAluno.ShowDialog();
        }

        private void ListarAluno()
        {
            gridAluno.DataSource = alunoModel.ListarAluno();
            gridAluno.Columns[0].HeaderText = "Código RA";
            gridAluno.Columns[1].HeaderText = "Nome";
            gridAluno.Columns[2].HeaderText = "Curso";
            gridAluno.Columns[3].HeaderText = "Periodo";
            gridAluno.Columns[4].HeaderText = "Materia";
            gridAluno.Columns[5].HeaderText = "Estado Civil";
            gridAluno.Columns[6].HeaderText = "Gênero";
            gridAluno.Columns[7].HeaderText = "Data de Nascimento";
            gridAluno.Columns[8].HeaderText = "Email";
            gridAluno.Columns[9].HeaderText = "Turno";
            gridAluno.Columns[10].HeaderText = "Telefone";
            gridAluno.Columns[11].HeaderText = "CEP";
            gridAluno.Columns[12].HeaderText = "Endereço";
        }

        private void gridAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = Convert.ToInt32(gridAluno.Rows[e.RowIndex].Cells[0].Value.ToString());
            //EditarAluno cadastroAluno = new EditarAluno(id);
            //cadastroAluno.ShowDialog();
        }
    }
}