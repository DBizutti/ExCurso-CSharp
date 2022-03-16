using System;
using System.Globalization;

namespace Aula_29._8___Ex2___Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {

            double renda, ir = 0;
            ir.ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor da renda:");
            renda = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            if (renda <= 2000.00) {
                ir = 0.0;
            }
            else if (renda <= 3000.00) {
                ir = (renda - 2000.0) * 0.08;
            }
            else if (renda <= 4500.00) {
                ir = (renda - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                ir = (renda - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            
            if(ir == 0.0) {
                Console.WriteLine($"Valor do Imposto de Renda é Isento neste caso");
            }
            else {
                Console.WriteLine($"Valor do Imposto de Renda: R$ {ir.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
