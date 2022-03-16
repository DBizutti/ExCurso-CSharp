using System;
using System.Globalization;

namespace Aula_24._4___Ex._01_Estrutura_Sequencial {
    class Program {
        static void Main(string[] args) {

            int numFunc, horas;
            double valorHora, sal;

            Console.WriteLine("----- Calculando horas trabalhadas -----\n");
            Console.WriteLine("Digite o Número do Funcionário:");
            numFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quanto recebe por hora:");
            valorHora = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            sal = (double) valorHora * horas;

            Console.WriteLine($"\nNúmero Funcionário: {numFunc} \nSalário: {sal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
