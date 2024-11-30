namespace InterfaceListBox {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPreench = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.lstAnimais = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserir Animal:";
            // 
            // txtAddItem
            // 
            this.txtAddItem.Location = new System.Drawing.Point(199, 34);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(171, 20);
            this.txtAddItem.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPreench
            // 
            this.btnPreench.Location = new System.Drawing.Point(55, 245);
            this.btnPreench.Name = "btnPreench";
            this.btnPreench.Size = new System.Drawing.Size(104, 42);
            this.btnPreench.TabIndex = 3;
            this.btnPreench.Text = "Preencher Lista Automaticamente";
            this.btnPreench.UseVisualStyleBackColor = true;
            this.btnPreench.Click += new System.EventHandler(this.btnPreench_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(411, 101);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(102, 42);
            this.btnLimp.TabIndex = 4;
            this.btnLimp.Text = "Limpar Lista";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnRem
            // 
            this.btnRem.Location = new System.Drawing.Point(411, 172);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(102, 42);
            this.btnRem.TabIndex = 5;
            this.btnRem.Text = "Remover Selecionado";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(411, 245);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(102, 42);
            this.btnLer.TabIndex = 6;
            this.btnLer.Text = "Ler Item da Lista";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(411, 323);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(102, 42);
            this.btnClass.TabIndex = 7;
            this.btnClass.Text = "Classificar Lista";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // lstAnimais
            // 
            this.lstAnimais.FormattingEnabled = true;
            this.lstAnimais.Location = new System.Drawing.Point(199, 101);
            this.lstAnimais.Name = "lstAnimais";
            this.lstAnimais.Size = new System.Drawing.Size(171, 264);
            this.lstAnimais.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 400);
            this.Controls.Add(this.lstAnimais);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnPreench);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPreench;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.ListBox lstAnimais;
    }
}

