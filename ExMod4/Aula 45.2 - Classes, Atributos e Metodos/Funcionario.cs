using System.Globalization;

namespace Aula_45._2___Classes__Atributos_e_Metodos {
    class Funcionario {
        public string Nome;
        public double SalarioBruto, Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double porcentagem) {
            SalarioBruto = (SalarioBruto * porcentagem / 100.0) + SalarioBruto;
        }

        public override string ToString() {
            return $"Nome: {Nome}, R$ {SalarioLiquido().ToString("F2" , CultureInfo.InvariantCulture)}";
        }

    }
}
