using MySql.Data.MySqlClient;
using System;

namespace ProjetoSistemaEe.DAO
{
    internal class Connection
    {
        private static string connection = "SERVER=localhost; DATABASE=xd_university; UID=root; PWD=root;";
        public MySqlConnection con = null;

        public void OpenConnection()
        {
            try
            {
                con = new MySqlConnection(connection);
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
                con = new MySqlConnection(connection);
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}