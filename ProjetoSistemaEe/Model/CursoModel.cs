using ProjetoSistemaEe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DataTable BuscarMateria(int cursoid)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarMateria(cursoid);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}