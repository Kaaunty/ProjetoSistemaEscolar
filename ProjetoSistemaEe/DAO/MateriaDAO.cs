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
                sql = new MySqlCommand("SELECT * FROM disciplinas order by nome_disciplina", con.con);
                MySqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    string nome = dr["nome_disciplina"].ToString();
                    Materia materia = new Materia(id, nome);
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