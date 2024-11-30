using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceNumericos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e) {
            int num = (int)numEntr.Value;

            int dobro = num * 2;

            MessageBox.Show("O dobro de " + num + " é " + dobro + ".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sliNum_Scroll(object sender, EventArgs e) {
            lblNum.Text = sliNum.Value.ToString();
        }
    }
}
