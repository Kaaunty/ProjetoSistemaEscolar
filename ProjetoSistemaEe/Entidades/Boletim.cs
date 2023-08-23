using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaEe.Entidades
{
    internal class Boletim
    {
        private int idAluno;
        private string idDisciplina;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double media;
        private int idprofessor;
        private string situacao;

        public int IdAluno { get => idAluno; set => idAluno = value; }
        public string IdDisciplina { get => idDisciplina; set => idDisciplina = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Nota4 { get => nota4; set => nota4 = value; }
        public double Media { get => media; set => media = value; }
        public int Idprofessor { get => idprofessor; set => idprofessor = value; }
        public string Situacao { get => situacao; set => situacao = value; }
    }
}