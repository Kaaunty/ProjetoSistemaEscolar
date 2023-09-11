using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Model
{
    internal class AlunoModel : IPessoaModel<Aluno>
    {
        private AlunoDAO dao = new AlunoDAO();

        public List<Aluno> Listar()
        {
            try
            {
                List<Aluno> alunos = new List<Aluno>();
                alunos = dao.GetAlunos();
                return alunos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Salvar(Aluno aluno)
        {
            try
            {
                dao.InserirAluno(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Editar(Aluno aluno)
        {
            try
            {
                dao.EditarAluno(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Aluno aluno)
        {
            try
            {
                dao.ExcluirAluno(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}