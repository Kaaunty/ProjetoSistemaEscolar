namespace ProjetoSistemaEe.Entidades
{
    internal class Aluno : Pessoa
    {
        private int ra;

        private string periodo;
        private string turno;
        private int curso;

        public int RA { get => ra; set => ra = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Turno { get => turno; set => turno = value; }
        public int Curso { get => curso; set => curso = value; }
    }
}