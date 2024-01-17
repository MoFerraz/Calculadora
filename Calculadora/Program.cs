using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorum;
            decimal valordois;

            Console.WriteLine("Bem vindo a calculadora rudimentar");
            Console.WriteLine("Digite o primeiro valor: ");
            valorum = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valordois = decimal.Parse(Console.ReadLine());

            decimal soma = valorum + valordois;
            decimal multiplicacao = valorum * valordois;
            decimal subtracao = valorum - valordois;
            decimal divisao = valorum / valordois;

            Console.Clear();

            Console.WriteLine("A soma dos números é: " + soma);
            Console.WriteLine("A multiplicacao dos números é: " + multiplicacao);
            Console.WriteLine("A subtracao dos números é: " + subtracao);
            Console.WriteLine("A divisao dos números é: " + divisao);

            Console.ReadKey();

        }
    }
}
