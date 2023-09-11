using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace ProjetoSistemaEe.Entidades
{
    internal class Professor : Pessoa
    {
        private string salario;
        private int id;

        private List<Materia> materia = new List<Materia>();

        public Professor()
        {
        }

        public Professor(int id, string nome, List<Materia> materia, string salario, string estadocivil, string genero, DateTime datanascimento, string email, string telefone, string cep, string cidade, string uf, string bairro, string rua, string numerorua)
        {
            this.id = id;
            Nome = nome;
            this.Materia = materia;
            this.salario = salario;
            Estadocivil = estadocivil;
            Genero = genero;
            Datanascimento = datanascimento;
            Email = email;
            Telefone = telefone;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Bairro = bairro;
            Rua = rua;
            Numerorua = numerorua;
        }

        public int Id { get => id; set => id = value; }

        public string Salario { get => salario; set => salario = value; }
        internal List<Materia> Materia { get => materia; set => materia = value; }
    }
}