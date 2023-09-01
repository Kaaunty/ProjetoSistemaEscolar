using System.Collections.Generic;
using System.Windows.Documents;

namespace ProjetoSistemaEe.Entidades
{
    internal class Professor : Pessoa
    {
        private string salario;
        private int id;

        private List<int> listaDemateria = new List<int>();
        public int Id { get => id; set => id = value; }

        public string Salario { get => salario; set => salario = value; }
        public List<int> ListaDemateria { get => listaDemateria; set => listaDemateria = value; }
    }
}