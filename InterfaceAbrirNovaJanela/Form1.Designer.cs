namespace InterfaceAbrirNovaJanela {
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
            this.btnAbr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbr
            // 
            this.btnAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbr.Location = new System.Drawing.Point(82, 95);
            this.btnAbr.Name = "btnAbr";
            this.btnAbr.Size = new System.Drawing.Size(205, 79);
            this.btnAbr.TabIndex = 0;
            this.btnAbr.Text = "Abrir Janela";
            this.btnAbr.UseVisualStyleBackColor = true;
            this.btnAbr.Click += new System.EventHandler(this.btnAbr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 269);
            this.Controls.Add(this.btnAbr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbr;
    }
}

