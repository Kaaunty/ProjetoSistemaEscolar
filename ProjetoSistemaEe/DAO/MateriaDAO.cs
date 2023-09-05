using MySql.Data.MySqlClient;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;

namespace ProjetoSistemaEe.DAO
{
    internal class MateriaDAO
    {
        private MySqlCommand sql;
        private Conexao con = new Conexao();

        public DataTable ListarMaterias()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM materia order by nome", con.con);
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
    }
}