using System;
using System.Globalization;

namespace Aula_24._5___Ex._01_Estrutura_Sequencial {
    class Program {
        static void Main(string[] args) {

            int cod1, cod2, qtd1, qtd2;
            double valUn1, valUn2, tot;
            string[] dadosVet;
            
            Console.WriteLine("Digite o codigo da peca 01, quantidade e valor unitário (Mesma linha)");
            dadosVet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(dadosVet[0]);
            qtd1 = int.Parse(dadosVet[1]);
            valUn1 = double.Parse(dadosVet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo da peca 02, quantidade e valor unitário (Mesma linha)");
            dadosVet = Console.ReadLine().Split(' ');
            cod2 = int.Parse(dadosVet[0]);
            qtd2 = int.Parse(dadosVet[1]);
            valUn2 = double.Parse(dadosVet[2], CultureInfo.InvariantCulture);

            tot = (qtd1 * valUn1) + (qtd2 * valUn2);

            Console.WriteLine("\n ===== Resumo: =====");
            Console.WriteLine($" Produto 01:\n Cod.: {cod1}\n Quantidade: {qtd1}\n Valor Unit.: {valUn1.ToString("F2", CultureInfo.InvariantCulture)}\n");
            Console.WriteLine($" Produto 02:\n Cod.: {cod2}\n Quantidade: {qtd2}\n Valor Unit.: {valUn2.ToString("F2", CultureInfo.InvariantCulture)}\n");
            Console.WriteLine($" Valor a ser pago: R$ {tot.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
