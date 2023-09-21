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
            TxtName.Text = reportCard.Student.Name;
            txtID.Text = reportCard.Id.ToString();
            TxtN1.Text = reportCard.Grade1.ToString();
            TxtN2.Text = reportCard.Grade2.ToString();
            TxtN3.Text = reportCard.Grade3.ToString();
            TxtN4.Text = reportCard.Grade4.ToString();
            TxtAverage.Text = reportCard.Average.ToString();
            TxtSubject.Text = reportCard.Subject.SubjectName;
            TxtCourse.Text = reportCard.Course.CourseName;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja editar a media do estudante?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    EditGrades();
                    MessageBox.Show("Media editado com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        private void EditGrades()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                double grade1 = Convert.ToDouble(TxtN1.Text);
                double grade2 = Convert.ToDouble(TxtN2.Text);
                double grade3 = Convert.ToDouble(TxtN3.Text);
                double grade4 = Convert.ToDouble(TxtN4.Text);
                double average = Convert.ToDouble(TxtAverage.Text);
                string situation = calculate.CheckSituation(average);
                ReportCard reportCard = new ReportCard(id, grade1, grade2, grade3, grade4, average, situation);
                reportCardModel.Edit(reportCard);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja deletar a media do estudante?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteGrade();
                    MessageBox.Show("Media deletada com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message);
            }
        }

        private void DeleteGrade()
        {
            if (validate.ValidateControls(this))
            {
                try
                {
                    reportCard.Id = Convert.ToInt32(txtID.Text);
                    reportCardModel.Delete(reportCard);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        #region Validations

        private void TxtN_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text) && txt.Text != ",")
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

            if (TxtN1.Text != "" && TxtN2.Text != "" && TxtN3.Text != "" && TxtN4.Text != "")
            {
                calculate.CalculateAverage(TxtN1, TxtN2, TxtN3, TxtN4, TxtAverage);
                BtnEdit.Enabled = true;
            }
            else
            {
                TxtAverage.Clear();
                BtnEdit.Enabled = false;
            }
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitNumberAndComma(sender, e);
        }

        #endregion Validations

        #region Buttons

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Buttons
    }
}