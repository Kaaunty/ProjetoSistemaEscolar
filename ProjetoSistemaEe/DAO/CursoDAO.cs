using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Documents;

namespace ProjetoSistemaEe.DAO
{
    internal class CursoDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public DataTable ListarCursos()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM cursos order by nome", con.con);
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
        }

        public List<Curso> ListarCursoSeTiverAluno()
        {
            List<Curso> ListaCursos = new List<Curso>();
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM cursos c inner join aluno a on c.id = a.curso group by c.id", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Curso curso = new Curso();
                    curso.Id_curso = Convert.ToInt32(dr["id"]);
                    curso.Nome_curso = dr["nome"].ToString();
                    ListaCursos.Add(curso);
                }
                return ListaCursos;
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

        public List<Aluno> ListarAlunoPorCurso(int id_curso)
        {
            List<Aluno> ListaAlunos = new List<Aluno>();
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT a.ra, a.nome FROM aluno a
                                         JOIN boletim b ON a.ra != b.id_aluno
                                         where a.curso = @id_curso;", con.con);
                sql.Parameters.AddWithValue("@id_curso", id_curso);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Aluno aluno = new Aluno();
                    aluno.RA = Convert.ToInt32(dr["ra"]);
                    aluno.Nome = dr["nome"].ToString();
                    ListaAlunos.Add(aluno);
                }
                return ListaAlunos;
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

        public List<Materia> ListarMateriaPorProfessorECurso(int id_professor, int id_curso)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"SELECT d.nome_disciplina, d.id as materia_id
                                         FROM disciplinas d
                                         INNER JOIN cursos_materias cm ON d.id = cm.materia_id
                                         INNER JOIN cursos c ON cm.curso_id = c.id
                                         INNER JOIN professor_materia pm ON d.id = pm.id_materia
                                         INNER JOIN professor p ON pm.id_professor = p.id
                                         WHERE p.id = @id_professor
                                           AND c.id = @id_curso;", con.con);
                sql.Parameters.AddWithValue("@id_professor", id_professor);
                sql.Parameters.AddWithValue("@id_curso", id_curso);
                MySqlDataReader dr = sql.ExecuteReader();
                List<Materia> ListaMaterias = new List<Materia>();
                while (dr.Read())
                {
                    Materia materia = new Materia();
                    materia.Materiaid = Convert.ToInt32(dr["materia_id"]);
                    materia.Nome = dr["nome_disciplina"].ToString();
                    ListaMaterias.Add(materia);
                }
                return ListaMaterias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.FecharConexao();
            }
        }
    }
}