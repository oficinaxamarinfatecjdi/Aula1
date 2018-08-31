using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variável: tipo nome;
            // Tipos primitivos de variáveis: int, float, double, string 
            int valor1;
            int valor2;
            Console.Write("Escolha o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escolha o segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            int resultado = valor1 + valor2;
            Console.WriteLine(valor1 + " + " + valor2 + " = " + resultado);

            Console.ReadKey();
        }
    }
}
