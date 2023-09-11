namespace ProjetoSistemaEe.Entidades
{
    internal class Materia
    {
        private string nome;
        private int cursoid;

        public Materia()
        {
        }

        public Materia(int id_curso, string nome)
        {
            this.nome = nome;
            this.Cursoid = id_curso;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Cursoid { get => cursoid; set => cursoid = value; }
    }
}