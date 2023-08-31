using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace ProjetoSistemaEe.DAO
{
    internal class ProfessorDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public DataTable ListarProfessor()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT p.id, p.nome, p.curso, p.salario, p.materia, p.estadocivil, p.genero, p.datanascimento,
                                    p.email, p.telefone, p.cep,c.nome as nome_curso,m.nome as nome_materia,CONCAT
                                    (cidade, '-', uf, ', ', bairro, ', ', rua, ', ', numerorua) AS endereco_completo FROM xd_university.professor p
                                    LEFT JOIN cursos c on p.curso = c.id
                                    LEFT JOIN materia m on p.materia = m.id", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
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

        public void CadastrarProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO professor(nome, curso, salario, materia, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua) " +
                    "VALUES (@nome, @curso, @salario, @materia, @estadocivil, @genero, @datanascimento, @email, @telefone, @cep, @cidade, @uf, @bairro, @rua, @numerorua)", con.con);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@curso", professor.Curso);
                sql.Parameters.AddWithValue("@salario", professor.Salario);
                sql.Parameters.AddWithValue("@materia", professor.Materia);
                sql.Parameters.AddWithValue("@estadocivil", professor.EstadoCivil);
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

        internal void EditarProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE professor SET id = @id, nome = @nome, curso = @curso, salario = @salario" +
                    ",materia = @materia, estadocivil = @estadocivil, genero = @genero, datanascimento = @datanascimento" +
                    ", email = @email, telefone = @telefone, cep = @cep, cidade = @cidade, uf = @uf" +
                    ", bairro = @bairro, rua = @rua, numerorua = @numerorua where id = @id ;", con.con);
                sql.Parameters.AddWithValue("@id", professor.Id);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@curso", professor.Curso);
                sql.Parameters.AddWithValue("@salario", professor.Salario);
                sql.Parameters.AddWithValue("@estadocivil", professor.EstadoCivil);
                sql.Parameters.AddWithValue("@genero", professor.Genero);
                sql.Parameters.AddWithValue("@datanascimento", professor.Datanascimento.ToString("yyyy-MM-dd"));
                sql.Parameters.AddWithValue("@email", professor.Email);
                sql.Parameters.AddWithValue("@materia", professor.Materia);
                sql.Parameters.AddWithValue("@telefone", professor.Telefone);
                sql.Parameters.AddWithValue("@cep", professor.Cep);
                sql.Parameters.AddWithValue("@cidade", professor.Cidade);
                sql.Parameters.AddWithValue("@uf", professor.Uf);
                sql.Parameters.AddWithValue("@bairro", professor.Bairro);
                sql.Parameters.AddWithValue("@rua", professor.Rua);
                sql.Parameters.AddWithValue("@numerorua", professor.Numerorua);
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

        public void ExcluirProfessor(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"
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
    }
}