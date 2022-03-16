using System;
using System.Globalization;

namespace _60._1___Construtores_This_Sobrecarga_Encapsulamento {
    class Program {
        static void Main(string[] args) {

            int numero;
            double depositoInicial;
            string nome;
            char resp;
            ContaBancaria c1;

            Console.Write("Insira o numero da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Insira o Titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Digite o valor do deposito inicial: R$ ");
                depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(numero, nome, depositoInicial);
            }
            else {
                c1 = new ContaBancaria(numero, nome);
            }

            Console.WriteLine($"\nDados da Conta:\n{c1}\n");

            Console.Write("Insira um valor para deposito: R$ ");
            c1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados: \n{c1}\n");

            Console.Write("Insira um valor para saque: R$ ");
            c1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados: \n{c1}\n");


        }
    }
}
