using System;

namespace Aula_40._1___Classes__Objetos_e_Atributos {
    class Program {
        static void Main(string[] args) {

            /* Fazer um programa para ler os dados (nome e idade) de duas pessoas, depois mostrar o nome da pessoa mais velha. */

            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Digite o 1º nome");
            a.Nome = Console.ReadLine();
            Console.WriteLine($"Digita a idade de {a.Nome}");
            a.Idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nDigite o 2º nome");
            b.Nome = Console.ReadLine();
            Console.WriteLine($"Digita a idade de {b.Nome}");
            b.Idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            if (a.Idade > b.Idade) {
                Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            }
            else {
                Console.WriteLine($"Pessoa mais velha: {b.Nome}");
            }

        }
    }
}
