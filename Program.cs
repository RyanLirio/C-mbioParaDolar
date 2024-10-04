using System;
using System.Globalization;

namespace conversorDeDolar
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.Clear();
            ConversorDeMoeda c = new ConversorDeMoeda();

            Console.WriteLine("Qual é o preço atual do dolar?");
            c.Cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos reais você deseja converter para dolar?");
            c.Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"A conversão resultou em {c} dólares (Já descontada a taxa de IOF de 6%)");

        }
    }
}