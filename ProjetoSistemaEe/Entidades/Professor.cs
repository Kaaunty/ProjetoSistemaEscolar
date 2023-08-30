namespace ProjetoSistemaEe.Entidades
{
    internal class Professor : Pessoa
    {
        private string salario;
        private int id;
        private int materia;
        public int Id { get => id; set => id = value; }
        public string Salario { get => salario; set => salario = value; }
        public int Materia { get => materia; set => materia = value; }
    }
}