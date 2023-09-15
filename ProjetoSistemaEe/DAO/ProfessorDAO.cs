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
        private Conexao con = new Conexao();

        public List<Professor> ListarProfessor()
        {
            List<Professor> professores = new List<Professor>();

            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT p.id, p.nome,d.nome_disciplina as nome_materia, p.salario, p.estadocivil, p.genero, p.datanascimento,
                                        p.email, p.telefone, p.cep,pm.id_materia,p.cidade,p.uf,p.bairro,p.rua,p.numerorua
                                        FROM professor p
                                        LEFT JOIN professor_materia pm on p.id = pm.id_professor
                                        INNER JOIN disciplinas d on pm.id_materia = d.id
                                        group by p.id;;
                                    ", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string nome = dr["nome"].ToString();
                    List<Materia> materia = GetDisciplineByTeacher(id);
                    string salario = dr["salario"].ToString();
                    string estadocivil = dr["estadocivil"].ToString();
                    string genero = dr["genero"].ToString();
                    DateTime datanascimento = Convert.ToDateTime(dr["datanascimento"]);
                    string email = dr["email"].ToString();
                    string telefone = dr["telefone"].ToString();
                    string cep = dr["cep"].ToString();
                    string cidade = dr["cidade"].ToString();
                    string uf = dr["uf"].ToString();
                    string bairro = dr["bairro"].ToString();
                    string rua = dr["rua"].ToString();
                    string numerorua = dr["numerorua"].ToString();

                    Professor professor = new Professor(id, nome, materia, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua);
                    professores.Add(professor);
                }
                return professores;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public void CadastrarProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"INSERT INTO professor(nome, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua)
                   VALUES(@nome, @salario, @estadocivil, @genero, @datanascimento, @email, @telefone, @cep, @cidade, @uf, @bairro, @rua, @numerorua); ", con.con);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@salario", professor.Salario);
                sql.Parameters.AddWithValue("@estadocivil", professor.Estadocivil);
                sql.Parameters.AddWithValue("@genero", professor.Genero);
                sql.Parameters.AddWithValue("@datanascimento", professor.Datanascimento.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", professor.Email);
                sql.Parameters.AddWithValue("@telefone", professor.Telefone);
                sql.Parameters.AddWithValue("@cep", professor.Cep);
                sql.Parameters.AddWithValue("@cidade", professor.Cidade);
                sql.Parameters.AddWithValue("@uf", professor.Uf);
                sql.Parameters.AddWithValue("@bairro", professor.Bairro);
                sql.Parameters.AddWithValue("@rua", professor.Rua);
                sql.Parameters.AddWithValue("@numerorua", professor.Numerorua);
                sql.ExecuteNonQuery();
                sql.Dispose();
                con.FecharConexao();
                foreach (var item in professor.Materia)
                {
                    con.AbrirConexao();
                    int id_professor = IdUltimoProfessor();
                    sql = new MySqlCommand(@"INSERT INTO professor_materia(id_professor, id_materia) VALUES(@id_professor, @id_materia); ", con.con);
                    sql.Parameters.AddWithValue("@id_professor", id_professor);
                    sql.Parameters.AddWithValue("@id_materia", item.Materiaid);
                    sql.ExecuteNonQuery();
                    sql.Dispose();
                    con.FecharConexao();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public void EditarProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE professor SET id = @id, nome = @nome, salario = @salario" +
                                       ", estadocivil = @estadocivil, genero = @genero, datanascimento = @datanascimento" +
                                       ", email = @email, telefone = @telefone, cep = @cep, cidade = @cidade, uf = @uf" +
                                       ", bairro = @bairro, rua = @rua, numerorua = @numerorua where id = @id;" +
                                       "DELETE FROM professor_materia WHERE id_professor = @id", con.con);
                sql.Parameters.AddWithValue("@id", professor.Id);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@salario", professor.Salario);
                sql.Parameters.AddWithValue("@estadocivil", professor.Estadocivil);
                sql.Parameters.AddWithValue("@genero", professor.Genero);
                sql.Parameters.AddWithValue("@datanascimento", professor.Datanascimento.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", professor.Email);
                sql.Parameters.AddWithValue("@telefone", professor.Telefone);
                sql.Parameters.AddWithValue("@cep", professor.Cep);
                sql.Parameters.AddWithValue("@cidade", professor.Cidade);
                sql.Parameters.AddWithValue("@uf", professor.Uf);
                sql.Parameters.AddWithValue("@bairro", professor.Bairro);
                sql.Parameters.AddWithValue("@rua", professor.Rua);
                sql.Parameters.AddWithValue("@numerorua", professor.Numerorua);
                sql.ExecuteNonQuery();
                sql.Dispose();

                foreach (var item in professor.Materia)
                {
                    con.AbrirConexao();
                    sql = new MySqlCommand(@"INSERT INTO professor_materia(id_professor, id_materia) VALUES(@id_professor, @id_materia); ", con.con);
                    sql.Parameters.AddWithValue("@id_professor", professor.Id);
                    sql.Parameters.AddWithValue("@id_materia", item.Materiaid);
                    sql.ExecuteNonQuery();
                    sql.Dispose();
                    con.FecharConexao();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public void ExcluirProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"
                DELETE FROM professor_materia WHERE id_professor = @id;
                DELETE FROM boletim WHERE id_professor = @id;
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
                con.FecharConexao();
            }
        }

        private int IdUltimoProfessor()
        {
            sql = new MySqlCommand("SELECT MAX(id) as id FROM professor", con.con);
            var result = sql.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        private List<Materia> GetDisciplineByTeacher(int id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT p.id, pm.id_materia, d.nome_disciplina from professor p
                                     Inner join professor_materia pm on p.id = pm.id_professor
                                     LEFT join disciplinas d on pm.id_materia = d.id
                                     where p.id = @id_professor;", con.con);
                sql.Parameters.AddWithValue("@id_professor", id);
                MySqlDataReader dr = sql.ExecuteReader();
                List<Materia> materias = new List<Materia>();
                while (dr.Read())
                {
                    int id_materia = Convert.ToInt32(dr["id_materia"]);
                    string nome_materia = dr["nome_disciplina"].ToString();
                    Materia materia = new Materia(id_materia, nome_materia);
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
                con.FecharConexao();
            }
        }
    }
}