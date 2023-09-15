using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;

namespace ProjetoSistemaEe.DAO
{
    internal class MateriaDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public List<Materia> ListarMaterias()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(@"select cm.curso_id,cm.materia_id,d.nome_disciplina,c.nome from cursos_materias cm
                                         JOIN cursos c ON cm.curso_id = c.id
                                         JOIN disciplinas d ON cm.materia_id = d.id
                                         ORDER BY nome_disciplina;", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    int idCurso = Convert.ToInt32(dr["curso_id"]);
                    int idMateria = Convert.ToInt32(dr["materia_id"]);
                    string nome = dr["nome_disciplina"].ToString();
                    string nomeCurso = dr["nome"].ToString();
                    Materia materia = new Materia(idCurso, idMateria, nome, nomeCurso);
                    materias.Add(materia);
                }
                return materias;
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