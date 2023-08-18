namespace ProjetoSistemaEe.Entidades
{
    internal class Aluno : Pessoa
    {
        int RA;
        string curso;
        string periodo;
        string turno;
        string email;

        public int RA1 { get => RA; set => RA = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Email { get => email; set => email = value; }
    }
}
