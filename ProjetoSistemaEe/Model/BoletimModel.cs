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

        public List<Boletim> Listar()
        {
            try
            {
                List<Boletim> boletins = new List<Boletim>();
                boletins = dao.ListarBoletim();
                return boletins;
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

        public DataTable ListarAlunoPorCurso(int curso_id)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarAlunoPorCurso(curso_id);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarMateriaPorProfessor(int id_professor)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarMateriaPorProfessor(id_professor);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}