using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    internal class SubjectsModel
    {
        private SubjectDAO dao = new SubjectDAO();

        public List<Subjects> GetSubjects()
        {
            try
            {
                List<Subjects> subjects = new List<Subjects>();
                subjects = dao.GetSubjects();
                return subjects;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}