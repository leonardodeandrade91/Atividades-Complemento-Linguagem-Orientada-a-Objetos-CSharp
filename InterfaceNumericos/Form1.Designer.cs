namespace InterfaceNumericos {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numEntr = new System.Windows.Forms.NumericUpDown();
            this.btnVerif = new System.Windows.Forms.Button();
            this.sliNum = new System.Windows.Forms.TrackBar();
            this.lblNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEntr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliNum)).BeginInit();
            this.SuspendLayout();
            // 
            // numEntr
            // 
            this.numEntr.Location = new System.Drawing.Point(141, 60);
            this.numEntr.Name = "numEntr";
            this.numEntr.Size = new System.Drawing.Size(120, 20);
            this.numEntr.TabIndex = 0;
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.Location = new System.Drawing.Point(141, 104);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(120, 34);
            this.btnVerif.TabIndex = 1;
            this.btnVerif.Text = "Clique Aqui";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // sliNum
            // 
            this.sliNum.Location = new System.Drawing.Point(71, 181);
            this.sliNum.Maximum = 50;
            this.sliNum.Name = "sliNum";
            this.sliNum.Size = new System.Drawing.Size(244, 45);
            this.sliNum.TabIndex = 2;
            this.sliNum.Scroll += new System.EventHandler(this.sliNum_Scroll);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(322, 181);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(19, 20);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 296);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.sliNum);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.numEntr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numEntr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numEntr;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.TrackBar sliNum;
        private System.Windows.Forms.Label lblNum;
    }
}

