using System;
using System.Globalization;

namespace _60._1___Construtores_This_Sobrecarga_Encapsulamento {
    class ContaBancaria {

        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public int NumeroConta { get; private set; }

        public ContaBancaria(int numeroConta, string nome) {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = 0.00;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome){
            Deposito(depositoInicial);
        }

        public void Deposito(double x) {
            Saldo += x;
        }

        public void Saque(double x) {
            Saldo -= x + 5.00;
        }

        public override string ToString() {
            return $"Conta: {NumeroConta}, " +
                $"Titular: {Nome}, " +
                $"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
