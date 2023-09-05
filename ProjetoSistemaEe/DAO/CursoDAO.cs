using MySql.Data.MySqlClient;
using System;
using System.Data;

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
    }
}