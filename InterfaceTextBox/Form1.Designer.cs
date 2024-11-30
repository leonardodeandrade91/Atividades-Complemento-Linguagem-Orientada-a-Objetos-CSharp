namespace InterfaceTextBox {
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
            this.txtEntr = new System.Windows.Forms.TextBox();
            this.btnCop = new System.Windows.Forms.Button();
            this.txtSaid = new System.Windows.Forms.TextBox();
            this.btnCol = new System.Windows.Forms.Button();
            this.btnMost = new System.Windows.Forms.Button();
            this.btnOcul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntr
            // 
            this.txtEntr.Location = new System.Drawing.Point(109, 55);
            this.txtEntr.Name = "txtEntr";
            this.txtEntr.Size = new System.Drawing.Size(259, 20);
            this.txtEntr.TabIndex = 0;
            this.txtEntr.Click += new System.EventHandler(this.txtEntr_Click);
            this.txtEntr.TextChanged += new System.EventHandler(this.txtEntr_TextChanged);
            this.txtEntr.MouseHover += new System.EventHandler(this.txtEntr_MouseHover);
            // 
            // btnCop
            // 
            this.btnCop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCop.Location = new System.Drawing.Point(109, 165);
            this.btnCop.Name = "btnCop";
            this.btnCop.Size = new System.Drawing.Size(123, 46);
            this.btnCop.TabIndex = 1;
            this.btnCop.Text = "Copiar";
            this.btnCop.UseVisualStyleBackColor = true;
            this.btnCop.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtSaid
            // 
            this.txtSaid.Location = new System.Drawing.Point(109, 110);
            this.txtSaid.Name = "txtSaid";
            this.txtSaid.Size = new System.Drawing.Size(259, 20);
            this.txtSaid.TabIndex = 2;
            // 
            // btnCol
            // 
            this.btnCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCol.Location = new System.Drawing.Point(238, 165);
            this.btnCol.Name = "btnCol";
            this.btnCol.Size = new System.Drawing.Size(130, 46);
            this.btnCol.TabIndex = 3;
            this.btnCol.Text = "Colar";
            this.btnCol.UseVisualStyleBackColor = true;
            this.btnCol.Click += new System.EventHandler(this.btnCol_Click);
            // 
            // btnMost
            // 
            this.btnMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMost.Location = new System.Drawing.Point(109, 227);
            this.btnMost.Name = "btnMost";
            this.btnMost.Size = new System.Drawing.Size(123, 32);
            this.btnMost.TabIndex = 4;
            this.btnMost.Text = "Mostrar";
            this.btnMost.UseVisualStyleBackColor = true;
            this.btnMost.Click += new System.EventHandler(this.btnMost_Click);
            // 
            // btnOcul
            // 
            this.btnOcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcul.Location = new System.Drawing.Point(238, 227);
            this.btnOcul.Name = "btnOcul";
            this.btnOcul.Size = new System.Drawing.Size(130, 32);
            this.btnOcul.TabIndex = 5;
            this.btnOcul.Text = "Ocultar";
            this.btnOcul.UseVisualStyleBackColor = true;
            this.btnOcul.Click += new System.EventHandler(this.btnOcul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 345);
            this.Controls.Add(this.btnOcul);
            this.Controls.Add(this.btnMost);
            this.Controls.Add(this.btnCol);
            this.Controls.Add(this.txtSaid);
            this.Controls.Add(this.btnCop);
            this.Controls.Add(this.txtEntr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntr;
        private System.Windows.Forms.Button btnCop;
        private System.Windows.Forms.TextBox txtSaid;
        private System.Windows.Forms.Button btnCol;
        private System.Windows.Forms.Button btnMost;
        private System.Windows.Forms.Button btnOcul;
    }
}

