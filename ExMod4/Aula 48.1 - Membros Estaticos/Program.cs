using System;
using System.Globalization;

namespace Aula_48._1___Membros_Estaticos {
    class Program {
        static void Main(string[] args) {

            double cot, usd, aPagar;

            Console.Write("Qual a cotacao do dolar? R$ ");
            cot = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares deseja comprar? US$ ");
            usd = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            aPagar = ConversorDeMoeda.Conversor(cot, usd);

            Console.WriteLine($"Valor a ser pago em reais: R$ {aPagar.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
