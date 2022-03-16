using System.Globalization;

namespace Aula_45._3___Classes__Atributos_e_Metodos {
    class Aluno {
        public double Nota1, Nota2, Nota3;
        public string Nome;
        
        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Situacao() {
            double pontosRestantes;
            if (NotaFinal() >= 60.0) {
                return "APROVADO!";
            }
            else {
                pontosRestantes = 60.0 - NotaFinal();
                return $"REPROVADO! \nFaltaram: {pontosRestantes.ToString("F2" , CultureInfo.InvariantCulture)} pontos";
            }
        }

        public override string ToString() {
            return $"Nota Final: {NotaFinal().ToString("F2" , CultureInfo.InvariantCulture)} \nSituação: {Situacao()}";
        }

    }
}
