using System;

namespace Aula_35._2___Estrutura_For {
    class Program {
        static void Main(string[] args) {

            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/

            int n, x, foraIntervalo, intervalo = 0;

            Console.Write("Digite a quantidade de numeros à digitar: ");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) {

                Console.Write($"Digite o {i}º número: ");
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) {
                    intervalo += 1;
                }

            }

            foraIntervalo = n - intervalo;
            Console.WriteLine("\n======================================\n");
            Console.WriteLine($" {intervalo} in\n {foraIntervalo} out");            

        }
    }
}
