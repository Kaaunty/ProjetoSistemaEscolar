using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace ProjetoSistemaEe.DAO
{
    internal class Connection
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public MySqlConnection con = null;

        public void OpenConnection()
        {
            try
            {
                con = new MySqlConnection(connectionString);
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            try
            {
                con = new MySqlConnection(connectionString);
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}