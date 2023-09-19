using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    internal class StudentModel : IFunctionModel<Student>
    {
        private StudentDAO dao = new StudentDAO();

        public List<Student> GetEntities()
        {
            try
            {
                List<Student> students = new List<Student>();
                students = dao.GetStudents();
                return students;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Register(Student aluno)
        {
            try
            {
                dao.RegisterStudent(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Student aluno)
        {
            try
            {
                dao.EditStudent(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Student aluno)
        {
            try
            {
                dao.DeleteStudent(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}