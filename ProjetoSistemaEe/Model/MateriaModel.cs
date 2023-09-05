using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaEe.Model
{
    internal class MateriaModel
    {
        private MateriaDAO dao = new MateriaDAO();

        public DataTable ListarMateria()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarMaterias();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}