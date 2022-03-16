using System;
using System.Globalization;

namespace Aula_40._2___Classes__Objetos_e_Atributos {
    class Program {
        static void Main(string[] args) {
            /* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.*/

            Funcionario a, b;
            double media;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro Funcionario:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            a.Salario = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            
            Console.WriteLine("\nDigite os dados do segundo Funcionario:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            b.Salario = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            media = (a.Salario + b.Salario) / 2.0;

            Console.WriteLine($"\nSalario médio: {media.ToString("F2" , CultureInfo.InvariantCulture)}");

        }
    }
}
