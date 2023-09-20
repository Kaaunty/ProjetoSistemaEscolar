using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.DAO
{
    internal class StudentDAO
    {
        private MySqlCommand sql;
        private Connection con = new Connection();

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"SELECT s.*, c.name as course_name FROM students s
                                         JOIN courses c on s.course = c.id;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    int ra = Convert.ToInt32(dr["ra"]);
                    string name = dr["name"].ToString();
                    Course course = GetCourses(Convert.ToInt32(dr["course"]));
                    string period = dr["period"].ToString();
                    string maritalStatus = dr["marital_status"].ToString();
                    string gender = dr["gender"].ToString();
                    DateTime birthDate = Convert.ToDateTime(dr["birth_date"]);
                    string email = dr["email"].ToString();
                    string shift = dr["shift"].ToString();
                    string phone = dr["phone"].ToString();
                    string zipCode = dr["zip_code"].ToString();
                    string city = dr["city"].ToString();
                    string state = dr["state"].ToString();
                    string district = dr["district"].ToString();
                    string street = dr["street"].ToString();
                    string streetNumber = dr["street_number"].ToString();

                    Student student = new Student(ra, name, course, period, maritalStatus, gender, birthDate, email, shift, phone, zipCode, city, state, district, street, streetNumber);

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

        public void RegisterStudent(Student student)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO students() VALUES (@ra, @name, @course, @period, @marital_status, " +
                    "@gender, @birch_date, @email, @shift, @phone, @zip_code, @city, @state, @district, @street, @street_number)", con.con);
                sql.Parameters.AddWithValue("@ra", student.RA);
                sql.Parameters.AddWithValue("@name", student.Name);
                sql.Parameters.AddWithValue("@course", student.Course.CourseId);
                sql.Parameters.AddWithValue("@period", student.Period);
                sql.Parameters.AddWithValue("@marital_status", student.MaritalStatus);
                sql.Parameters.AddWithValue("@gender", student.Gender);
                sql.Parameters.AddWithValue("@birch_date", student.BirthDate);
                sql.Parameters.AddWithValue("@email", student.Email);
                sql.Parameters.AddWithValue("@shift", student.Shift);
                sql.Parameters.AddWithValue("@phone", student.Phone);
                sql.Parameters.AddWithValue("@zip_code", student.ZipCode);
                sql.Parameters.AddWithValue("@city", student.City);
                sql.Parameters.AddWithValue("@state", student.State);
                sql.Parameters.AddWithValue("@district", student.District);
                sql.Parameters.AddWithValue("@street", student.Street);
                sql.Parameters.AddWithValue("@street_number", student.StreetNumber);
                sql.ExecuteNonQuery();
                sql.Dispose();
            }
            catch (MySqlException)
            {
                throw;
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

        public bool CheckRA(int ra)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM students WHERE ra = @ra", con.con);
                sql.Parameters.AddWithValue("@ra", ra);
                var result = sql.ExecuteScalar();
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public void EditStudent(Student student)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"UPDATE students SET ra = @ra, name = @name, course = @course, period = @period,
                                         marital_status = @marital_status, gender = @gender, birth_date = @birth_date,
                                         email = @email, shift = @shift, phone = @phone, zip_code = @zip_code, city = @city, state = @state,
                                         district = @district, street = @street, street_number = @street_number where ra = @ra;", con.con);
                sql.Parameters.AddWithValue("@ra", student.RA);
                sql.Parameters.AddWithValue("@name", student.Name);
                sql.Parameters.AddWithValue("@course", student.Course.CourseId);
                sql.Parameters.AddWithValue("@period", student.Period);
                sql.Parameters.AddWithValue("@marital_status", student.MaritalStatus);
                sql.Parameters.AddWithValue("@gender", student.Gender);
                sql.Parameters.AddWithValue("@birth_date", student.BirthDate.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", student.Email);
                sql.Parameters.AddWithValue("@shift", student.Shift);
                sql.Parameters.AddWithValue("@phone", student.Phone);
                sql.Parameters.AddWithValue("@zip_code", student.ZipCode);
                sql.Parameters.AddWithValue("@city", student.City);
                sql.Parameters.AddWithValue("@state", student.State);
                sql.Parameters.AddWithValue("@district", student.District);
                sql.Parameters.AddWithValue("@street", student.Street);
                sql.Parameters.AddWithValue("@street_number", student.StreetNumber);
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

        public void DeleteStudent(Student student)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"
                DELETE FROM reportcards WHERE student_id = @ra;
                DELETE FROM students WHERE ra = @ra", con.con);
                sql.Parameters.AddWithValue("@ra", student.RA);
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

        public Course GetCourses(int courseId)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM courses WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@id", courseId);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr["name"].ToString();
                    int id = Convert.ToInt32(dr["id"]);
                    Course course = new Course(id, name);
                    return course;
                }
                return null;
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