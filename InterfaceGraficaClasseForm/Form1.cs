using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceGraficaClasseForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            MessageBox.Show("Evento Load Disparado!");
        }

        private void Form1_Click(object sender, EventArgs e) {
            Janela2 tela = new Janela2();

            tela.Show();
        }
    }
}
