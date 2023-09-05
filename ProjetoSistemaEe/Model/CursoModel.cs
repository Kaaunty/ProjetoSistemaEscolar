using ProjetoSistemaEe.DAO;
using System;
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
    }
}