using System;
using System.Globalization;

namespace Aula_29._5__Ex2___Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {
            
            string[] dados;
            string[] espec;
            double[] preco;
            double tot;
            int cod, qtd;


            espec = new string[] { "Cachorro Quente" , "X-Salada" , "X-Bacon" , "Torrada Simples" , "Refrigerante" };
            preco = new double[] { 4.00 , 4.50 , 5.00 , 2.00 , 1.50 };

            Console.WriteLine("Digite o código e a quantidade:");
            dados = Console.ReadLine().Split(' ');

            cod = int.Parse(dados[0]);
            qtd = int.Parse(dados[1]);
            tot = preco[cod-1] * qtd;

            Console.WriteLine($"\nPedido:\n Codigo: {cod}\n Especificação: {espec[cod - 1]}\n Preço: {preco[cod-1].ToString("F2", CultureInfo.InvariantCulture)}\n Quantidade: {qtd}\n Total: {tot.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
