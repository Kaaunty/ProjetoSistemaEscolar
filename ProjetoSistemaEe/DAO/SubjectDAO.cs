using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.DAO
{
    internal class SubjectDAO
    {
        private MySqlCommand sql;
        private Connection con = new Connection();

        public List<Subjects> GetSubjects()
        {
            List<Subjects> subjects = new List<Subjects>();

            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"SELECT cs.course_id, cs.subject_id, s.name as subject_name ,c.name as course_name FROM courses_subjects cs
                                         JOIN courses c ON cs.course_id = c.id
                                         JOIN subjects s ON cs.subject_id = s.id
                                         ORDER BY s.name;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    int courseId = Convert.ToInt32(dr["course_id"]);
                    int subjectId = Convert.ToInt32(dr["subject_id"]);
                    string subjectName = dr["subject_name"].ToString();
                    string courseName = dr["course_name"].ToString();
                    Subjects subject = new Subjects(courseId, subjectId, subjectName, courseName);
                    subjects.Add(subject);
                }
                return subjects;
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

        public List<Subjects> GetSubjectsByCourse(int courseId)
        {
            List<Subjects> subjects = new List<Subjects>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"SELECT cs.course_id, cs.subject_id, s.name as subject_name ,c.name as course_name FROM courses_subjects cs
                                         JOIN courses c ON cs.course_id = c.id
                                         JOIN subjects s ON cs.subject_id = s.id
                                         WHERE cs.course_id = @courseId
                                         ORDER BY s.name;", con.con);
                sql.Parameters.AddWithValue("@courseId", courseId);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    int subjectId = Convert.ToInt32(dr["subject_id"]);
                    string subjectName = dr["subject_name"].ToString();
                    string courseName = dr["course_name"].ToString();
                    Subjects subject = new Subjects(courseId, subjectId, subjectName, courseName);
                    subjects.Add(subject);
                }
                return subjects;
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

        public List<Subjects> GetSubjectsNotTakenByStudentFromProfessorAndCourse(int professorId, int courseId, int studentRa)
        {
            try
            {
                List<Subjects> subjects = new List<Subjects>();
                con.OpenConnection();
                sql = new MySqlCommand(@"SELECT ps.professor_id, cs.subject_id, s.name AS subject_name, c.id AS course_id
                                         FROM professor_subjects ps
                                         INNER JOIN subjects s ON s.id = ps.subject_id
                                         INNER JOIN professors p ON p.id = ps.professor_id
                                         INNER JOIN courses_subjects cs ON cs.subject_id = ps.subject_id
                                         INNER JOIN courses c ON c.id = cs.course_id
                                         WHERE p.id = @professor_id
                                         AND c.id = @course_id
                                         AND cs.subject_id NOT IN (
                                             SELECT subject_id
                                             FROM reportcards
                                             WHERE student_id = @student_id
                                             AND  p.id = @professor_id);", con.con);
                sql.Parameters.AddWithValue("@professor_id", professorId);
                sql.Parameters.AddWithValue("@course_id", courseId);
                sql.Parameters.AddWithValue("@student_id", studentRa);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    Subjects subject = new Subjects();
                    subject.SubjectId = Convert.ToInt32(dr["subject_id"]);
                    subject.SubjectName = dr["subject_name"].ToString();

                    subjects.Add(subject);
                }
                return subjects;
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
    }
}