using System;

namespace ProjetoSistemaEe.Entidades
{
    public class Aluno : Pessoa
    {
        private int ra;

        private string periodo;
        private string turno;

        public Curso curso;
        public int RA { get => ra; set => ra = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Turno { get => turno; set => turno = value; }
        public Curso Curso { get => curso; set => curso = value; }

        public Aluno(int ra, string nome, Curso curso, string periodo, string estadocivil, string genero, DateTime datanascimento, string email, string turno, string telefone, string cep, string cidade, string uf, string bairro, string rua, string numerorua)
        {
            this.ra = ra;
            Nome = nome;
            Curso = curso;
            this.periodo = periodo;
            Estadocivil = estadocivil;
            Genero = genero;
            Datanascimento = datanascimento;
            Email = email;
            this.turno = turno;
            Telefone = telefone;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Bairro = bairro;
            Rua = rua;
            Numerorua = numerorua;
        }

        public Aluno()
        {
        }
    }
}