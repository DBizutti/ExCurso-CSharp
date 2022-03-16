using System;

namespace Aula_35._6___Estrutura_For {
    class Program {
        static void Main(string[] args) {

            /*Ler um número inteiro N e calcular todos os seus divisores.*/

            int n;
            
            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {                    
                    Console.WriteLine(i);
                }
            }

        }
    }
}
