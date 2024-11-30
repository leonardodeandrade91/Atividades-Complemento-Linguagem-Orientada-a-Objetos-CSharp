namespace InterfaceCheckbox {
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
            this.cxJav = new System.Windows.Forms.CheckBox();
            this.cxCpp = new System.Windows.Forms.CheckBox();
            this.cxCs = new System.Windows.Forms.CheckBox();
            this.btnVerif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cxJav
            // 
            this.cxJav.AutoSize = true;
            this.cxJav.Location = new System.Drawing.Point(158, 51);
            this.cxJav.Name = "cxJav";
            this.cxJav.Size = new System.Drawing.Size(49, 17);
            this.cxJav.TabIndex = 0;
            this.cxJav.Text = "Java";
            this.cxJav.UseVisualStyleBackColor = true;
            // 
            // cxCpp
            // 
            this.cxCpp.AutoSize = true;
            this.cxCpp.Location = new System.Drawing.Point(158, 87);
            this.cxCpp.Name = "cxCpp";
            this.cxCpp.Size = new System.Drawing.Size(45, 17);
            this.cxCpp.TabIndex = 1;
            this.cxCpp.Text = "C++";
            this.cxCpp.UseVisualStyleBackColor = true;
            // 
            // cxCs
            // 
            this.cxCs.AutoSize = true;
            this.cxCs.Location = new System.Drawing.Point(158, 121);
            this.cxCs.Name = "cxCs";
            this.cxCs.Size = new System.Drawing.Size(40, 17);
            this.cxCs.TabIndex = 2;
            this.cxCs.Text = "C#";
            this.cxCs.UseVisualStyleBackColor = true;
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.Location = new System.Drawing.Point(109, 176);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(143, 36);
            this.btnVerif.TabIndex = 3;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 272);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.cxCs);
            this.Controls.Add(this.cxCpp);
            this.Controls.Add(this.cxJav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cxJav;
        private System.Windows.Forms.CheckBox cxCpp;
        private System.Windows.Forms.CheckBox cxCs;
        private System.Windows.Forms.Button btnVerif;
    }
}

