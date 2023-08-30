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

        public DataTable ListarAlunoPorMateria()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(
                @"SELECT a.ra AS ID_Aluno,
                a.nome AS Nome_Aluno,
                a.curso AS Curso_Aluno,
                p.id AS ID_Professor,
                p.nome AS Nome_Professor,
                p.curso AS Curso_Professor,
                p.materia AS Materia_Professor
                FROM aluno a
                JOIN professor p ON a.curso = p.curso
                LEFT JOIN boletim b ON a.ra = b.id_aluno
                WHERE b.id IS NULL;", con.con);
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
                @"SELECT
                b.id_aluno,
                b.id_professor,
                b.id_curso,
                b.nota1,
                b.nota2,
                b.nota3,
                b.nota4,
                b.situacao,
                p.nome,
                p.materia,
                a.nome
                FROM boletim b
                JOIN professor p ON b.id_professor = p.id
                JOIN aluno a ON b.id_aluno = a.ra", con.con);
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
    }
}