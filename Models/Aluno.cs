using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_dotNetPOO.Models
{
    public sealed class Aluno : Pessoa // SEALED - CLASSE SELADA NÃO PODE SER HERDADA
    {
        public Aluno()
        {

        }
        public Aluno(string nome) : base(nome) // OBRIGATÓRIO POR A CLASSE PAI TER UM CONSTRUTOR
        {

        }
        public double Nota;

        public override void Apresentar() // POLIMORFISMO OVERRIDE KEYWORD
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, e sou um aluno nota {Nota}!");

        }
    }
}