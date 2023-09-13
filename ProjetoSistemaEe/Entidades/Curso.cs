namespace ProjetoSistemaEe.Entidades
{
    public class Curso
    {
        private int id_curso;
        private string nome_curso;

        public Curso()
        {
        }

        public Curso(int id_curso)
        {
            this.Id_curso = id_curso;
        }

        public Curso(int id_curso, string nome_curso)
        {
            this.Id_curso = id_curso;
            this.Nome_curso = nome_curso;
        }

        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Nome_curso { get => nome_curso; set => nome_curso = value; }

        public override string ToString()
        {
            return Nome_curso;
        }
    }
}