using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;

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
                sql = new MySqlCommand("INSERT INTO boletim (id_aluno, disciplina, nota1, nota2, nota3, nota4, media, id_professor, situacao) " +
                    "VALUES (@idAluno, @idDisciplina, @nota1, @nota2, @nota3, @nota4, @media, @idprofessor, @situacao)", con.con);
                sql.Parameters.AddWithValue("@idAluno", boletim.IdAluno);
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
            catch (Exception ex)
            {
                throw ex;
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
                a.materia AS Disciplina_Aluno,
                p.id AS ID_Professor,
                p.nome AS Nome_Professor,
                p.materia AS Materia_Professor
                FROM aluno a
                JOIN professor p ON a.materia = p.materia
                LEFT JOIN boletim b ON a.ra = b.id_aluno
                WHERE b.id IS NULL;", con.con);
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
    }
}