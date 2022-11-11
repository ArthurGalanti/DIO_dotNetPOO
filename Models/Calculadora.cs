using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO_dotNetPOO.Interfaces;

namespace DIO_dotNetPOO.Models
{
    public class Calculadora : ICalculadora
    {


        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public double Potencia(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}