using System;

namespace Aula_29._7___Ex2___Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {

            string[] dados;
            double x, y;
            string ponto;

            Console.WriteLine("Digite o valor de X e Y");
            dados = Console.ReadLine().Split(' ');
            x = double.Parse(dados[0]);
            y = double.Parse(dados[1]);

            if (x == 0 && y == 0) {
                ponto = "na Origem";
            }
            else if (x >= 0 && y >= 0) {
                ponto = "no Q1";
            }
            else if (x <= 0 && y >= 0) {
                ponto = "no Q2";
            }
            else if (x <= 0 && y <= 0) {
                ponto = "no Q2";
            }
            else {
                ponto = "no Q4";
            }

            Console.WriteLine($"O ponto está {ponto}");

        }
    }
}
