using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float soma;
            float subtracao;
            float multiplicacao;
            float resto;
            float divisao;

            Console.Write("escreva o valor do numero A:");

            Console.WriteLine("");

            a = int.Parse(Console.ReadLine());

            Console.Write("escreva o valor do numero B:");

            Console.WriteLine("");

            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("A soma dos valores é " + soma);

            subtracao = a - b;

            Console.WriteLine("A subtraçao dos valores é " + subtracao);

            multiplicacao = a * b;

            Console.WriteLine("A multipliçao dos valores é " + multiplicacao);

            divisao = a / b;

            Console.WriteLine("A divisao dos valores é " + divisao);







            Console.ReadKey();
        }
    }
}
