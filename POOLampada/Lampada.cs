using System;

namespace POOLampada {
    class Lampada {
        private static float preco = 9.50f;
        private static bool acesa = false;

        public static void custo() {
            Console.WriteLine("A lâmpada custa R${0:0.00}.", preco);
        }

        public static void acender() {
            Console.WriteLine("A lâmpada está acesa!");
            acesa = true;
        }

        public static void apagar() {
            Console.WriteLine("A lâmpada está apagada!");
            acesa = false;
        }
    }
}
