using System;

namespace POOTiposGenericos {
    class Program {
        static void Main(string[] args) {
            Generico<string> texto = new Generico<string>();

            texto.Entidade = "Exemplo de String!";

            Console.WriteLine(texto.Entidade);

            Generico<int> numero = new Generico<int>();

            numero.Entidade = 50;

            Console.WriteLine(numero.Entidade);

            Console.Read();
        }
    }
}
