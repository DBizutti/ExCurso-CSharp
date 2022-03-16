using System;

namespace Aula_29._2___Ex2___Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {

            int x;

            Console.WriteLine("Digite Um número inteiro:");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Par!");
            }
            else {
                Console.WriteLine("Impar!");
            }

        }
    }
}
