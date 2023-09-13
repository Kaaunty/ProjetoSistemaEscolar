using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Entidades
{
    public class Professor : Pessoa
    {
        private string salario;
        private int id;

        public List<Materia> Materia = new List<Materia>();

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
    }
}