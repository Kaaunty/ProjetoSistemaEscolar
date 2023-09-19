using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSistemaEe.DAO
{
    internal class ProfessorDAO
    {
        private MySqlCommand sql;
        private Connection con = new Connection();

        public List<Professor> GetProfessors()
        {
            List<Professor> professors = new List<Professor>();

            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@" select p.*,s.name, ps.subjectId  from professors p
                                           left join professor_subjects ps on p.id = ps.professorId
                                           inner join subjects s on ps.subjectId = s.id
                                           GROUP BY p.id;
                                    ", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string name = dr["name"].ToString();
                    List<Subjects> subjects = GetDisciplineByTeacher(id);
                    string salary = dr["salary"].ToString();
                    string martialStatus = dr["martialStatus"].ToString();
                    string gender = dr["gender"].ToString();
                    DateTime birchDate = Convert.ToDateTime(dr["birchDate"]);
                    string email = dr["email"].ToString();
                    string phone = dr["phone"].ToString();
                    string zipCode = dr["zipCode"].ToString();
                    string city = dr["city"].ToString();
                    string state = dr["state"].ToString();
                    string district = dr["district"].ToString();
                    string street = dr["street"].ToString();
                    string streetnumber = dr["streetnumber"].ToString();

                    Professor professor = new Professor();
                    professors.Add(professor);
                }
                return professors;
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

        public void RegisterProfessor(Professor professor)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"INSERT INTO professors()
                                         VALUES(DEFAULT,@name, @salary, @martialstatus, @gender, @birchdate, @email, @phone, @zipCode, @city, @state, @district, @street, @streetnumber); ", con.con);
                sql.Parameters.AddWithValue("@name", professor.Name);
                sql.Parameters.AddWithValue("@salary", professor.Salary);
                sql.Parameters.AddWithValue("@martialStatus", professor.MartialStatus);
                sql.Parameters.AddWithValue("@gender", professor.Gender);
                sql.Parameters.AddWithValue("@birchDate", professor.BirthDate.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", professor.Email);
                sql.Parameters.AddWithValue("@phone", professor.Phone);
                sql.Parameters.AddWithValue("@zipCode", professor.ZipCode);
                sql.Parameters.AddWithValue("@city", professor.City);
                sql.Parameters.AddWithValue("@state", professor.State);
                sql.Parameters.AddWithValue("@district", professor.District);
                sql.Parameters.AddWithValue("@street", professor.Street);
                sql.Parameters.AddWithValue("@streetnumber", professor.StreetNumber);
                sql.ExecuteNonQuery();
                sql.Dispose();
                con.CloseConnection();
                foreach (var item in professor.Subjects)
                {
                    con.OpenConnection();
                    int professorId = ProfessorLastId();
                    sql = new MySqlCommand(@"INSERT INTO professor_subjects() VALUES(@professorId, @subjectId);", con.con);
                    sql.Parameters.AddWithValue("@professorId", professorId);
                    sql.Parameters.AddWithValue("@subjectId", item.SubjectId);
                    sql.ExecuteNonQuery();
                    sql.Dispose();
                    con.CloseConnection();
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

        public void EditProfessor(Professor professor)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"UPDATE professors SET id = @id, name = @name, salary = @salary
                                       , martial_status = @martial_status, gender = @gender, birch_date = @birch_date
                                       , email = @email, phone = @phone, zip_code = @zip_code, city = @city, state = @state
                                       , district = @district, street = @street, street_number = @street_number where id = @id;
                                       DELETE FROM professor_subjects WHERE professor_id = @id;", con.con);
                sql.Parameters.AddWithValue("@id", professor.Id);
                sql.Parameters.AddWithValue("@name", professor.Name);
                sql.Parameters.AddWithValue("@salary", professor.Salary);
                sql.Parameters.AddWithValue("@martial_status", professor.MartialStatus);
                sql.Parameters.AddWithValue("@gender", professor.Gender);
                sql.Parameters.AddWithValue("@birch_date", professor.BirthDate.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", professor.Email);
                sql.Parameters.AddWithValue("@phone", professor.Phone);
                sql.Parameters.AddWithValue("@zip_code", professor.ZipCode);
                sql.Parameters.AddWithValue("@city", professor.City);
                sql.Parameters.AddWithValue("@state", professor.State);
                sql.Parameters.AddWithValue("@district", professor.District);
                sql.Parameters.AddWithValue("@street", professor.Street);
                sql.Parameters.AddWithValue("@street_number", professor.StreetNumber);
                sql.ExecuteNonQuery();
                sql.Dispose();

                foreach (var item in professor.Subjects)
                {
                    con.OpenConnection();
                    sql = new MySqlCommand("INSERT INTO professor_subjects() VALUES(@professor_id, @subject_id); ", con.con);
                    sql.Parameters.AddWithValue("@professorId", professor.Id);
                    sql.Parameters.AddWithValue("@Subjectid", item.SubjectId);
                    sql.ExecuteNonQuery();
                    sql.Dispose();
                    con.CloseConnection();
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

        public void DeleteProfessor(Professor professor)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"
                DELETE FROM professor_subjects WHERE professor_id = @id;
                DELETE FROM reportcards WHERE professor_id = @id;
                DELETE FROM professor WHERE id = @id;
               ", con.con);
                sql.Parameters.AddWithValue("@id", professor.Id);
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

        private int ProfessorLastId()
        {
            sql = new MySqlCommand("SELECT MAX(id) as id FROM professors", con.con);
            var result = sql.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        private List<Subjects> GetDisciplineByTeacher(int professorId)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(@"SELECT p.id, ps.subject_id as subjectid, s.name
                                         FROM professors p
                                         INNER JOIN professor_subjects ps ON p.id = ps.professor_id
                                         LEFT JOIN subjects s ON ps.subject_id = s.id
                                         WHERE p.id = @professor_id;", con.con);
                sql.Parameters.AddWithValue("@professor_id", professorId);
                MySqlDataReader dr = sql.ExecuteReader();
                List<Subjects> materias = new List<Subjects>();
                while (dr.Read())
                {
                    int subjectId = Convert.ToInt32(dr["subjectid"]);
                    string subjectName = dr["name"].ToString();
                    Subjects materia = new Subjects(subjectId, subjectName);
                    materias.Add(materia);
                }
                return materias;
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