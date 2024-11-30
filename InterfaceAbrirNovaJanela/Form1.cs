using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace InterfaceAbrirNovaJanela {
    public partial class Form1 : Form {
        Thread t1;

        private void abrirJanela(object obj) {
            Application.Run(new NovaJanela());
        }
        

        public Form1() {
            InitializeComponent();
        }

        private void btnAbr_Click(object sender, EventArgs e) {
            this.Close();

            t1 = new Thread(abrirJanela);

            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
