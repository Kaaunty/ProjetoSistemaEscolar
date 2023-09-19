using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;

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
    }
}