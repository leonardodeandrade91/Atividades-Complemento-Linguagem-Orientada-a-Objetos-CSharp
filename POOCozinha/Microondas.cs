using System;

namespace POOCozinha {
    class Microondas {
        public void ligar(int minuto, int segundo) {
            if(minuto > 0 || segundo > 0) {
                Console.WriteLine("A comida estará pronta em {0}:{1:00}M.", minuto, segundo);
            }
            else {
                Console.WriteLine("Escolha um tempo maior que 0:00.");
            }
        }

        public void ligar(string alimento) {
            if(alimento.ToLower().Equals("pipoca")) {
                Console.WriteLine("Vamos estourar pipoca!");
            }
            else if(alimento.ToLower().Equals("bolo de caneca")) {
                Console.WriteLine("Vamos fazer bolo de caneca!");
            }
            else {
                Console.WriteLine("ERRO! Alimento desconhecido!");
            }
        }

        public void ligar(bool descongelar) {
            if(descongelar) {
                Console.WriteLine("Vamos descongelar o alimento!");
            }
            else {
                Console.WriteLine("ERRO! Não poderei descongelar o alimento!");
            }
        }
    }
}
