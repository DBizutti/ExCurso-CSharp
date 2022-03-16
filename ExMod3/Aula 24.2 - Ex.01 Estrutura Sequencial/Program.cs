using System;
using System.Globalization;

namespace Aula_24._2___Ex._01_Estrutura_Sequencial {
    class Program {
        static void Main(string[] args) {

            double pi = 3.14159;
            double raio, area;

            Console.WriteLine("----- Calculando a área de um circulo -----");
            Console.WriteLine("Digite o valor do raio:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio , 2.00);

            Console.WriteLine($"\nValor da área é igual a: {area.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}
