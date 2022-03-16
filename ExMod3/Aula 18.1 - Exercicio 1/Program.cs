using System;
using System.Globalization;

namespace Aula_18._1___Ex1 {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Meda de escritorio";

            sbyte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine($" Produtos: \n {produto1}, cujo preco é R$ {preco1:f2} \n {produto2}, cujo preco é R$ {preco2:f2}");
            Console.WriteLine($"\n Registro: {idade} anos de idade, código {codigo} e genero: {genero}\n");
            Console.WriteLine($" Media com 8 casas decimais: {media:f8}");
            Console.WriteLine($" Arredondado (tres casasdecimais): {media:f3}");
            Console.WriteLine($" Separador decimal invariant culture: {media.ToString("f3" , CultureInfo.InvariantCulture)}");
        }
    }
}
