using System;
using System.Globalization;

namespace Aula_45._1___Classes__Atributos_e_Metodos {
    class Retangulo {
        public double Altura, Largura;

        public double Area() {
            return Altura * Largura;
        }

        public double Perimetro() {
            return (Altura + Largura) * 2;
        }

        public double Diagonal() {
            // a^2 = b^2 + c^2
            return Math.Sqrt(Math.Pow(Altura , 2.0) + Math.Pow(Largura , 2.0));
        }

        public override string ToString() {
            return $"Área: {Area().ToString("F2" , CultureInfo.InvariantCulture)}" +
                $"\nPerímetro: {Perimetro().ToString("F2" , CultureInfo.InvariantCulture)}" +
                $"\nDiagonal: {Diagonal().ToString("F2" , CultureInfo.InvariantCulture)}";
        }

    }
}
