using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaEe.Entidades
{
    internal class Pessoa
    {
        string nome;
        string estadocivil;
        string telefone;
        string cep;
        string estado;
        string cidade;
        string bairro;
        string rua;
        DateTime datanascimento;
        string genero;

        public string Nome { get => nome; set => nome = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Rua { get => rua; set => rua = value; }
        public DateTime Datanascimento { get => datanascimento; set => datanascimento = value; }
        public string Genero { get => genero; set => genero = value; }
    }

}
