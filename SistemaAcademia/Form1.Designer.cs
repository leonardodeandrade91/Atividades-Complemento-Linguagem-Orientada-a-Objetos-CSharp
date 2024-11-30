namespace SistemaAcademia {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAcs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgLed = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itEntr = new System.Windows.Forms.ToolStripMenuItem();
            this.itSair = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itBanc = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itNovUser = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestUser = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itNovAul = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAcs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgLed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(519, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(16, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
            // 
            // lblAcs
            // 
            this.lblAcs.AutoSize = true;
            this.lblAcs.Location = new System.Drawing.Point(422, 13);
            this.lblAcs.Name = "lblAcs";
            this.lblAcs.Size = new System.Drawing.Size(13, 13);
            this.lblAcs.TabIndex = 2;
            this.lblAcs.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            // 
            // imgLed
            // 
            this.imgLed.Image = ((System.Drawing.Image)(resources.GetObject("imgLed.Image")));
            this.imgLed.Location = new System.Drawing.Point(626, 13);
            this.imgLed.Name = "imgLed";
            this.imgLed.Size = new System.Drawing.Size(15, 15);
            this.imgLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLed.TabIndex = 0;
            this.imgLed.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.alunosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itEntr,
            this.itSair});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // itEntr
            // 
            this.itEntr.Name = "itEntr";
            this.itEntr.Size = new System.Drawing.Size(180, 22);
            this.itEntr.Text = "Entrar";
            this.itEntr.Click += new System.EventHandler(this.itEntr_Click);
            // 
            // itSair
            // 
            this.itSair.Name = "itSair";
            this.itSair.Size = new System.Drawing.Size(180, 22);
            this.itSair.Text = "Sair";
            this.itSair.Click += new System.EventHandler(this.itSair_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itBanc});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // itBanc
            // 
            this.itBanc.Name = "itBanc";
            this.itBanc.Size = new System.Drawing.Size(180, 22);
            this.itBanc.Text = "Banco de Dados";
            this.itBanc.Click += new System.EventHandler(this.itBanc_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNovUser,
            this.itGestUser});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // itNovUser
            // 
            this.itNovUser.Name = "itNovUser";
            this.itNovUser.Size = new System.Drawing.Size(180, 22);
            this.itNovUser.Text = "Novo Usuário";
            this.itNovUser.Click += new System.EventHandler(this.itNovUser_Click);
            // 
            // itGestUser
            // 
            this.itGestUser.Name = "itGestUser";
            this.itGestUser.Size = new System.Drawing.Size(180, 22);
            this.itGestUser.Text = "Gestão de Usuários";
            this.itGestUser.Click += new System.EventHandler(this.itGestUser_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNovAul});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // itNovAul
            // 
            this.itNovAul.Name = "itNovAul";
            this.itNovAul.Size = new System.Drawing.Size(180, 22);
            this.itNovAul.Text = "Novo Aluno";
            this.itNovAul.Click += new System.EventHandler(this.itNovAul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblAcs;
        public System.Windows.Forms.PictureBox imgLed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itEntr;
        private System.Windows.Forms.ToolStripMenuItem itSair;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itBanc;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itNovUser;
        private System.Windows.Forms.ToolStripMenuItem itGestUser;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itNovAul;
    }
}

