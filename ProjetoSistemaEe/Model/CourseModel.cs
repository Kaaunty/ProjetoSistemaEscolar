using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    internal class CourseModel
    {
        private CourseDAO dao = new CourseDAO();

        public List<Course> GetCourses()
        {
            try
            {
                List<Course> courses = new List<Course>();
                courses = dao.GetCourses();
                return courses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Course> GetCoursesContainStudent()
        {
            try
            {
                List<Course> courses = new List<Course>();
                courses = dao.GetCoursesContainStudent();
                return courses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Student> GetStudentsByCourse(int courseId)
        {
            try
            {
                List<Student> students = new List<Student>();
                students = dao.GetStudentsByCourse(courseId);
                return students;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}