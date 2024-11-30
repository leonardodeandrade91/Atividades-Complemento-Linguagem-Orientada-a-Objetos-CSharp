using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLendoEEscrevendo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnEscr_Click(object sender, EventArgs e) {
            string texto = txtEntr.Text.Trim();

            try {
                StreamWriter arq = new StreamWriter("arquivo.txt", true, Encoding.UTF8);

                arq.WriteLine(texto);

                MessageBox.Show("O texto foi inserido no arquivo com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                arq.Close();
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLer_Click(object sender, EventArgs e) {
            string texto;
            string saida = "";

            try {
                StreamReader arq = new StreamReader("arquivo.txt");

                texto = arq.ReadLine();

                while(texto != null) {
                    saida += texto + Environment.NewLine;
                    texto = arq.ReadLine();
                }

                txtSaid.Text = saida;

                arq.Close();
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
