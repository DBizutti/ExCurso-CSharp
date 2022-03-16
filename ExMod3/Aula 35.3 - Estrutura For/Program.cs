using System;
using System.Globalization;

namespace Aula_35._3___Estrutura_For {
    class Program {
        static void Main(string[] args) {

            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.*/

            int n;
            string[] dados;
            double valor1, valor2, valor3, media;
           
            Console.Write("Digite quantos casos vai ser feitos: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine("Digite 3 numeros para calcular a media entre eles (mesma linha)");
                dados = Console.ReadLine().Split(' ');
                valor1 = double.Parse(dados[0] , CultureInfo.InvariantCulture);
                valor2 = double.Parse(dados[1] , CultureInfo.InvariantCulture);
                valor3 = double.Parse(dados[2] , CultureInfo.InvariantCulture);

                media = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;
                
                Console.WriteLine($"media: {media.ToString("F1" , CultureInfo.InvariantCulture)}");

            }
                        
        }
    }
}
