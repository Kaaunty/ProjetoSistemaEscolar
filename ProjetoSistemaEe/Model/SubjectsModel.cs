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

        public List<Subjects> GetSubjectsByCourse(int courseId)
        {
            try
            {
                List<Subjects> subjects = new List<Subjects>();
                subjects = dao.GetSubjectsByCourse(courseId);
                return subjects;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Subjects> GetSubjectsNotTakenByStudentFromProfessorAndCourse(int professorId, int courseId, int studentRa)
        {
            try
            {
                List<Subjects> subjects = new List<Subjects>();
                subjects = dao.GetSubjectsNotTakenByStudentFromProfessorAndCourse(professorId, courseId, studentRa);
                return subjects;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}