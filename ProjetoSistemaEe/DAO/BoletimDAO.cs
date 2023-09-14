using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;

namespace ProjetoSistemaEe.DAO
{
    internal class BoletimDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public List<Boletim> ListarBoletim()
        {
            List<Boletim> boletims = new List<Boletim>();
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(
                @"SELECT id_aluno AS RA_aluno,
                a.nome AS nome_aluno,
                c.nome AS nome_Curso,
                d.nome_disciplina AS nome_Materia,
                p.nome AS nome_Professor,
                p.id as id_professor,
                nota1,
                nota2,
                nota3,
                nota4,
                media,
                situacao,
                id_curso,
                b.id as id_boletim,
                disciplina as id_disciplina
                FROM boletim b
                JOIN professor p ON p.id = b.id_professor
                JOIN aluno a ON a.RA = b.id_aluno
                JOIN cursos c on c.id = b.id_curso
                JOIN disciplinas d on  d.id = b.disciplina;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id_boletim"]);
                    int ra = Convert.ToInt32(dr["RA_aluno"]);
                    string nome_aluno = dr["nome_aluno"].ToString();
                    string nome_curso = dr["nome_Curso"].ToString();
                    int id_curso = Convert.ToInt32(dr["id_curso"]);
                    int id_professor = Convert.ToInt32(dr["id_professor"]);
                    int id_disciplina = Convert.ToInt32(dr["id_disciplina"]);
                    string nome_materia = dr["nome_Materia"].ToString();
                    string nome_professor = dr["nome_Professor"].ToString();
                    double nota1 = Convert.ToDouble(dr["nota1"]);
                    double nota2 = Convert.ToDouble(dr["nota2"]);
                    double nota3 = Convert.ToDouble(dr["nota3"]);
                    double nota4 = Convert.ToDouble(dr["nota4"]);
                    double media = Convert.ToDouble(dr["media"]);
                    string situacao = dr["situacao"].ToString();
                    Boletim boletim = new Boletim(id, ra, nome_aluno, nome_curso, id_curso, id_professor, id_disciplina, nome_materia, nome_professor, nota1, nota2, nota3, nota4, media, situacao);
                    boletims.Add(boletim);
                }
                return boletims;
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

        public void CadastrarBoletim(Boletim boletim)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO boletim (id_aluno,id_curso, disciplina, nota1, nota2, nota3, nota4, media, id_professor, situacao) " +
                    "VALUES (@idAluno, @idCurso, @idDisciplina, @nota1, @nota2, @nota3, @nota4, @media, @idprofessor, @situacao)", con.con);
                sql.Parameters.AddWithValue("@idAluno", boletim.Ra);
                sql.Parameters.AddWithValue("@idCurso", boletim.Id_curso);
                sql.Parameters.AddWithValue("@idDisciplina", boletim.Id_disciplina);
                sql.Parameters.AddWithValue("@nota1", boletim.Nota1);
                sql.Parameters.AddWithValue("@nota2", boletim.Nota2);
                sql.Parameters.AddWithValue("@nota3", boletim.Nota3);
                sql.Parameters.AddWithValue("@nota4", boletim.Nota4);
                sql.Parameters.AddWithValue("@media", boletim.Media);
                sql.Parameters.AddWithValue("@idprofessor", boletim.Id_professor);
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