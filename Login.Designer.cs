
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotaoProximo = new System.Windows.Forms.Button();
            this.BotaoLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(716, 136);
            this.campoEmail.Multiline = true;
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(260, 29);
            this.campoEmail.TabIndex = 1;
            this.campoEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoEmail
            // 
            this.textoEmail.AutoSize = true;
            this.textoEmail.Location = new System.Drawing.Point(823, 110);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(32, 13);
            this.textoEmail.TabIndex = 2;
            this.textoEmail.Text = "Email";
            this.textoEmail.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textoSenha
            // 
            this.textoSenha.AutoSize = true;
            this.textoSenha.Location = new System.Drawing.Point(823, 281);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(38, 13);
            this.textoSenha.TabIndex = 9;
            this.textoSenha.Text = "Senha";
            this.textoSenha.Click += new System.EventHandler(this.Label2_Click);
            // 
            // campoSenha
            // 
            this.campoSenha.HideSelection = false;
            this.campoSenha.Location = new System.Drawing.Point(716, 308);
            this.campoSenha.Multiline = true;
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(260, 29);
            this.campoSenha.TabIndex = 8;
            this.campoSenha.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(901, 669);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 10;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // CondicaoSenha
            // 
            this.CondicaoSenha.AutoSize = true;
            this.CondicaoSenha.Location = new System.Drawing.Point(804, 356);
            this.CondicaoSenha.Name = "CondicaoSenha";
            this.CondicaoSenha.Size = new System.Drawing.Size(83, 13);
            this.CondicaoSenha.TabIndex = 11;
            this.CondicaoSenha.Text = "CondicaoSenha";
            this.CondicaoSenha.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // CondicaoEmail
            // 
            this.CondicaoEmail.AutoSize = true;
            this.CondicaoEmail.Location = new System.Drawing.Point(823, 177);
            this.CondicaoEmail.Name = "CondicaoEmail";
            this.CondicaoEmail.Size = new System.Drawing.Size(80, 13);
            this.CondicaoEmail.TabIndex = 12;
            this.CondicaoEmail.Text = "Condicao Email";
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
            // BotaoProximo
            // 
            this.BotaoProximo.Location = new System.Drawing.Point(812, 193);
            this.BotaoProximo.Name = "BotaoProximo";
            this.BotaoProximo.Size = new System.Drawing.Size(75, 23);
            this.BotaoProximo.TabIndex = 15;
            this.BotaoProximo.Text = "Proximo";
            this.BotaoProximo.UseVisualStyleBackColor = true;
            this.BotaoProximo.Click += new System.EventHandler(this.BotaoProximo_Click);
            // 
            // BotaoLogin
            // 
            this.BotaoLogin.Location = new System.Drawing.Point(812, 401);
            this.BotaoLogin.Name = "BotaoLogin";
            this.BotaoLogin.Size = new System.Drawing.Size(75, 23);
            this.BotaoLogin.TabIndex = 16;
            this.BotaoLogin.Text = "Login";
            this.BotaoLogin.UseVisualStyleBackColor = true;
            this.BotaoLogin.Click += new System.EventHandler(this.BotaoLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BotaoLogin);
            this.Controls.Add(this.BotaoProximo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CondicaoEmail);
            this.Controls.Add(this.CondicaoSenha);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.textoEmail);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

