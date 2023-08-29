using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;

namespace ProjetoSistemaEe.Model
{
    internal class BoletimModel
    {
        private BoletimDAO dao = new BoletimDAO();

        public DataTable ListarAlunoPorMateria()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarAlunoPorMateria();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CadastrarBoletim(Boletim boletim)
        {
            try
            {
                dao.CadastrarBoletim(boletim);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarNotas()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarBoletim();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EditarBoletim(Boletim boletim)
        {
            try
            {
                dao.EditarBoletim(boletim);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}