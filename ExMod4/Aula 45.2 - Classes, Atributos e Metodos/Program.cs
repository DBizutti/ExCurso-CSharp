using System;
using System.Globalization;

namespace Aula_45._2___Classes__Atributos_e_Metodos {
    class Program {
        static void Main(string[] args) {

            double aumento;
            Funcionario a = new Funcionario();

            Console.WriteLine("Digite os dados do Funcionario:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: R$ ");
            a.SalarioBruto = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("Imposto: R$ ");
            a.Imposto = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            Console.WriteLine("======================================");
            Console.WriteLine($"Funcionário: {a}");

            Console.Write("\nDigite a porcentagem para o aumento do salario: ");
            aumento = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            a.AumentoSalario(aumento);

            Console.WriteLine($"\nDados Atualizados: {a}");


        }
    }
}
