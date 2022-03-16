using System;
using System.Globalization;

namespace Aula_45._3___Classes__Atributos_e_Metodos {
    class Program {
        static void Main(string[] args) {

            Aluno a = new Aluno();

            Console.WriteLine("Informe os dados do aluno:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Nota 1o trimestre: ");
            a.Nota1 = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("Nota 2o trimestre: ");
            a.Nota2 = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("Nota 3o trimestre: ");
            a.Nota3 = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            Console.WriteLine("==========================");
            Console.WriteLine(a);

        }
    }
}
