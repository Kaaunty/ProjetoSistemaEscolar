using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;

namespace ProjetoSistemaEe.DAO
{
    internal class ReportCardDAO
    {
        private MySqlCommand sql;
        private Connection con = new Connection();

        public List<ReportCard> GetReportCards()
        {
            List<ReportCard> reportCards = new List<ReportCard>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(
                @"SELECT rc.student_id,
                  s.name AS student_name,
                  c.name AS course_name,
                  sb.name AS subject_name,
                  rc.grade1,
                  rc.grade2,
                  rc.grade3,
                  rc.grade4,
                  rc.average,
                  rc.situation,
                  rc.course_id,
                  rc.id AS reportcard_id,
                  rc.subject_id AS subject_id
                  FROM reportcards rc
                  JOIN students s on s.ra = rc.student_id
                  JOIN courses c on c.id = rc.course_id
                  JOIN subjects sb on sb.id = rc.subject_id;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["reportcard_id"]);
                    int ra = Convert.ToInt32(dr["student_id"]);
                    string studentName = dr["student_name"].ToString();
                    int courseId = Convert.ToInt32(dr["course_id"]);
                    string courseName = dr["course_name"].ToString();
                    int subjectId = Convert.ToInt32(dr["subject_id"]);
                    string subjectName = dr["subject_name"].ToString();
                    double grade1 = Convert.ToDouble(dr["grade1"]);
                    double grade2 = Convert.ToDouble(dr["grade2"]);
                    double grade3 = Convert.ToDouble(dr["grade3"]);
                    double grade4 = Convert.ToDouble(dr["grade4"]);
                    double average = Convert.ToDouble(dr["average"]);
                    string situation = dr["situation"].ToString();
                    ReportCard reportCard = new ReportCard(id, ra, studentName, courseId, courseName, subjectId, subjectName, grade1, grade2, grade3, grade4, average, situation);
                    reportCards.Add(reportCard);
                }
                return reportCards;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseConnection();
            }
        }

        public void RegisterReportCard(ReportCard reportCard)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"INSERT INTO reportcards ()
                                         VALUES(DEFAULT, @student_id, @course_id, @subject_id, @grade1, @grade2, @grade3, @grade4, @average, @situation);", con.con);
                sql.Parameters.AddWithValue("@student_id", reportCard.Student.Ra);
                sql.Parameters.AddWithValue("@course_id", reportCard.Course.CourseId);
                sql.Parameters.AddWithValue("@subject_id", reportCard.Subject.SubjectId);
                sql.Parameters.AddWithValue("@grade1", reportCard.Grade1);
                sql.Parameters.AddWithValue("@grade2", reportCard.Grade2);
                sql.Parameters.AddWithValue("@grade3", reportCard.Grade3);
                sql.Parameters.AddWithValue("@grade4", reportCard.Grade4);
                sql.Parameters.AddWithValue("@average", reportCard.Average);
                sql.Parameters.AddWithValue("@situation", reportCard.Situation);
                sql.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseConnection();
            }
        }

        public void EditReportCard(ReportCard reportCard)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE reportcards SET grade1 = @grade1, grade2 = @grade2, grade3 = @grade3, grade4 = @grade4, average = @average, situation = @situation WHERE id = @id;", con.con);
                sql.Parameters.AddWithValue("@id", reportCard.Id);
                sql.Parameters.AddWithValue("@grade1", reportCard.Grade1);
                sql.Parameters.AddWithValue("@grade2", reportCard.Grade2);
                sql.Parameters.AddWithValue("@grade3", reportCard.Grade3);
                sql.Parameters.AddWithValue("@grade4", reportCard.Grade4);
                sql.Parameters.AddWithValue("@average", reportCard.Average);
                sql.Parameters.AddWithValue("@situation", reportCard.Situation);
                sql.ExecuteNonQuery();
                sql.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseConnection();
            }
        }

        public void DeleteReportCard(ReportCard reportCard)
        {
            throw new NotImplementedException();
        }
    }
}