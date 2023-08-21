namespace ProjetoSistemaEe.Entidades
{
    internal class Aluno : Pessoa
    {
        private int ra;
        private string curso;

        private string periodo;
        private string turno;
        private string email;

        public int RA { get => ra; set => ra = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Email { get => email; set => email = value; }
    }
}