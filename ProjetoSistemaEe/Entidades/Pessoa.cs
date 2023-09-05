using System;

namespace ProjetoSistemaEe.Entidades
{
    internal class Pessoa
    {
        private string nome;
        private string estadocivil;
        private string telefone;
        private string cep;
        private string cidade;
        private string bairro;
        private string rua;
        private DateTime datanascimento;
        private string genero;
        private string uf;
        private string numerorua;
        private string estadoCivil;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cep { get => cep; set => cep = value; }

        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Rua { get => rua; set => rua = value; }
        public DateTime Datanascimento { get => datanascimento; set => datanascimento = value; }
        public string Genero { get => genero; set => genero = value; }

        public string Uf { get => uf; set => uf = value; }
        public string Numerorua { get => numerorua; set => numerorua = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Email { get => email; set => email = value; }
    }
}