using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;

namespace ProjetoSistemaEe.Model
{
    internal class BoletimModel
    {
        private BoletimDAO dao = new BoletimDAO();

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

        public List<Boletim> ListarBoletim()
        {
            try
            {
                List<Boletim> boletims = new List<Boletim>();
                boletims = dao.ListarBoletim();
                return boletims;
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