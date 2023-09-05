using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;

namespace ProjetoSistemaEe.DAO
{
    internal class BoletimDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public void CadastrarBoletim(Boletim boletim)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO boletim (id_aluno,id_curso, disciplina, nota1, nota2, nota3, nota4, media, id_professor, situacao) " +
                    "VALUES (@idAluno, @idCurso, @idDisciplina, @nota1, @nota2, @nota3, @nota4, @media, @idprofessor, @situacao)", con.con);
                sql.Parameters.AddWithValue("@idAluno", boletim.IdAluno);
                sql.Parameters.AddWithValue("@idCurso", boletim.IdCurso);
                sql.Parameters.AddWithValue("@idDisciplina", boletim.IdDisciplina);
                sql.Parameters.AddWithValue("@nota1", boletim.Nota1);
                sql.Parameters.AddWithValue("@nota2", boletim.Nota2);
                sql.Parameters.AddWithValue("@nota3", boletim.Nota3);
                sql.Parameters.AddWithValue("@nota4", boletim.Nota4);
                sql.Parameters.AddWithValue("@media", boletim.Media);
                sql.Parameters.AddWithValue("@idprofessor", boletim.Idprofessor);
                sql.Parameters.AddWithValue("@situacao", boletim.Situacao);
                sql.ExecuteNonQuery();
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

        public DataTable ListarAlunoPorCurso(int id_curso)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT a.nome as Nome_Aluno,
                                    a.ra as RA_Aluno,
                                    c.id,
                                    c.nome as Nome_Curso
                                    FROM aluno a
                                    JOIN cursos c on a.curso = c.id
                                    Where c.id = @id_curso;", con.con);
                sql.Parameters.AddWithValue("@id_curso", id_curso);

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

        public DataTable ListarBoletim()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(
                @"SELECT id_aluno AS RA_aluno,
                a.nome AS nome_aluno,
                c.nome AS nome_Curso,
                m.nome AS nome_Materia,
                p.nome AS nome_Professor,
                nota1,
                nota2,
                nota3,
                nota4,
                media,
                situacao
                FROM boletim b
                JOIN professor p ON p.id = b.id_professor
                JOIN aluno a ON a.RA = b.id_aluno
                JOIN cursos c on c.id = b.id_curso
                JOIN materia m on  m.id = b.disciplina;", con.con);
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

        public void EditarBoletim(Boletim boletim)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE boletim SET nota1 = @nota1, nota2 = @nota2, nota3 = @nota3, nota4 = @nota4, media = @media, situacao = @situacao WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@id", boletim.Id);
                sql.Parameters.AddWithValue("@nota1", boletim.Nota1);
                sql.Parameters.AddWithValue("@nota2", boletim.Nota2);
                sql.Parameters.AddWithValue("@nota3", boletim.Nota3);
                sql.Parameters.AddWithValue("@nota4", boletim.Nota4);
                sql.Parameters.AddWithValue("@media", boletim.Media);
                sql.Parameters.AddWithValue("@situacao", boletim.Situacao);
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

        public DataTable ListarMateriaPorProfessor(int id_professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(
                         @"SELECT pm.id_materia,
                           pm.id_professor,
                           m.nome
                           FROM professor_materia pm
                           JOIN professor p ON pm.id_professor = p.id
                           JOIN materia m  ON pm.id_materia = m.id
                           WHERE p.id = @id_professor;", con.con);
                sql.Parameters.AddWithValue("@id_professor", id_professor);
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
    }
}