using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Validar.FormatarData(dtAluno, new DateTime(2004, 12, 31), new DateTime(1953, 01, 01));
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            cbCurso.SelectedValue = 0;
            CbPeriodo.SelectedValue = 0;
            cbMateria.SelectedValue = 0;
            cbEstadoCivil.SelectedValue = 0;
            cbGenero.SelectedValue = 0;
            txtEmail.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
            cbTurno.SelectedValue = 0;
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNum.Clear();
            txtTelefone.Clear();
            txtRA.Clear();
        }
    }
}