using System.Data;

namespace ProjetoSistemaEe.Entidades
{
    public class Materia
    {
        private string nome;
        private int materiaid;
        private int idCurso;
        private string nomeCurso;

        public Materia()
        {
        }

        public Materia(int materia_id, string nome)
        {
            this.Nome = nome;
            this.Materiaid = materia_id;
        }

        public Materia(int idCurso, int Materia_id, string nome, string nomeCurso)
        {
            this.IdCurso = idCurso;
            this.Materiaid = Materia_id;
            this.Nome = nome;
            this.NomeCurso = nomeCurso;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Materiaid { get => materiaid; set => materiaid = value; }
        public string NomeCurso { get => nomeCurso; set => nomeCurso = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
    }
}