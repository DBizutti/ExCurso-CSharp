using System;

namespace Aula_29._1___Ex2___Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {

            int x;

            Console.WriteLine("Digite um número inteiro:");
            x = int.Parse(Console.ReadLine());

            if (x < 0) {
                Console.WriteLine("NEGATIVO!");
            }
            else {
                Console.WriteLine("POSITIVO!");
            }


        }
    }
}
