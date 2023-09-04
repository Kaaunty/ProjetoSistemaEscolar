using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using ProjetoSistemaEe.View;
using System;
using System.Collections.Generic;
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
                sql = new MySqlCommand(@"SELECT p.id, p.nome,m.nome as nome_materia, p.salario, p.estadocivil, p.genero, p.datanascimento,
                                    p.email, p.telefone, p.cep,pm.id_materia,
                                    CONCAT(cidade, '-', uf, ', ', bairro, ', ', rua, ', ', numerorua) AS endereco_completo FROM professor p
                                    LEFT JOIN professor_materia pm on p.id = pm.id_professor
                                    INNER JOIN materia m on pm.id_materia = m.id
                                    GROUP BY p.id;", con.con);
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
                sql = new MySqlCommand("INSERT INTO professor(nome, curso, salario, estadocivil, genero, datanascimento, email, telefone, cep, cidade, uf, bairro, rua, numerorua) " +
                    "VALUES (@nome, @curso, @salario, @estadocivil, @genero, @datanascimento, @email, @telefone, @cep, @cidade, @uf, @bairro, @rua, @numerorua);", con.con);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@curso", professor.Curso);
                sql.Parameters.AddWithValue("@salario", professor.Salario);
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
                con.FecharConexao();

                foreach (var item in professor.ListaDemateria)
                {
                    con.AbrirConexao();
                    int id_professor = IdUltimoProfessor();
                    sql = new MySqlCommand("INSERT INTO professor_materia(id_professor, id_materia) VALUES (@professorid, @materia);", con.con);
                    sql.Parameters.AddWithValue("@professorid", id_professor);
                    sql.Parameters.AddWithValue("@materia", item);
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
                sql.Parameters.AddWithValue("@materia", professor.ListaDemateria);
                sql.Parameters.AddWithValue("@telefone", professor.Telefone);
                sql.Parameters.AddWithValue("@cep", professor.Cep);
                sql.Parameters.AddWithValue("@cidade", professor.Cidade);
                sql.Parameters.AddWithValue("@uf", professor.Uf);
                sql.Parameters.AddWithValue("@bairro", professor.Bairro);
                sql.Parameters.AddWithValue("@rua", professor.Rua);
                sql.Parameters.AddWithValue("@numerorua", professor.Numerorua);
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

        public int IdUltimoProfessor()
        {
            sql = new MySqlCommand("SELECT MAX(id) as id FROM professor", con.con);
            var result = sql.ExecuteScalar();
            return Convert.ToInt32(result);
        }
    }
}