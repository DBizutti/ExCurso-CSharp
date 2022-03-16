namespace Aula_48._1___Membros_Estaticos {
    class ConversorDeMoeda {

        public static double Iof = 0.06;

        public static double Conversor(double cotacao , double usd) {
            double calc = cotacao * usd;
            return calc * Iof + calc;
        }

    }
}
