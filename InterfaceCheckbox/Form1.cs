using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceCheckbox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e) {
            string saida = "";

            if(cxJav.Checked) {
                saida += "Java\n";
            }

            if(cxCpp.Checked) {
                saida += "C++\n";
            }

            if(cxCs.Checked) {
                saida += "C#\n";
            }

            MessageBox.Show("Linguagens marcadas:\n\n" + saida, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            saida = "";
        }
    }
}
