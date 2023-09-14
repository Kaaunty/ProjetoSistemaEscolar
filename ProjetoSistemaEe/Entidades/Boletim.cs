namespace ProjetoSistemaEe.Entidades
{
    public class Boletim
    {
        private int id;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double media;
        private string situacao;
        private int ra;
        private string nome_aluno;
        private string nome_curso;
        private string nome_materia;
        private string nome_professor;
        private int id_curso;
        private int id_professor;
        private int id_disciplina;

        public int Id { get => id; set => id = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Nota4 { get => nota4; set => nota4 = value; }
        public double Media { get => media; set => media = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public int Ra { get => ra; set => ra = value; }
        public string Nome_aluno { get => nome_aluno; set => nome_aluno = value; }
        public string Nome_curso { get => nome_curso; set => nome_curso = value; }
        public string Nome_materia { get => nome_materia; set => nome_materia = value; }
        public string Nome_professor { get => nome_professor; set => nome_professor = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
        public int Id_professor { get => id_professor; set => id_professor = value; }
        public int Id_disciplina { get => id_disciplina; set => id_disciplina = value; }

        public Boletim(int id, int ra, string nome_aluno, string nome_curso, int id_curso, int id_professor, int id_disciplina, string nome_materia, string nome_professor, double nota1, double nota2, double nota3, double nota4, double media, string situacao)
        {
            this.Id = id;
            this.Ra = ra;
            this.Nome_aluno = nome_aluno;
            this.Nome_curso = nome_curso;
            this.Id_curso = id_curso;
            this.Id_professor = id_professor;
            this.Id_disciplina = id_disciplina;
            this.Nome_materia = nome_materia;
            this.Nome_professor = nome_professor;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nota4 = nota4;
            this.Media = media;
            this.Situacao = situacao;
        }

        public Boletim(int ra, int id_professor, int id_disciplina, int id_curso, double nota1, double nota2, double nota3, double nota4, double media, string situacao)
        {
            this.Ra = ra;
            this.Id_professor = id_professor;
            this.Id_disciplina = id_disciplina;
            this.Id_curso = id_curso;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nota4 = nota4;
            this.Media = media;
            this.Situacao = situacao;
        }
    }
}