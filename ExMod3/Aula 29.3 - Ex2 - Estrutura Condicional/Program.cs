using System;

namespace Aula_29._3___Ex2___Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {

            int a, b;
            string[] dados;

            Console.WriteLine("Digite dois valores inteiros (mesma linha):");
            dados = Console.ReadLine().Split(' ');

            a = int.Parse(dados[0]);
            b = int.Parse(dados[1]);

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Multiplos");
            }
            else {
                Console.WriteLine("Não Multiplos");
            }

        }
    }
}
