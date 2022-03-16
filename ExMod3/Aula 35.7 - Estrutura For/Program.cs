using System;

namespace Aula_35._7___Estrutura_For {
    class Program {
        static void Main(string[] args) {

            /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor*/

            int n;
            double q, c;

            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                q = Math.Pow(i , 2.0);
                c = Math.Pow(i , 3.0);

                Console.WriteLine($"{i} {q} {c}");
            }

        }
    }
}
