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

        public DataTable AlunoMateria(int id_aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT p.id, p.nome, p.curso, p.materia, c.nome as nome_curso,m.nome as nome_materia
                                    FROM xd_university.professor p
                                    LEFT JOIN cursos c on p.curso = c.id
                                    LEFT JOIN materia m on p.materia = m.id
                                    JOIN aluno a on p.curso = a.curso
                                    WHERE p.curso = @id_aluno;", con.con);
                sql.Parameters.AddWithValue("@id_aluno", id_aluno);
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

        public DataTable ListarAlunoPorCurso(int curso_id)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand(
                    @"SELECT a.ra AS ID_Aluno,
                    a.nome AS Nome_Aluno,
                    a.curso as curso_aluno,
                    c.nome as Nome_Curso,
                    c.id as Id_curso
                    FROM aluno a
                    JOIN cursos c ON a.curso = c.id
                    JOIN boletim b on a.ra = b.id_aluno
                    WHERE a.curso = @id_curso", con.con);
                sql.Parameters.AddWithValue("@id_curso", curso_id);
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

        public DataTable ListarProfessorPorCurso(int id_Curso)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand(
                    @"SELECT p.id AS ID_Professor,
                    p.nome AS Nome_Professor,
                    p.curso as curso_Professor,
                    p.materia as ID_Materia,
                    c.nome as Nome_Curso,
                    c.id as Id_curso,
                    m.nome as Nome_Materia
                    FROM professor p
                    JOIN cursos c ON p.curso = c.id
                    JOIN materia m ON p.materia = m.id
                    WHERE p.curso = @id_curso
                    AND p.materia = m.id;", con.con);
                sql.Parameters.AddWithValue("@id_curso", id_Curso);
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