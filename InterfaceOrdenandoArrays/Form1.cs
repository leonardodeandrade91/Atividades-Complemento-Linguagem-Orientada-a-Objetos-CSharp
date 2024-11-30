using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceOrdenandoArrays {
    public partial class Form1 : Form {
        int[] x = {2, 1, 8, 7, 5, 9, 15, 3, 6};
        int[] y = {4, 2, 9, 7, 6, 18, 11, 4, 8};

        public void bubblesort(int[] n) {
            for(int i = 1; i < n.Length; i++) {
                for(int j = 0; j < n.Length - 1; j++) {
                    if(n[j] > n[j + 1]) {
                        troca(n, j);
                    }
                }
            }
        }

        public void troca(int[] g, int p) {
            int aux;
            aux = g[p];
            g[p] = g[p + 1];
            g[p + 1] = aux;
        }
        
        public Form1() {
            InitializeComponent();
        }

        private void btnCrArr_Click(object sender, EventArgs e) {
            lblArr1N.Text = "Itens do array na ordem original:\n";

            for(int i = 0; i < x.Length; i++) {
                lblArr1N.Text += " " + x[i];
            }

            lblArr2N.Text = "Itens do array na ordem original:\n";

            for(int i = 0; i < y.Length; i++) {
                lblArr2N.Text += " " + y[i];
            }
        }

        private void btnOrdArr_Click(object sender, EventArgs e) {
            bubblesort(x);

            lblArr1O.Text = "Itens do array ordenados:\n";

            for(int i = 0; i < x.Length; i++) {
                lblArr1O.Text += " " + x[i];
            }
        }

        private void btnOrdSort_Click(object sender, EventArgs e) {
            Array.Sort(y);

            lblArr2O.Text = "Itens do array ordenados:\n";

            foreach(int item in y) {
                lblArr2O.Text += " " + item.ToString();
            }
        }
    }
}
