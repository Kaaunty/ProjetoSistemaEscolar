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

        public List<Materia> ListarMateria()
        {
            try
            {
                List<Materia> materias = new List<Materia>();
                materias = dao.ListarMaterias();
                return materias;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}