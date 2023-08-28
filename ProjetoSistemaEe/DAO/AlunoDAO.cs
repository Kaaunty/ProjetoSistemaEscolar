using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;

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
                sql = new MySqlCommand(@"SELECT ra, nome, curso, periodo, estadocivil, genero, datanascimento,
                                    email, turno, telefone, cep,CONCAT
                                    (cidade,'-', uf, ',', bairro, ',', rua, ',', numerorua) AS endereco_completo FROM aluno", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new System.Exception(ex.Message);
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
            catch (MySqlException ex)
            {
                throw new System.Exception(ex.Message);
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
            catch (MySqlException ex)
            {
                throw new System.Exception(ex.Message);
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
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
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
                sql = new MySqlCommand("DELETE FROM aluno WHERE ra = @ra", con.con);
                sql.Parameters.AddWithValue("@ra", aluno.RA);
                sql.ExecuteNonQuery();
                sql.Dispose();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }
    }
}