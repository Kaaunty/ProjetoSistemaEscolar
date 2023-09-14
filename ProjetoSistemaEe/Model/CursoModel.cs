using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoSistemaEe.Model
{
    internal class CursoModel
    {
        private CursoDAO dao = new CursoDAO();

        public DataTable ListarCursos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarCursos();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Curso> ListarCursosSeTiverAluno()
        {
            try
            {
                List<Curso> ListaCursos = new List<Curso>();
                ListaCursos = dao.ListarCursoSeTiverAluno();
                return ListaCursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Aluno> ListarAlunoPorCurso(int id_curso)
        {
            try
            {
                List<Aluno> ListaAlunos = new List<Aluno>();
                ListaAlunos = dao.ListarAlunoPorCurso(id_curso);
                return ListaAlunos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Materia> ListarMateriaPorProfessorECurso(int id_professor, int id_curso)
        {
            try
            {
                List<Materia> ListaMaterias = new List<Materia>();
                ListaMaterias = dao.ListarMateriaPorProfessorECurso(id_professor, id_curso);
                return ListaMaterias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}