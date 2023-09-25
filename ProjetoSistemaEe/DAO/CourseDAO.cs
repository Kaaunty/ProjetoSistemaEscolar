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
            con.CloseConnection();
            return courses;
        }

        public List<Course> GetCoursesContainStudent()
        {
            List<Course> courses = new List<Course>();

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
            con.CloseConnection();
            return courses;
        }

        public List<Student> GetStudentsByCourse(int courseId)

        {
            List<Student> students = new List<Student>();

            con.OpenConnection();
            sql = new MySqlCommand(@"SELECT DISTINCT s.ra, s.name
                                         FROM students s
                                         LEFT JOIN reportcards rc ON s.ra = rc.student_id
                                         AND s.course = rc.course_id
                                         WHERE s.course = @course_id;", con.con);
            sql.Parameters.AddWithValue("@course_id", courseId);
            MySqlDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                Student student = new Student();
                student.Ra = Convert.ToInt32(dr["ra"]);
                student.Name = dr["name"].ToString();
                students.Add(student);
            }
            con.CloseConnection();
            return students;
        }
    }
}