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

        public void Register(Student student)
        {
            try
            {
                dao.RegisterStudent(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(Student student)
        {
            try
            {
                dao.EditStudent(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Student student)
        {
            try
            {
                dao.DeleteStudent(student);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}