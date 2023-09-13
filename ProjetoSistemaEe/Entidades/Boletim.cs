namespace ProjetoSistemaEe.Entidades
{
    public class Boletim
    {
        public int id;
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;
        public double media;
        public string situacao;
        public int ra;
        public string nome_aluno;
        public string nome_curso;
        public string nome_materia;
        public string nome_professor;
        public int id_curso;
        public int id_professor;
        public int id_disciplina;

        public Boletim(int id, int ra, string nome_aluno, string nome_curso, int id_curso, int id_professor, int id_disciplina, string nome_materia, string nome_professor, double nota1, double nota2, double nota3, double nota4, double media, string situacao)
        {
            this.id = id;
            this.ra = ra;
            this.nome_aluno = nome_aluno;
            this.nome_curso = nome_curso;
            this.id_curso = id_curso;
            this.id_professor = id_professor;
            this.id_disciplina = id_disciplina;
            this.nome_materia = nome_materia;
            this.nome_professor = nome_professor;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.media = media;
            this.situacao = situacao;
        }
    }
}