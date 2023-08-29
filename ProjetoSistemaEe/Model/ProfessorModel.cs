using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

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
            catch (Exception)
            {
                throw;
            }
        }

        public void Salvar(Professor professor)
        {
            try
            {
                dao.CadastrarProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Editar(Professor professor)
        {
            try
            {
                dao.EditarProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Professor professor)
        {
            try
            {
                dao.ExcluirProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}