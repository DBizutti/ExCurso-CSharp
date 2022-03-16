using System;
using System.Globalization;

namespace Aula_45._1___Classes__Atributos_e_Metodos {
    class Program {
        static void Main(string[] args) {

            Retangulo a = new Retangulo();

            Console.WriteLine("Informe os dados do Retangulo:");
            Console.Write("Altura: ");
            a.Altura = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            a.Largura = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            Console.WriteLine($"\n{a}");
        }
    }
}
