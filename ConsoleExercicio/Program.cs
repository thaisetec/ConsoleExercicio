using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("digite o valor do litro de combustível:");
            double comb = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a distancia percorrida em km:");
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine("qunatos km o veículo faz por litro? ");
            double lit = double.Parse(Console.ReadLine());
            double resultado = comb / lit;
            double valor = resultado * km;
            Console.WriteLine("o valor total de gastos foi de  :" + valor);
            Console.ReadKey();

        }
    }
}
