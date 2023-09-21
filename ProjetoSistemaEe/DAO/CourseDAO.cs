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
            List<Course> courses = new List<Course>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM courses order by name;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    Course course = new Course();
                    course.CourseId = Convert.ToInt32(dr["id"]);
                    course.CourseName = dr["name"].ToString();
                    courses.Add(course);
                }
                return courses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Course> GetCoursesByStudents()
        {
            List<Course> courses = new List<Course>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM courses c inner join students s on c.id = s.course group by c.id;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Course course = new Course();
                    course.CourseId = Convert.ToInt32(dr["id"]);
                    course.CourseName = dr["name"].ToString();
                    courses.Add(course);
                }
                return courses;
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
            List<Student> students = new List<Student>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"SELECT s.ra, s.name
                                         FROM students s
                                         LEFT JOIN reportcards rc ON s.ra = rc.student_id
                                         AND s.course = rc.course_id
                                         WHERE s.course = @course_id
                                         GROUP BY s.ra;", con.con);
                sql.Parameters.AddWithValue("@course_id", courseId);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Student student = new Student();
                    student.RA = Convert.ToInt32(dr["ra"]);
                    student.Name = dr["name"].ToString();
                    students.Add(student);
                }
                return students;
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

        public List<Subjects> GetSubjectsByProfessorAndCourseAndSubject(int professorId, int courseId, int studentRa)

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