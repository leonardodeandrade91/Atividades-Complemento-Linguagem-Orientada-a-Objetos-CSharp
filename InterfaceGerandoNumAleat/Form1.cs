using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceGerandoNumAleat {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnGer_Click(object sender, EventArgs e) {
            Random numAle = new Random();

            int valInt = numAle.Next();
            double valDem = numAle.NextDouble();

            lblInt.Text = valInt.ToString();
            lblDem.Text = valDem.ToString();
        }
    }
}
