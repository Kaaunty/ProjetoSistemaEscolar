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

        public void Editar(Professor professor)
        {
            try
            {
                dao.EditarProfessor(professor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar aluno: " + ex.Message);
            }
        }

        public void Excluir(Professor professor)
        {
            try
            {
                dao.ExcluirProfessor(professor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno: " + ex.Message);
            }
        }
    }
}