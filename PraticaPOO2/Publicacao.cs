using System;

namespace PraticaPOO2 {
    interface Publicacao {
        void detalhes();
        void abrir();
        void fechar();
        void folhear(int p);
        void avancarPag();
        void voltarPag();
    }
}
