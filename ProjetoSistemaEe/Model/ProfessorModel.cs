using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    internal class ProfessorModel : IFunctionModel<Professor>
    {
        private ProfessorDAO dao = new ProfessorDAO();

        public List<Professor> GetEntities()
        {
            try
            {
                List<Professor> professors = new List<Professor>();
                professors = dao.GetProfessors();
                return professors;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Register(Professor professor)
        {
            try
            {
                dao.RegisterProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Professor professor)
        {
            try
            {
                dao.EditProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Professor professor)
        {
            try
            {
                dao.DeleteProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}