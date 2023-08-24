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

        public DataTable BuscarMateria(int cursoid)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT materia.*, curso_materia.materiaid FROM curso_materia " +
                    "INNER JOIN materia ON materia.id = curso_materia.materiaid WHERE curso_materia.cursoid = @cursoid order by nome", con.con);
                sql.Parameters.AddWithValue("@cursoid", cursoid);
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