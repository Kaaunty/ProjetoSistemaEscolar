using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CadastrarBoletim(Boletim boletim)
        {
            try
            {
                dao.CadastrarBoletim(boletim);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}