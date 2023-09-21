using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.Model;
using ProjetoSistemaEe.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;

namespace ProjetoSistemaEe.View
{
    public partial class ReportCardView : Form
    {
        private ReportCardModel reportCardModel = new ReportCardModel();
        private CourseModel courseModel = new CourseModel();
        private SubjectsModel subjectsModel = new SubjectsModel();
        private Validations validate = new Validations();

        public ReportCardView()
        {
            InitializeComponent();
        }

        private void ReportCardView_Load(object sender, EventArgs e)
        {
            GetReportCard();
            PopulateFields();
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
            if (ReportCardGrid.Rows.Count > 0)
            {
                ReportCard reportCard = (ReportCard)ReportCardGrid.Rows[e.RowIndex].DataBoundItem;

                if (reportCard.Situation == "Reprovado")
                {
                    ReportCardGrid.Rows[e.RowIndex].Cells[9].Style.ForeColor = Color.DarkRed;
                }
                else if (reportCard.Situation == "Aprovado")
                {
                    ReportCardGrid.Rows[e.RowIndex].Cells[9].Style.ForeColor = Color.DarkGreen;
                }
                else if (reportCard.Situation == "Recuperação")
                {
                    ReportCardGrid.Rows[e.RowIndex].Cells[9].Style.ForeColor = Color.DarkOrange;
                }
                else
                {
                    ReportCardGrid.Rows[e.RowIndex].Cells[9].Style.ForeColor = Color.Black;
                }

                ReportCardGrid.Rows[e.RowIndex].Cells[0].Value = reportCard.Student.Ra;
            }
            else
            {
                ReportCardGrid.Rows[e.RowIndex].Cells[0].Value = "";
            }
        }

        private void PopulateFields()
        {
            CbCourse.ValueMember = "courseId";
            CbCourse.DisplayMember = "courseName";
            List<Course> courses = courseModel.GetCoursesByStudents();
            courses.Insert(0, new Course { CourseId = 0, CourseName = "Todos" });
            CbCourse.DataSource = courses;

            CbSubject.ValueMember = "subjectId";
            CbSubject.DisplayMember = "subjectName";
            List<Subjects> subjects = subjectsModel.GetSubjectsByCourse(Convert.ToInt32(CbCourse.SelectedValue));
            subjects.Insert(0, new Subjects { SubjectId = 0, SubjectName = "Todas" });

            CbSubject.DataSource = subjects;
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

        #region Search Validations

        private void CbCourse_SelectedValueChanged(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(CbCourse.SelectedValue);
            int subjectId = Convert.ToInt32(CbSubject.SelectedValue);
            List<ReportCard> reportCards = reportCardModel.GetEntities();
            if (courseId == 0 && subjectId == 0)
            {
                reportCards = reportCardModel.GetEntities();
                ReportCardGrid.DataSource = reportCards;
            }
            else if (courseId != 0 && subjectId == 0)
            {
                reportCards = reportCardModel.GetEntities();
                reportCards = reportCards.FindAll(x => x.Course.CourseId == Convert.ToInt32(CbCourse.SelectedValue));
                ReportCardGrid.DataSource = reportCards;
            }
            else
            {
                reportCards = reportCards.FindAll(x => x.Course.CourseId == Convert.ToInt32(CbCourse.SelectedValue));
                ReportCardGrid.DataSource = reportCards;
            }

            CbSubject.ValueMember = "subjectId";
            CbSubject.DisplayMember = "subjectName";
            List<Subjects> subjects = subjectsModel.GetSubjectsByCourse(Convert.ToInt32(CbCourse.SelectedValue));
            subjects.Insert(0, new Subjects { SubjectId = 0, SubjectName = "Todas" });
            CbSubject.DataSource = subjects;
        }

        private void CbSubject_SelectedValueChanged(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(CbCourse.SelectedValue);
            int subjectId = Convert.ToInt32(CbSubject.SelectedValue);
            List<ReportCard> reportCards = reportCardModel.GetEntities();
            if (courseId == 0 && subjectId == 0)
            {
                reportCards = reportCardModel.GetEntities();
                ReportCardGrid.DataSource = reportCards;
            }
            else if (subjectId == 0)
            {
                reportCards = reportCardModel.GetEntities();
                reportCards = reportCards.FindAll(x => x.Course.CourseId == Convert.ToInt32(CbCourse.SelectedValue));
                ReportCardGrid.DataSource = reportCards;
            }
            else
            {
                reportCards = reportCards.FindAll(x => x.Subject.SubjectId == Convert.ToInt32(CbSubject.SelectedValue));
                ReportCardGrid.DataSource = reportCards;
            }
        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(CbCourse.SelectedValue);
            int subjectId = Convert.ToInt32(CbSubject.SelectedValue);
            if (TxtSearchName.Text == "" && courseId == 0 && subjectId == 0)
            {
                GetReportCard();
            }
            if (TxtSearchName.Text == "" && courseId != 0 && subjectId != 0)
            {
                List<ReportCard> reportCards = reportCardModel.GetEntities();
                reportCards = reportCards.FindAll(x => x.Course.CourseId == courseId);
                reportCards = reportCards.FindAll(x => x.Subject.SubjectId == subjectId);
                ReportCardGrid.DataSource = reportCards;
            }
            else if (courseId == 0 && subjectId == 0)
            {
                List<ReportCard> reportCards = reportCardModel.GetEntities();
                reportCards = reportCards.FindAll(x => x.Student.Name.ToUpper().Contains(TxtSearchName.Text.ToUpper()));
                ReportCardGrid.DataSource = reportCards;
            }
            else if (courseId != 0 && subjectId == 0)
            {
                List<ReportCard> reportCards = reportCardModel.GetEntities();
                reportCards = reportCards.FindAll(x => x.Student.Name.ToUpper().Contains(TxtSearchName.Text.ToUpper()));
                reportCards = reportCards.FindAll(x => x.Course.CourseId == courseId);
                ReportCardGrid.DataSource = reportCards;
            }
            else
            {
                List<ReportCard> reportCards = reportCardModel.GetEntities();
                reportCards = reportCards.FindAll(x => x.Student.Name.ToUpper().Contains(TxtSearchName.Text.ToUpper()));
                reportCards = reportCards.FindAll(x => x.Course.CourseId == courseId);
                reportCards = reportCards.FindAll(x => x.Subject.SubjectId == subjectId);
                ReportCardGrid.DataSource = reportCards;
            }
        }

        #endregion Search Validations

        private void TxtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.PermitLetter(e);
        }
    }
}