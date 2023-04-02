
namespace JobStack
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoSenha = new System.Windows.Forms.Label();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.CondicaoSenha = new System.Windows.Forms.Label();
            this.CondicaoEmail = new System.Windows.Forms.Label();
            this.BotaoProximo = new System.Windows.Forms.Button();
            this.BotaoLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.painelEmail = new System.Windows.Forms.Panel();
            this.painelSenha = new System.Windows.Forms.Panel();
            this.copiarEmail = new System.Windows.Forms.Label();
            this.painelSuporte = new System.Windows.Forms.Panel();
            this.CondicaoEmailS = new System.Windows.Forms.Label();
            this.botaoEnviar = new System.Windows.Forms.Button();
            this.campoEmailPessoal = new System.Windows.Forms.TextBox();
            this.emailPessoal = new System.Windows.Forms.Label();
            this.erro = new System.Windows.Forms.ComboBox();
            this.perguntaSuporte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoMinimizar = new System.Windows.Forms.PictureBox();
            this.botaoFechar = new System.Windows.Forms.PictureBox();
            this.painelEmail.SuspendLayout();
            this.painelSenha.SuspendLayout();
            this.painelSuporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(40, 68);
            this.campoEmail.Multiline = true;
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(260, 29);
            this.campoEmail.TabIndex = 1;
            this.campoEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoEmail
            // 
            this.textoEmail.AutoSize = true;
            this.textoEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.Location = new System.Drawing.Point(140, 46);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(54, 19);
            this.textoEmail.TabIndex = 2;
            this.textoEmail.Text = "EMAIL";
            this.textoEmail.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textoSenha
            // 
            this.textoSenha.AutoSize = true;
            this.textoSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(140, 40);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(60, 19);
            this.textoSenha.TabIndex = 9;
            this.textoSenha.Text = "SENHA";
            this.textoSenha.Click += new System.EventHandler(this.Label2_Click);
            // 
            // campoSenha
            // 
            this.campoSenha.HideSelection = false;
            this.campoSenha.Location = new System.Drawing.Point(40, 62);
            this.campoSenha.Multiline = true;
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(260, 29);
            this.campoSenha.TabIndex = 8;
            this.campoSenha.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(921, 647);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 10;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.Visible = false;
            this.botaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // CondicaoSenha
            // 
            this.CondicaoSenha.AutoSize = true;
            this.CondicaoSenha.Location = new System.Drawing.Point(133, 94);
            this.CondicaoSenha.Name = "CondicaoSenha";
            this.CondicaoSenha.Size = new System.Drawing.Size(83, 13);
            this.CondicaoSenha.TabIndex = 11;
            this.CondicaoSenha.Text = "CondicaoSenha";
            this.CondicaoSenha.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // CondicaoEmail
            // 
            this.CondicaoEmail.AutoSize = true;
            this.CondicaoEmail.Location = new System.Drawing.Point(131, 100);
            this.CondicaoEmail.Name = "CondicaoEmail";
            this.CondicaoEmail.Size = new System.Drawing.Size(80, 13);
            this.CondicaoEmail.TabIndex = 12;
            this.CondicaoEmail.Text = "Condicao Email";
            // 
            // BotaoProximo
            // 
            this.BotaoProximo.Location = new System.Drawing.Point(136, 116);
            this.BotaoProximo.Name = "BotaoProximo";
            this.BotaoProximo.Size = new System.Drawing.Size(75, 23);
            this.BotaoProximo.TabIndex = 15;
            this.BotaoProximo.Text = "Proximo";
            this.BotaoProximo.UseVisualStyleBackColor = true;
            this.BotaoProximo.Click += new System.EventHandler(this.BotaoProximo_Click);
            // 
            // BotaoLogin
            // 
            this.BotaoLogin.Location = new System.Drawing.Point(136, 110);
            this.BotaoLogin.Name = "BotaoLogin";
            this.BotaoLogin.Size = new System.Drawing.Size(75, 23);
            this.BotaoLogin.TabIndex = 16;
            this.BotaoLogin.Text = "Login";
            this.BotaoLogin.UseVisualStyleBackColor = true;
            this.BotaoLogin.Click += new System.EventHandler(this.BotaoLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(785, 596);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Suporte técnico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // painelEmail
            // 
            this.painelEmail.Controls.Add(this.campoEmail);
            this.painelEmail.Controls.Add(this.BotaoProximo);
            this.painelEmail.Controls.Add(this.textoEmail);
            this.painelEmail.Controls.Add(this.CondicaoEmail);
            this.painelEmail.Location = new System.Drawing.Point(647, 159);
            this.painelEmail.Name = "painelEmail";
            this.painelEmail.Size = new System.Drawing.Size(320, 154);
            this.painelEmail.TabIndex = 18;
            this.painelEmail.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelEmail_Paint);
            // 
            // painelSenha
            // 
            this.painelSenha.Controls.Add(this.copiarEmail);
            this.painelSenha.Controls.Add(this.BotaoLogin);
            this.painelSenha.Controls.Add(this.CondicaoSenha);
            this.painelSenha.Controls.Add(this.campoSenha);
            this.painelSenha.Controls.Add(this.textoSenha);
            this.painelSenha.Location = new System.Drawing.Point(647, 328);
            this.painelSenha.Name = "painelSenha";
            this.painelSenha.Size = new System.Drawing.Size(320, 136);
            this.painelSenha.TabIndex = 19;
            this.painelSenha.Visible = false;
            this.painelSenha.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelSenha_Paint);
            // 
            // copiarEmail
            // 
            this.copiarEmail.AutoSize = true;
            this.copiarEmail.Location = new System.Drawing.Point(138, 11);
            this.copiarEmail.Name = "copiarEmail";
            this.copiarEmail.Size = new System.Drawing.Size(66, 13);
            this.copiarEmail.TabIndex = 17;
            this.copiarEmail.Text = "emailPessoa";
            // 
            // painelSuporte
            // 
            this.painelSuporte.Controls.Add(this.CondicaoEmailS);
            this.painelSuporte.Controls.Add(this.botaoEnviar);
            this.painelSuporte.Controls.Add(this.campoEmailPessoal);
            this.painelSuporte.Controls.Add(this.emailPessoal);
            this.painelSuporte.Controls.Add(this.erro);
            this.painelSuporte.Controls.Add(this.perguntaSuporte);
            this.painelSuporte.Location = new System.Drawing.Point(120, 211);
            this.painelSuporte.Name = "painelSuporte";
            this.painelSuporte.Size = new System.Drawing.Size(214, 224);
            this.painelSuporte.TabIndex = 20;
            this.painelSuporte.Visible = false;
            this.painelSuporte.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelSuporte_Paint);
            // 
            // CondicaoEmailS
            // 
            this.CondicaoEmailS.AutoSize = true;
            this.CondicaoEmailS.Location = new System.Drawing.Point(25, 128);
            this.CondicaoEmailS.Name = "CondicaoEmailS";
            this.CondicaoEmailS.Size = new System.Drawing.Size(51, 13);
            this.CondicaoEmailS.TabIndex = 24;
            this.CondicaoEmailS.Text = "condicao";
            // 
            // botaoEnviar
            // 
            this.botaoEnviar.Location = new System.Drawing.Point(55, 158);
            this.botaoEnviar.Name = "botaoEnviar";
            this.botaoEnviar.Size = new System.Drawing.Size(75, 23);
            this.botaoEnviar.TabIndex = 23;
            this.botaoEnviar.Text = "Enviar";
            this.botaoEnviar.UseVisualStyleBackColor = true;
            this.botaoEnviar.Click += new System.EventHandler(this.BotaoEnviar_Click);
            // 
            // campoEmailPessoal
            // 
            this.campoEmailPessoal.Location = new System.Drawing.Point(17, 105);
            this.campoEmailPessoal.Name = "campoEmailPessoal";
            this.campoEmailPessoal.Size = new System.Drawing.Size(161, 20);
            this.campoEmailPessoal.TabIndex = 21;
            this.campoEmailPessoal.TextChanged += new System.EventHandler(this.CampoEmailPessoal_TextChanged);
            // 
            // emailPessoal
            // 
            this.emailPessoal.AutoSize = true;
            this.emailPessoal.Location = new System.Drawing.Point(25, 89);
            this.emailPessoal.Name = "emailPessoal";
            this.emailPessoal.Size = new System.Drawing.Size(130, 13);
            this.emailPessoal.TabIndex = 22;
            this.emailPessoal.Text = "Qual o seu email pessoal?";
            // 
            // erro
            // 
            this.erro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.erro.FormattingEnabled = true;
            this.erro.Location = new System.Drawing.Point(17, 45);
            this.erro.Name = "erro";
            this.erro.Size = new System.Drawing.Size(161, 21);
            this.erro.TabIndex = 21;
            this.erro.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // perguntaSuporte
            // 
            this.perguntaSuporte.AutoSize = true;
            this.perguntaSuporte.Location = new System.Drawing.Point(40, 29);
            this.perguntaSuporte.Name = "perguntaSuporte";
            this.perguntaSuporte.Size = new System.Drawing.Size(104, 13);
            this.perguntaSuporte.TabIndex = 0;
            this.perguntaSuporte.Text = "Qual o seu problema";
            this.perguntaSuporte.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobStack.Properties.Resources.fundo_tela_de_login_vazio;
            this.pictureBox1.Location = new System.Drawing.Point(-23, -130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 939);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // botaoMinimizar
            // 
            this.botaoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoMinimizar.Image = global::JobStack.Properties.Resources.botao_minimizar;
            this.botaoMinimizar.Location = new System.Drawing.Point(929, 12);
            this.botaoMinimizar.Name = "botaoMinimizar";
            this.botaoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botaoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoMinimizar.TabIndex = 22;
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
            this.botaoFechar.TabIndex = 21;
            this.botaoFechar.TabStop = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.botaoMinimizar);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.painelSuporte);
            this.Controls.Add(this.painelSenha);
            this.Controls.Add(this.painelEmail);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.painelEmail.ResumeLayout(false);
            this.painelEmail.PerformLayout();
            this.painelSenha.ResumeLayout(false);
            this.painelSenha.PerformLayout();
            this.painelSuporte.ResumeLayout(false);
            this.painelSuporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoSenha;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label CondicaoSenha;
        private System.Windows.Forms.Label CondicaoEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotaoProximo;
        private System.Windows.Forms.Button BotaoLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel painelEmail;
        private System.Windows.Forms.Panel painelSenha;
        private System.Windows.Forms.Label copiarEmail;
        private System.Windows.Forms.Panel painelSuporte;
        private System.Windows.Forms.Label perguntaSuporte;
        private System.Windows.Forms.ComboBox erro;
        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.TextBox campoEmailPessoal;
        private System.Windows.Forms.Label emailPessoal;
        private System.Windows.Forms.Label CondicaoEmailS;
        private System.Windows.Forms.PictureBox botaoMinimizar;
        private System.Windows.Forms.PictureBox botaoFechar;
    }
}

