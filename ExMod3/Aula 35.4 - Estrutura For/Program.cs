using System;
using System.Globalization;

namespace Aula_35._4___Estrutura_For {
    class Program {
        static void Main(string[] args) {

            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/

            int n;
            double n1, n2, div;
            string[] dados;

            Console.Write("Digite A quatidade de pares: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write($"Digite o {i}º par: ");
                dados = Console.ReadLine().Split(' ');
                n1 = double.Parse(dados[0] , CultureInfo.InvariantCulture);
                n2 = double.Parse(dados[1] , CultureInfo.InvariantCulture);

                if (n2 == 0) {
                    Console.WriteLine("Divisão Impossível\n");
                }
                else {
                    div = (double) n1 / n2;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture) + "\n");
                }

            }

        }
    }
}
