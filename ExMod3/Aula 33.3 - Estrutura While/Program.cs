using System;

namespace Aula_33._3___Estrutura_While {
    class Program {
        static void Main(string[] args) {

            int op, alcool = 0, gasolina = 0, diesel = 0;

            Console.WriteLine("======== TABELA ========");
            Console.WriteLine(" 1. Álcool\n 2. Gasolina\n 3. Diesel\n 4. Fim");
            Console.WriteLine("========================\n");

            Console.Write("Digite uma opção: ");
            op = int.Parse(Console.ReadLine());

            while (op != 4) {
                
                if (op < 1 || op > 4) {
                    Console.WriteLine("Opção invalida!! Tente novamente");
                }

                if (op == 1) {
                    alcool += 1;
                }
                else if (op == 2) {
                    gasolina += 1;
                }
                else if (op == 3) {
                    diesel += 1;
                }

                Console.Write("Digite uma opção: ");
                op = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\n-------------------------------\n");
            Console.WriteLine(" Muito Obrigado!!");
            Console.WriteLine($" Alcool: {alcool}\n Gasolina: {gasolina}\n Diesel: {diesel}");

        }
    }
}
