using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo da porcentagem de sólidos ");

            decimal placaVazia;
            decimal pesoAmostra;
            decimal pesoAposSecagem;


            Console.WriteLine("Peso da placa de petri vazia: ");
            placaVazia = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Peso da amostra: ");
            pesoAmostra = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Peso da placa + peso da amostra: ");
            pesoAposSecagem = decimal.Parse(Console.ReadLine());

        }
    }
}
