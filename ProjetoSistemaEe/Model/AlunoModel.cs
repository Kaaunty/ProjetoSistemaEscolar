using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Model
{
    internal class AlunoModel
    {
        private AlunoDAO dao = new AlunoDAO();

        public DataTable ListarAluno()
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
    }
}