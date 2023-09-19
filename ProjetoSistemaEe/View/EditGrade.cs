using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Windows.Forms;

namespace ProjetoSistemaEe.View
{
    public partial class EditGrade : Form
    {
        private Validations validate = new Validations();
        private ReportCardModel reportCardModel = new ReportCardModel();
        private Calculations calculate = new Calculations();
        private ReportCard reportCard;

        public EditGrade(ReportCard reportCard)
        {
            this.reportCard = reportCard;
            InitializeComponent();
            PopulateFields();
        }

        private void PopulateFields()
        {
            txtRA.Text = reportCard.Student.Ra.ToString();
            txtNome.Text = reportCard.Student.Name;
            txtID.Text = reportCard.Id.ToString();
            txtN1.Text = reportCard.Grade1.ToString();
            txtN2.Text = reportCard.Grade2.ToString();
            txtN3.Text = reportCard.Grade3.ToString();
            txtN4.Text = reportCard.Grade4.ToString();
            txtMedia.Text = reportCard.Average.ToString();
            txtNomeProfessor.Text = reportCard.Professor.Name;
            txtMateria.Text = reportCard.Subject.SubjectName;
            txtCurso.Text = reportCard.Course.CourseName;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja editar a grade do student?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    EditGrade();
                    MessageBox.Show("Boletim editado com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
        }

        private void EditGrade()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                double grade1 = Convert.ToDouble(txtN1.Text);
                double grade2 = Convert.ToDouble(txtN2.Text);
                double grade3 = Convert.ToDouble(txtN3.Text);
                double grade4 = Convert.ToDouble(txtN4.Text);
                double average = Convert.ToDouble(txtMedia.Text);
                string situation = calculate.CheckSituation(average);
                ReportCard boletim = new ReportCard(id, grade1, grade2, grade3, grade4, average, situation);
                reportCardModel.Edit(boletim);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Validações

        private void TxtN_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text))
            {
                double grade = Convert.ToDouble(txt.Text);
                if (grade < 0 || grade > 10)
                {
                    MessageBox.Show("Nota Invalida, digite um valor de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Clear();
                    txt.Focus();
                    return;
                }
            }

            if (txtN1.Text != "" && txtN2.Text != "" && txtN3.Text != "" && txtN4.Text != "")
            {
                calculate.CalculateAverage(txtN1, txtN2, txtN3, txtN4, txtMedia);
                btnEditar.Enabled = true;
            }
            else
            {
                txtMedia.Clear();
                btnEditar.Enabled = false;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumber(e);
        }

        #endregion Validações

        #region Botões

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Botões
    }
}