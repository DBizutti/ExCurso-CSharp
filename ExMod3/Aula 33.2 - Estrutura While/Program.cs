using System;

namespace Aula_33._2___Estrutura_While {
    class Program {
        static void Main(string[] args) {

            string[] dados;
            double x, y;
            string resultado;
            bool verif;

            Console.WriteLine("Digite uma coordenada (X e Y):");
            dados = Console.ReadLine().Split(' ');
            x = double.Parse(dados[0]);
            y = double.Parse(dados[1]);

            verif = x == 0 || y == 0;

            while(verif == false) {
                resultado = Quadrante(x , y);
                Console.WriteLine(resultado);
                Console.WriteLine("Digite outra coordenada (X e Y):");
                dados = Console.ReadLine().Split(' ');
                x = double.Parse(dados[0]);
                y = double.Parse(dados[1]);
                verif = x == 0 || y == 0;
            }

        }

        static string Quadrante(double a , double b) {

            if (a == 0 && b == 0) {
                return "Origem";
            }
            else if (a >= 0 && b >= 0) {
                return "Primeiro";
            }
            else if (a < 0 && b >= 0) {
                return "Segundo";
            }
            else if (a <= 0 && b <= 0) {
                return "Terceiro";
            }
            else {
                return "Quarto";
            }

        }
    }
}
