using System;

namespace Aula_24._1___Ex._01_Estrutura_Sequencial {
    class Program {
        static void Main(string[] args) {
            
            int a, b, s;

            Console.WriteLine("---- Soma Entre dois números inteiros: ----\n");
            Console.WriteLine("Digite o 1º número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º numero:");
            b = int.Parse(Console.ReadLine());

            s = a + b;
                
            Console.WriteLine($"\nA soma entre {a} e {b} é igual a: {s}");

        }
    }
}
