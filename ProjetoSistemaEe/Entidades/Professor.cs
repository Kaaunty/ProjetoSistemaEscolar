using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaEe.Entidades
{
    internal class Professor : Pessoa
    {
        private string salario;
        private int id;
        public int Id { get => id; set => id = value; }
        public string Salario { get => salario; set => salario = value; }
    }
}