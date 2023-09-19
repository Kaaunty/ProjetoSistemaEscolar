using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.DAO
{
    internal class CourseDAO
    {
        private MySqlCommand sql;
        private Connection con = new Connection();

        public List<Course> GetCourses()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM courses order by name;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                List<Course> Courses = new List<Course>();
                while (dr.Read())
                {
                    Course courses = new Course();
                    courses.CourseId = Convert.ToInt32(dr["id"]);
                    courses.CourseName = dr["name"].ToString();
                    Courses.Add(courses);
                }
                return Courses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Course> GetCoursesByStudents()
        {
            List<Course> Courses = new List<Course>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM courses c inner join students s on c.id = s.course group by c.id;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Course courses = new Course();
                    courses.CourseId = Convert.ToInt32(dr["id"]);
                    courses.CourseName = dr["name"].ToString();
                    Courses.Add(courses);
                }
                return Courses;
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

        public List<Student> GetStudentsByCourse(int courseId)

        {
            List<Student> Students = new List<Student>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"SELECT s.ra, s.name
                                         FROM students s
                                         LEFT JOIN reportcards rc ON s.ra = rc.studentId
                                         AND s.course = rc.courseId
                                         WHERE rc.id IS NULL
                                         AND s.course = @courseId;", con.con);
                sql.Parameters.AddWithValue("@id_curso", courseId);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Student aluno = new Student();
                    aluno.RA = Convert.ToInt32(dr["ra"]);
                    aluno.Name = dr["name"].ToString();
                    Students.Add(aluno);
                }
                return Students;
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

        public List<Subjects> GetSubjectsByProfessorAndCourse(int professorId, int courseId)
        {
            try
            {
                List<Subjects> subjects = new List<Subjects>();
                con.OpenConnection();
                sql = new MySqlCommand(@"Select s.name, s.id from subjects s
                                           Inner Join courses_subjects cs ON s.id = cs.subjects_d
                                           Inner JOIN courses c ON cs.coursesId = c.id
                                           Inner Join professor_subjects ps ON s.id = ps.professor_id
                                           inner join professors p on ps.professor_id = p.id
                                           Where p.id = @professor_id
                                           And c.id = @course_id;", con.con);
                sql.Parameters.AddWithValue("@professor_id", professorId);
                sql.Parameters.AddWithValue("@course_id", courseId);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    Subjects subject = new Subjects();
                    subject.SubjectId = Convert.ToInt32(dr["id"]);
                    subject.SubjectName = dr["name"].ToString();

                    subjects.Add(subject);
                }
                return subjects;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }
    }
}