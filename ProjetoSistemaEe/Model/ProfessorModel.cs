﻿using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Model
{
    internal class ProfessorModel : IPessoaModel<Professor>
    {
        private ProfessorDAO dao = new ProfessorDAO();

        public List<Professor> Listar()
        {
            try
            {
                List<Professor> professores = new List<Professor>();
                professores = dao.ListarProfessor();
                return professores;
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