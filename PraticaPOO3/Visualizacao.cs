using System;

namespace PraticaPOO3 {
    class Visualizacao {
        private Gafanhoto espectador;
        private Video filme;

        public void avaliar() {
            this.filme.Avaliacao = 5;
        }

        public void avaliar(int nota) {
            this.filme.Avaliacao = nota;
        }

        public void avaliar(float porc) {
            int nova = 0;

            if(porc <= 20) {
                nova = 3;
            }
            else if(porc > 20 && porc <= 50) {
                nova = 5;
            }
            else if(porc > 50 && porc <= 90) {
                nova = 8;
            }
            else {
                nova = 10;
            }

            this.filme.Avaliacao = nova;
        }

        public override string ToString() {
            return "Visualização:\nEspectador = " + espectador.ToString() + "\nFilme = " + filme.ToString() + "\n";
        }

        public Visualizacao(Gafanhoto espectador, Video filme) {
            this.espectador = espectador;
            this.filme = filme;
            this.filme.Views = this.filme.Views + 1;
            this.espectador.TotAssistido = this.espectador.TotAssistido + 1;
        }

        public Gafanhoto Espectador {
            get => this.espectador;
            set => this.espectador = value;
        }

        public Video Filme {
            get => this.filme;
            set => this.filme = value;
        }
    }
}
