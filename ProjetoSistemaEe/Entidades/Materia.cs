using System.Data;

namespace ProjetoSistemaEe.Entidades
{
    public class Materia
    {
        private string nome;
        private int materiaid;
        private int v;

        public Materia()
        {
        }

        public Materia(int v)
        {
            this.v = v;
        }

        public Materia(int materia_id, string nome)
        {
            this.nome = nome;
            this.Materiaid = materia_id;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Materiaid { get => materiaid; set => materiaid = value; }
    }
}