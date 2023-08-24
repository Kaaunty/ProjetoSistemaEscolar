using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;

namespace ProjetoSistemaEe.Model
{
    internal class ProfessorModel : IPessoaModel<Professor>
    {
        private ProfessorDAO dao = new ProfessorDAO();

        public DataTable Listar()
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

        public void Salvar(Professor professor)
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

        public void Editar(Professor pessoa)
        {
            throw new NotImplementedException();
        }
    }
}