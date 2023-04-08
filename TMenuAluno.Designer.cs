namespace JobStack
{
    partial class TMenuAluno
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
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.botaoMinimizar = new System.Windows.Forms.PictureBox();
            this.botaoFechar = new System.Windows.Forms.PictureBox();
            this.fundoMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBarraeLogo = new System.Windows.Forms.Panel();
            this.botaoAbreMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoNotificacoes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.botaoChat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botaoInscricoes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.botaoFavoritos = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.botaoPerfil = new System.Windows.Forms.Button();
            this.fundoMenuTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).BeginInit();
            this.fundoMenu.SuspendLayout();
            this.panelBarraeLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botaoAbreMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.Location = new System.Drawing.Point(912, 685);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.BotaoVoltar.TabIndex = 2;
            this.BotaoVoltar.Text = "Voltar";
            this.BotaoVoltar.UseVisualStyleBackColor = true;
            this.BotaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // botaoMinimizar
            // 
            this.botaoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoMinimizar.Image = global::JobStack.Properties.Resources.botao_minimizar;
            this.botaoMinimizar.Location = new System.Drawing.Point(929, 12);
            this.botaoMinimizar.Name = "botaoMinimizar";
            this.botaoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botaoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoMinimizar.TabIndex = 4;
            this.botaoMinimizar.TabStop = false;
            this.botaoMinimizar.Click += new System.EventHandler(this.botaoMinimizar_Click);
            // 
            // botaoFechar
            // 
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.Image = global::JobStack.Properties.Resources.botao_fechar;
            this.botaoFechar.Location = new System.Drawing.Point(971, 12);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(25, 25);
            this.botaoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoFechar.TabIndex = 3;
            this.botaoFechar.TabStop = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // fundoMenu
            // 
            this.fundoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.fundoMenu.Controls.Add(this.panelBarraeLogo);
            this.fundoMenu.Controls.Add(this.panel2);
            this.fundoMenu.Controls.Add(this.panel1);
            this.fundoMenu.Controls.Add(this.panel3);
            this.fundoMenu.Controls.Add(this.panel4);
            this.fundoMenu.Controls.Add(this.panel5);
            this.fundoMenu.Controls.Add(this.panel7);
            this.fundoMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.fundoMenu.Location = new System.Drawing.Point(0, 0);
            this.fundoMenu.MaximumSize = new System.Drawing.Size(250, 729);
            this.fundoMenu.MinimumSize = new System.Drawing.Size(77, 729);
            this.fundoMenu.Name = "fundoMenu";
            this.fundoMenu.Size = new System.Drawing.Size(250, 729);
            this.fundoMenu.TabIndex = 5;
            // 
            // panelBarraeLogo
            // 
            this.panelBarraeLogo.Controls.Add(this.botaoAbreMenu);
            this.panelBarraeLogo.Location = new System.Drawing.Point(3, 3);
            this.panelBarraeLogo.Name = "panelBarraeLogo";
            this.panelBarraeLogo.Size = new System.Drawing.Size(247, 118);
            this.panelBarraeLogo.TabIndex = 0;
            // 
            // botaoAbreMenu
            // 
            this.botaoAbreMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAbreMenu.Image = global::JobStack.Properties.Resources.icon_abremenu;
            this.botaoAbreMenu.Location = new System.Drawing.Point(19, 35);
            this.botaoAbreMenu.Name = "botaoAbreMenu";
            this.botaoAbreMenu.Size = new System.Drawing.Size(46, 39);
            this.botaoAbreMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botaoAbreMenu.TabIndex = 0;
            this.botaoAbreMenu.TabStop = false;
            this.botaoAbreMenu.Click += new System.EventHandler(this.botaoAbreMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botaoPesquisar);
            this.panel2.Location = new System.Drawing.Point(3, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 60);
            this.panel2.TabIndex = 4;
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisar.ForeColor = System.Drawing.Color.White;
            this.botaoPesquisar.Image = global::JobStack.Properties.Resources.icone_menu_pesquisa;
            this.botaoPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoPesquisar.Location = new System.Drawing.Point(-13, -10);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.botaoPesquisar.Size = new System.Drawing.Size(269, 80);
            this.botaoPesquisar.TabIndex = 3;
            this.botaoPesquisar.Text = "            PESQUISAR VAGAS";
            this.botaoPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoPesquisar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoNotificacoes);
            this.panel1.Location = new System.Drawing.Point(3, 193);
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
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.botaoChat);
            this.panel3.Location = new System.Drawing.Point(3, 259);
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.botaoInscricoes);
            this.panel4.Location = new System.Drawing.Point(3, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 60);
            this.panel4.TabIndex = 6;
            // 
            // botaoInscricoes
            // 
            this.botaoInscricoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoInscricoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoInscricoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInscricoes.ForeColor = System.Drawing.Color.White;
            this.botaoInscricoes.Image = global::JobStack.Properties.Resources.icone_inscricoes1;
            this.botaoInscricoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoInscricoes.Location = new System.Drawing.Point(-13, -10);
            this.botaoInscricoes.Name = "botaoInscricoes";
            this.botaoInscricoes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.botaoInscricoes.Size = new System.Drawing.Size(269, 80);
            this.botaoInscricoes.TabIndex = 3;
            this.botaoInscricoes.Text = "        MINHAS INSCRIÇÕES";
            this.botaoInscricoes.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.botaoFavoritos);
            this.panel5.Location = new System.Drawing.Point(3, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 60);
            this.panel5.TabIndex = 7;
            // 
            // botaoFavoritos
            // 
            this.botaoFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(153)))));
            this.botaoFavoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFavoritos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFavoritos.ForeColor = System.Drawing.Color.White;
            this.botaoFavoritos.Image = global::JobStack.Properties.Resources.icone_fav_2;
            this.botaoFavoritos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoFavoritos.Location = new System.Drawing.Point(-13, -10);
            this.botaoFavoritos.Name = "botaoFavoritos";
            this.botaoFavoritos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.botaoFavoritos.Size = new System.Drawing.Size(269, 80);
            this.botaoFavoritos.TabIndex = 3;
            this.botaoFavoritos.Text = "             FAVORITOS";
            this.botaoFavoritos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoFavoritos.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.botaoPerfil);
            this.panel7.Location = new System.Drawing.Point(3, 457);
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
            this.botaoPerfil.Text = "             MEU PERFIL";
            this.botaoPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoPerfil.UseVisualStyleBackColor = false;
            // 
            // fundoMenuTimer
            // 
            this.fundoMenuTimer.Interval = 7;
            this.fundoMenuTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TMenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.fundoMenu);
            this.Controls.Add(this.botaoMinimizar);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.BotaoVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TMenuAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMenuAluno";
            this.Load += new System.EventHandler(this.TMenuAluno_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TMenuAluno_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).EndInit();
            this.fundoMenu.ResumeLayout(false);
            this.panelBarraeLogo.ResumeLayout(false);
            this.panelBarraeLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botaoAbreMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoVoltar;
        private System.Windows.Forms.PictureBox botaoMinimizar;
        private System.Windows.Forms.PictureBox botaoFechar;
        private System.Windows.Forms.FlowLayoutPanel fundoMenu;
        private System.Windows.Forms.Panel panelBarraeLogo;
        private System.Windows.Forms.PictureBox botaoAbreMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botaoPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoNotificacoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button botaoChat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botaoInscricoes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button botaoFavoritos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button botaoPerfil;
        private System.Windows.Forms.Timer fundoMenuTimer;
    }
}