using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaEe.Entidades
{
    internal class Curso
    {
        private int id_curso;
        private string nome_curso;

        public Curso(int id_curso, string nome_curso)
        {
            this.id_curso = id_curso;
            this.nome_curso = nome_curso;
        }
    }
}