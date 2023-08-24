using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Model
{
    internal class AlunoModel : IPessoaModel<Aluno>
    {
        private AlunoDAO dao = new AlunoDAO();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarAluno();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Salvar(Aluno aluno)
        {
            try
            {
                dao.InserirAluno(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar aluno: " + ex.Message);
            }
        }

        public void Editar(Aluno aluno)
        {
            try
            {
                dao.EditarAluno(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar aluno: " + ex.Message);
            }
        }
    }
}