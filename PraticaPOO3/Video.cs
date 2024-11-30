using System;

namespace PraticaPOO3 {
    class Video : AcoesVideo {
        private string titulo;
        private int avaliacao;
        private int views;
        private int curtidas;
        private bool reproduzindo;
        
        public void play() {
            this.reproduzindo = true;
        }
        
        public void pause() {
            this.reproduzindo = false;
        }

        public void like() {
            this.curtidas++;
        }

        public override string ToString() {
            return "Video:\nTitulo = " + titulo + "\nAvaliacao = " + avaliacao + "\nViews = " + views + "\nCurtidas = " + curtidas + "\nReproduzindo = " + reproduzindo;
        }

        public Video(string titulo) {
            this.titulo = titulo;
            this.avaliacao = 1;
            this.views = 0;
            this.curtidas = 0;
            this.reproduzindo = false;
        }

        public string Titulo {
            get => this.titulo;
            set => this.titulo = value;
        }

        public int Avaliacao {
            get => this.avaliacao;
            set {
                int media;
                media = (int)(this.avaliacao + value) / this.views;
                this.avaliacao = media;
            }
        }

        public int Views {
            get => this.views;
            set => this.views = value;
        }

        public int Curtidas {
            get => this.curtidas;
            set => this.curtidas = value;
        }

        public bool Reproduzindo {
            get => this.reproduzindo;
            set => this.reproduzindo = value;
        }
    }
}
