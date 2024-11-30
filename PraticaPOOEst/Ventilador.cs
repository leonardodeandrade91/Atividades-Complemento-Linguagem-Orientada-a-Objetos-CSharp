using System;

namespace PraticaPOOEst {
    class Ventilador {
        private static bool ligado = false;
        private static int velocidade = 0;

        public static void ligar(int vel) {
            ligado = true;

            if(vel < 1) {
                vel = 1;
            }
            else if(vel > 3) {
                vel = 3;
            }

            velocidade = vel;

            Console.WriteLine($"O ventilador está ligado, na velocidade de {velocidade}.");
        }

        public static void desligar() {
            velocidade = 0;
            ligado = false;

            Console.WriteLine("O ventilado está desligado!");
        }

        public static bool Ligado {
            get => ligado;
            set => ligado = value;
        }

        public static int Velocidade {
            get => velocidade;
            set => velocidade = value;
        }
    }
}
