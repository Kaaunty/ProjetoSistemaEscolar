using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjetoSistemaEe.DAO
{
    internal class Conexao
    {
        private string conexao = "SERVER=localhost; DATABASE=xd_university; UID=root; PWD=;";
        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}