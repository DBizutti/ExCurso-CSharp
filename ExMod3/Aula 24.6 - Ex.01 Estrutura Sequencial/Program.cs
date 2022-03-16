using System;
using System.Globalization;

namespace Aula_24._6___Ex._01_Estrutura_Sequencial {
    class Program {
        static void Main(string[] args) {
            
            double a, b, c, pi = 3.14159;
            double aTri, aCirc, aTrap, aQuad, aRetang;
            string[] dados;

            Console.WriteLine("------------ Calculando áreas ------------");
            Console.WriteLine("Digite o valor de A, B e C (mesma linha):");
            dados = Console.ReadLine().Split(' ');
            a = double.Parse(dados[0] , CultureInfo.InvariantCulture);
            b = double.Parse(dados[1] , CultureInfo.InvariantCulture);
            c = double.Parse(dados[2] , CultureInfo.InvariantCulture);

            // Cálculos
            aTri = (a * c) / 2; // (base * altura) / 2
            aCirc = pi * Math.Pow(c,2.00); // pi * (raio * raio)
            aTrap = ((a + b) * c) / 2.00; // ((BASE + base) * altura) / 2
            aQuad = Math.Pow(b, 2.00); // lado * lado
            aRetang = a * b; // base * altura

            // Resultados
            Console.WriteLine($"\n==== Áreas: ====\n " +
                $"Triangulo: {aTri.ToString("F3", CultureInfo.InvariantCulture)}\n " +
                $"Círculo: {aCirc.ToString("F3" , CultureInfo.InvariantCulture)}\n " +
                $"Trapezio: {aTrap.ToString("F3" , CultureInfo.InvariantCulture)}\n " +
                $"Quadrado: {aQuad.ToString("F3" , CultureInfo.InvariantCulture)}\n " +
                $"Retangulo: {aRetang.ToString("F3" , CultureInfo.InvariantCulture)}");

        }
    }
}
