using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_dotNetPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string nome) : base(nome) // OBRIGATÓRIO POR A CLASSE PAI TER UM CONSTRUTOR
        {

        }
        public double Salario { get; set; }

        public sealed override void Apresentar() // SEALED - MÉTODO SELADO NÃO PODE SER HERDADO
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, sou um professor e ganho {Salario}!");

        }
    }
}