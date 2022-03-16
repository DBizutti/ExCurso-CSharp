using System;

namespace Aula_29._4___Ex2___Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {

            int horaInicio, horaFim, duracao;
            string[] dados;

            Console.WriteLine("Digite a hora inicial e a hora final:");
            dados = Console.ReadLine().Split(' ');
            horaInicio = int.Parse(dados[0]);
            horaFim = int.Parse(dados[1]);

            if(horaInicio < horaFim) {
                duracao = horaFim - horaInicio;
            }
            else {
                duracao = 24 - horaInicio + horaFim;
            }

            Console.WriteLine($"O jogo teve a duraçao de {duracao} hora(s)");

        }
    }
}
