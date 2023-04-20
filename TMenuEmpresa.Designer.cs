namespace JobStack
{
    partial class TMenuEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fundoMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBarraeLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoAbreMenu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoNotificacoes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.botaoChat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botaoVagas = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.botaoPerfil = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.botaoLogout = new System.Windows.Forms.Button();
            this.fundoMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.botaoMinimizar = new System.Windows.Forms.PictureBox();
            this.botaoFechar = new System.Windows.Forms.PictureBox();
            this.fundoMenu.SuspendLayout();
            this.panelBarraeLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoAbreMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // fundoMenu
            // 
            this.fundoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.fundoMenu.Controls.Add(this.panelBarraeLogo);
            this.fundoMenu.Controls.Add(this.panel1);
            this.fundoMenu.Controls.Add(this.panel3);
            this.fundoMenu.Controls.Add(this.panel4);
            this.fundoMenu.Controls.Add(this.panel7);
            this.fundoMenu.Controls.Add(this.panel11);
            this.fundoMenu.Controls.Add(this.panel13);
            this.fundoMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.fundoMenu.Location = new System.Drawing.Point(0, 0);
            this.fundoMenu.MaximumSize = new System.Drawing.Size(250, 729);
            this.fundoMenu.MinimumSize = new System.Drawing.Size(77, 729);
            this.fundoMenu.Name = "fundoMenu";
            this.fundoMenu.Size = new System.Drawing.Size(250, 729);
            this.fundoMenu.TabIndex = 26;
            // 
            // panelBarraeLogo
            // 
            this.panelBarraeLogo.Controls.Add(this.pictureBox1);
            this.panelBarraeLogo.Controls.Add(this.botaoAbreMenu);
            this.panelBarraeLogo.Location = new System.Drawing.Point(3, 3);
            this.panelBarraeLogo.Name = "panelBarraeLogo";
            this.panelBarraeLogo.Size = new System.Drawing.Size(247, 126);
            this.panelBarraeLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobStack.Properties.Resources.logo_versao_3_ajustada;
            this.pictureBox1.Location = new System.Drawing.Point(16, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // botaoAbreMenu
            // 
            this.botaoAbreMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAbreMenu.Image = global::JobStack.Properties.Resources.icon_abremenu;
            this.botaoAbreMenu.Location = new System.Drawing.Point(19, 23);
            this.botaoAbreMenu.Name = "botaoAbreMenu";
            this.botaoAbreMenu.Size = new System.Drawing.Size(46, 39);
            this.botaoAbreMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botaoAbreMenu.TabIndex = 0;
            this.botaoAbreMenu.TabStop = false;
            this.botaoAbreMenu.Click += new System.EventHandler(this.botaoAbreMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoNotificacoes);
            this.panel1.Location = new System.Drawing.Point(3, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 60);
            this.panel1.TabIndex = 1;
            // 
            // botaoNotificacoes
            // 
            this.botaoNotificacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoNotificacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoNotificacoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNotificacoes.ForeColor = System.Drawing.Color.White;
            this.botaoNotificacoes.Image = global::JobStack.Properties.Resources.icone_notificacoes2;
            this.botaoNotificacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoNotificacoes.Location = new System.Drawing.Point(-13, -10);
            this.botaoNotificacoes.Name = "botaoNotificacoes";
            this.botaoNotificacoes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.botaoNotificacoes.Size = new System.Drawing.Size(269, 80);
            this.botaoNotificacoes.TabIndex = 3;
            this.botaoNotificacoes.Text = "            NOTIFICAÇÕES";
            this.botaoNotificacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoNotificacoes.UseVisualStyleBackColor = false;
            this.botaoNotificacoes.MouseEnter += new System.EventHandler(this.botaoNotificacoes_MouseEnter);
            this.botaoNotificacoes.MouseLeave += new System.EventHandler(this.botaoNotificacoes_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.botaoChat);
            this.panel3.Location = new System.Drawing.Point(3, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 60);
            this.panel3.TabIndex = 5;
            // 
            // botaoChat
            // 
            this.botaoChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoChat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoChat.ForeColor = System.Drawing.Color.White;
            this.botaoChat.Image = global::JobStack.Properties.Resources.icone_chat;
            this.botaoChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoChat.Location = new System.Drawing.Point(-13, -10);
            this.botaoChat.Name = "botaoChat";
            this.botaoChat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.botaoChat.Size = new System.Drawing.Size(269, 80);
            this.botaoChat.TabIndex = 3;
            this.botaoChat.Text = "            CHAT";
            this.botaoChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoChat.UseVisualStyleBackColor = false;
            this.botaoChat.MouseEnter += new System.EventHandler(this.botaoChat_MouseEnter);
            this.botaoChat.MouseLeave += new System.EventHandler(this.botaoChat_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.botaoVagas);
            this.panel4.Location = new System.Drawing.Point(3, 267);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 60);
            this.panel4.TabIndex = 6;
            // 
            // botaoVagas
            // 
            this.botaoVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoVagas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVagas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVagas.ForeColor = System.Drawing.Color.White;
            this.botaoVagas.Image = global::JobStack.Properties.Resources.icone_vagas_emp;
            this.botaoVagas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoVagas.Location = new System.Drawing.Point(-13, -10);
            this.botaoVagas.Name = "botaoVagas";
            this.botaoVagas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.botaoVagas.Size = new System.Drawing.Size(269, 80);
            this.botaoVagas.TabIndex = 3;
            this.botaoVagas.Text = "            VAGAS";
            this.botaoVagas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoVagas.UseVisualStyleBackColor = false;
            this.botaoVagas.MouseEnter += new System.EventHandler(this.botaoVagas_MouseEnter);
            this.botaoVagas.MouseLeave += new System.EventHandler(this.botaoVagas_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.botaoPerfil);
            this.panel7.Location = new System.Drawing.Point(3, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(247, 60);
            this.panel7.TabIndex = 9;
            // 
            // botaoPerfil
            // 
            this.botaoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPerfil.ForeColor = System.Drawing.Color.White;
            this.botaoPerfil.Image = global::JobStack.Properties.Resources.icon_meu_perfil;
            this.botaoPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoPerfil.Location = new System.Drawing.Point(-13, -10);
            this.botaoPerfil.Name = "botaoPerfil";
            this.botaoPerfil.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.botaoPerfil.Size = new System.Drawing.Size(269, 80);
            this.botaoPerfil.TabIndex = 3;
            this.botaoPerfil.Text = "            MEU PERFIL";
            this.botaoPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoPerfil.UseVisualStyleBackColor = false;
            this.botaoPerfil.MouseEnter += new System.EventHandler(this.botaoPerfil_MouseEnter);
            this.botaoPerfil.MouseLeave += new System.EventHandler(this.botaoPerfil_MouseLeave);
            this.botaoPerfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.botaoPerfil_MouseMove);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(3, 399);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(248, 130);
            this.panel11.TabIndex = 30;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.botaoLogout);
            this.panel13.Location = new System.Drawing.Point(3, 535);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(247, 60);
            this.panel13.TabIndex = 31;
            // 
            // botaoLogout
            // 
            this.botaoLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLogout.ForeColor = System.Drawing.Color.White;
            this.botaoLogout.Image = global::JobStack.Properties.Resources.icon_log_out;
            this.botaoLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoLogout.Location = new System.Drawing.Point(-13, -10);
            this.botaoLogout.Name = "botaoLogout";
            this.botaoLogout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.botaoLogout.Size = new System.Drawing.Size(269, 80);
            this.botaoLogout.TabIndex = 3;
            this.botaoLogout.Text = "             SAIR/LOG OUT";
            this.botaoLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoLogout.UseVisualStyleBackColor = false;
            this.botaoLogout.Click += new System.EventHandler(this.botaoLogout_Click);
            this.botaoLogout.MouseEnter += new System.EventHandler(this.botaoLogout_MouseEnter);
            this.botaoLogout.MouseLeave += new System.EventHandler(this.botaoLogout_MouseLeave);
            // 
            // fundoMenuTimer
            // 
            this.fundoMenuTimer.Interval = 1;
            this.fundoMenuTimer.Tick += new System.EventHandler(this.fundoMenuTimer_Tick);
            // 
            // botaoMinimizar
            // 
            this.botaoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoMinimizar.Image = global::JobStack.Properties.Resources.botao_minimizar;
            this.botaoMinimizar.Location = new System.Drawing.Point(882, 12);
            this.botaoMinimizar.Name = "botaoMinimizar";
            this.botaoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botaoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoMinimizar.TabIndex = 6;
            this.botaoMinimizar.TabStop = false;
            this.botaoMinimizar.Click += new System.EventHandler(this.botaoMinimizar_Click);
            // 
            // botaoFechar
            // 
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.Image = global::JobStack.Properties.Resources.botao_fechar;
            this.botaoFechar.Location = new System.Drawing.Point(922, 12);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(25, 25);
            this.botaoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoFechar.TabIndex = 5;
            this.botaoFechar.TabStop = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // TMenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.botaoMinimizar);
            this.Controls.Add(this.fundoMenu);
            this.Controls.Add(this.botaoFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TMenuEmpresa";
            this.Text = "TEmpresa";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TMenuEmpresa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TMenuEmpresa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TMenuEmpresa_MouseUp);
            this.fundoMenu.ResumeLayout(false);
            this.panelBarraeLogo.ResumeLayout(false);
            this.panelBarraeLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoAbreMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fundoMenu;
        private System.Windows.Forms.Panel panelBarraeLogo;
        private System.Windows.Forms.PictureBox botaoAbreMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoNotificacoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button botaoChat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botaoVagas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button botaoPerfil;
        private System.Windows.Forms.Timer fundoMenuTimer;
        private System.Windows.Forms.PictureBox botaoMinimizar;
        private System.Windows.Forms.PictureBox botaoFechar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button botaoLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}