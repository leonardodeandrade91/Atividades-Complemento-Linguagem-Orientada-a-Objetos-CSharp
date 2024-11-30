using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTextBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e) {
            txtEntr.Copy();
        }

        private void txtEntr_TextChanged(object sender, EventArgs e) {
            
        }

        private void txtEntr_Click(object sender, EventArgs e) {
            
        }

        private void txtEntr_MouseHover(object sender, EventArgs e) {

        }

        private void btnCol_Click(object sender, EventArgs e) {
            txtSaid.Paste();
        }

        private void btnMost_Click(object sender, EventArgs e) {
            txtSaid.Show();
        }

        private void btnOcul_Click(object sender, EventArgs e) {
            txtSaid.Hide();
        }
    }
}
