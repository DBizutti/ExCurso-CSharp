using System;

namespace Aula_24._3___Ex._01_Estrutura_Sequencial {
    class Program {
        static void Main(string[] args) {
            
            int a, b, c, d, dif;

            Console.WriteLine("Calculando a diferenca entre 2 produtos");
            Console.WriteLine("Formula: A * B - C * D\n");
            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D:");
            d = int.Parse(Console.ReadLine());

            dif = (a * b) - (c * d);

            Console.WriteLine($"\nA diferenca é igual a: {dif}");

        }
    }
}
