using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceGraficaButton {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e) {
            MessageBox.Show("Habilitando o Botão 2!");
            btnSeg.Enabled = true;
        }

        private void btnSeg_Click(object sender, EventArgs e) {
            MessageBox.Show("O Botão foi Habilitado!");
        }
    }
}
