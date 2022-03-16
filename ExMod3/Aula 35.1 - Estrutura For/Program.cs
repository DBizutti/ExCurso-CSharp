using System;

namespace Aula_35._1___Estrutura_For {
    class Program {
        static void Main(string[] args) {

            int x;

            Console.Write("Digite um valor: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {

                if (x >= 1 && x < 1000) {

                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }

                }
                else {
                    Console.WriteLine("Erro!! Numero nao suportado, digite outro numero, por favor");
                    Console.Write("Digite um valor: ");
                    x = int.Parse(Console.ReadLine());

                }

            }


        }
    }
}
