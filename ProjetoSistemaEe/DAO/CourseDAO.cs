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
                                         LEFT JOIN reportcards rc ON s.ra = rc.student_id
                                         AND s.course = rc.course_id
                                         WHERE rc.id IS NULL
                                         AND s.course = @course_id;", con.con);
                sql.Parameters.AddWithValue("@course_id", courseId);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Student student = new Student();
                    student.RA = Convert.ToInt32(dr["ra"]);
                    student.Name = dr["name"].ToString();
                    Students.Add(student);
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
                sql = new MySqlCommand(@"select ps.professor_id, cs.subject_id,s.name as subject_name,c.id as course_id from professor_subjects ps
                                         Inner join subjects s ON s.id = ps.subject_id
                                         Inner join professors p ON p.id = ps.professor_id
                                         Inner join courses_subjects cs ON cs.subject_id = ps.subject_id
                                         Inner join courses c ON c.id = cs.course_id
                                         Where p.id = @professor_id
                                         And c.id = @course_id;", con.con);
                sql.Parameters.AddWithValue("@professor_id", professorId);
                sql.Parameters.AddWithValue("@course_id", courseId);
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