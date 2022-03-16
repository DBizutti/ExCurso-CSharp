using System;

namespace Aula_33._1___Estrutura_While {
    class Program {
        static void Main(string[] args) {

            int senha = 2002, confereSenha;

            Console.Write("Digite a senha: ");
            confereSenha = int.Parse(Console.ReadLine());

            if (confereSenha != senha) {
                while (confereSenha != senha) {
                    Console.Write("Senha Invalida \nDigite a senha novamente:");
                    confereSenha = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
