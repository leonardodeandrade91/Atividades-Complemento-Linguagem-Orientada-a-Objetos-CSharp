using System;

namespace PraticaPOO2 {
    class Livro : Publicacao {
        private string titulo;
        private string autor;
        private int totPaginas;
        private int pagAtual;
        private bool aberto;
        private Pessoa leitor;

        public void detalhes() {
            Console.WriteLine($"Livro {this.titulo} escrito por {this.autor}.");

            if(this.aberto == true) {
                Console.WriteLine("O livro está aberto!");
                Console.WriteLine($"Páginas: {this.totPaginas}, página atual {this.pagAtual}.");
                Console.WriteLine($"Sendo lido por {this.leitor.Nome}.");
                Console.WriteLine($"De idade de {this.leitor.Idade} anos.");
                Console.WriteLine($"E de sexo {this.leitor.Sexo}.");
            }
            else {
                Console.WriteLine("O livro está fechado no momento!");
            }
        }

        public void abrir() {
            this.aberto = true;
        }

        public void fechar() {
            this.aberto = false;
        }

        public void folhear(int p) {
            if(this.Aberto == true) {
                if(p > this.totPaginas) {
                    this.PagAtual = this.TotPaginas;
                }
                else if(p < 0) {
                    this.PagAtual = 0;
                }
                else {
                    this.pagAtual = p;
                }
            }
        }

        public void avancarPag() {
            if(this.Aberto == true) {
                if(this.PagAtual < this.TotPaginas) {
                    this.PagAtual = this.PagAtual + 1;
                }
            }
        }

        public void voltarPag() {
            if(this.Aberto == true) {
                if(this.PagAtual > 0) {
                    this.PagAtual = this.PagAtual - 1;
                }
            }
        }

        public Livro(string titulo, string autor, int totPaginas, Pessoa leitor) {
            this.titulo = titulo;
            this.autor = autor;
            this.totPaginas = totPaginas;
            this.leitor = leitor;
            this.pagAtual = 0;
            this.aberto = false;
        }

        public string Titulo {
            get => this.titulo;
            set => this.titulo = value;
        }

        public string Autor {
            get => this.autor;
            set => this.autor = value;
        }

        public int TotPaginas {
            get => this.totPaginas;
            set => this.totPaginas = value;
        }

        public int PagAtual {
            get => this.pagAtual;
            set => this.pagAtual = value;
        }

        public bool Aberto  {
            get => this.aberto;
            set => this.aberto = value;
        }

        public Pessoa Leitor {
            get => this.leitor;
            set => this.leitor = value;
        }
    }
}
