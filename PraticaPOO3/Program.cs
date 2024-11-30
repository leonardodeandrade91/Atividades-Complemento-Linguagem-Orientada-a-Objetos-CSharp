using System;
using System.Collections.Generic;

namespace PraticaPOO3 {
    internal class Program {
        static void Main(string[] args) {
            List<Video> v = new List<Video>();

            v.Add(new Video("Aula 1 de POO"));
            v.Add(new Video("Aula 12 de C#"));
            v.Add(new Video("Aula 15 de HTML5"));

            List<Gafanhoto> g = new List<Gafanhoto>();

            g.Add(new Gafanhoto("Jubileu", 22, "M", "Jubi"));
            g.Add(new Gafanhoto("Creuza", 12, "F", "Creuzita"));

            List<Visualizacao> vis = new List<Visualizacao>();

            vis.Add(new Visualizacao(g[0], v[2]));

            Console.WriteLine(vis[0].ToString());

            vis.Add(new Visualizacao(g[0], v[1]));

            Console.WriteLine(vis[1].ToString());

            vis[0].avaliar();
            vis[1].avaliar(85.0f);

            Console.WriteLine(vis[0].ToString());
            Console.WriteLine(vis[1].ToString());

            Console.Read();
        }
    }
}
