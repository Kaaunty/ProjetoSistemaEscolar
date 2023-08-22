using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System.Data;
using System.Windows;

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
                sql = new MySqlCommand(@"SELECT id, nome, curso, salario, materia, estadocivil, genero, datanascimento,
                                    email, telefone, cep,CONCAT
                                    (cidade, '-', uf, ', ', bairro, ', ', rua, ', ', numerorua) AS endereco_completo FROM xd_university.professor", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException)
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir professor: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }
    }
}