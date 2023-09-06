using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Documents;

namespace ProjetoSistemaEe.DAO
{
    internal class AlunoDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public DataTable ListarAluno()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT a.ra, a.nome, a.curso, a.periodo, a.estadocivil, a.genero, a.datanascimento,
                                    a.email,a.turno,a.telefone,a.cep,c.nome as cursonome,CONCAT
                                    (cidade,'-', uf, ',', bairro, ',', rua, ',', numerorua) AS endereco_completo FROM aluno a
                                    LEFT JOIN cursos c ON a.curso = c.id", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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

        public void InserirAluno(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO aluno(ra, nome, curso, periodo, estadocivil, genero, datanascimento, email, turno, telefone, cep, cidade, uf, bairro, rua, numerorua) VALUES (@ra, @nome, @curso, @periodo, @estadocivil, @genero, @datanascimento, @email, @turno, @telefone, @cep, @cidade, @uf, @bairro, @rua, @numerorua)", con.con);
                sql.Parameters.AddWithValue("@ra", aluno.RA);
                sql.Parameters.AddWithValue("@nome", aluno.Nome);
                sql.Parameters.AddWithValue("@curso", aluno.Curso);
                sql.Parameters.AddWithValue("@periodo", aluno.Periodo);
                sql.Parameters.AddWithValue("@estadocivil", aluno.EstadoCivil);
                sql.Parameters.AddWithValue("@genero", aluno.Genero);
                sql.Parameters.AddWithValue("@datanascimento", aluno.Datanascimento);
                sql.Parameters.AddWithValue("@email", aluno.Email);
                sql.Parameters.AddWithValue("@turno", aluno.Turno);
                sql.Parameters.AddWithValue("@telefone", aluno.Telefone);
                sql.Parameters.AddWithValue("@cep", aluno.Cep);
                sql.Parameters.AddWithValue("@cidade", aluno.Cidade);
                sql.Parameters.AddWithValue("@uf", aluno.Uf);
                sql.Parameters.AddWithValue("@bairro", aluno.Bairro);
                sql.Parameters.AddWithValue("@rua", aluno.Rua);
                sql.Parameters.AddWithValue("@numerorua", aluno.Numerorua);
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
                con.FecharConexao();
            }
        }

        internal bool VerificarRA(int ra)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM aluno WHERE ra = @ra", con.con);
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
                con.FecharConexao();
            }
        }

        public void EditarAluno(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE aluno SET ra = @ra, nome = @nome, curso = @curso, periodo = @periodo" +
                    ", estadocivil = @estadocivil, genero = @genero, datanascimento = @datanascimento" +
                    ", email = @email, turno = @turno, telefone = @telefone, cep = @cep, cidade = @cidade, uf = @uf" +
                    ", bairro = @bairro, rua = @rua, numerorua = @numerorua where ra = @ra ;", con.con);
                sql.Parameters.AddWithValue("@ra", aluno.RA);
                sql.Parameters.AddWithValue("@nome", aluno.Nome);
                sql.Parameters.AddWithValue("@curso", aluno.Curso);
                sql.Parameters.AddWithValue("@periodo", aluno.Periodo);
                sql.Parameters.AddWithValue("@estadocivil", aluno.EstadoCivil);
                sql.Parameters.AddWithValue("@genero", aluno.Genero);
                sql.Parameters.AddWithValue("@datanascimento", aluno.Datanascimento.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", aluno.Email);
                sql.Parameters.AddWithValue("@turno", aluno.Turno);
                sql.Parameters.AddWithValue("@telefone", aluno.Telefone);
                sql.Parameters.AddWithValue("@cep", aluno.Cep);
                sql.Parameters.AddWithValue("@cidade", aluno.Cidade);
                sql.Parameters.AddWithValue("@uf", aluno.Uf);
                sql.Parameters.AddWithValue("@bairro", aluno.Bairro);
                sql.Parameters.AddWithValue("@rua", aluno.Rua);
                sql.Parameters.AddWithValue("@numerorua", aluno.Numerorua);
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

        internal void ExcluirAluno(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"
                DELETE FROM boletim WHERE id_aluno = @ra;
                DELETE FROM aluno WHERE ra = @ra", con.con);
                sql.Parameters.AddWithValue("@ra", aluno.RA);
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

        public List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT a.ra, a.nome, a.curso, a.periodo, a.estadocivil, a.genero, a.datanascimento,
                                    a.email,a.turno,a.telefone,a.cep,c.nome as cursonome,CONCAT
                                    (cidade,'-', uf, ',', bairro, ',', rua, ',', numerorua) AS endereco_completo FROM aluno a
                                    LEFT JOIN cursos c ON a.curso = c.id", con.con);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    alunos.Add(new Aluno()
                    {
                        RA = Convert.ToInt32(dr["ra"]),
                        Nome = dr["nome"].ToString(),
                        Curso = Convert.ToInt32(dr["curso"]),
                        Periodo = dr["periodo"].ToString(),
                        EstadoCivil = dr["estadocivil"].ToString(),
                        Genero = dr["genero"].ToString(),
                        Datanascimento = Convert.ToDateTime(dr["datanascimento"]),
                        Email = dr["email"].ToString(),
                        Turno = dr["turno"].ToString(),
                        Telefone = dr["telefone"].ToString(),
                        Cep = dr["cep"].ToString(),
                        Estadocivil = dr["estadocivil"].ToString(),
                    });
                }
                dr.Close();
                return alunos;
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