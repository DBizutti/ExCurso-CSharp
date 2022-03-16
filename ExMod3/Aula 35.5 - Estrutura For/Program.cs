using System;

namespace Aula_35._5___Estrutura_For {
    class Program {
        static void Main(string[] args) {

            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.*/

            int n, fatorial = 1;
            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++) {
                    fatorial *= i;  
                }

            Console.WriteLine(fatorial);
        }
    }
}
