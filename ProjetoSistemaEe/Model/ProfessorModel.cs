using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;

namespace ProjetoSistemaEe.Model
{
    internal class ProfessorModel
    {
        private ProfessorDAO dao = new ProfessorDAO();

        public DataTable ListarProfessor()
        {
            try
            {
                return dao.ListarProfessor();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CadastrarProfessor(Professor professor)
        {
            try
            {
                dao.CadastrarProfessor(professor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}