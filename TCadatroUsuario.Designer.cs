
namespace JobStack
{
    partial class TCadatroUsuario
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
            this.tituloTela = new System.Windows.Forms.Label();
            this.textoTipoUsuario = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoSenha = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.botaoCadUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloTela
            // 
            this.tituloTela.AutoSize = true;
            this.tituloTela.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTela.Location = new System.Drawing.Point(53, 33);
            this.tituloTela.Name = "tituloTela";
            this.tituloTela.Size = new System.Drawing.Size(265, 25);
            this.tituloTela.TabIndex = 9;
            this.tituloTela.Text = "CADASTRO DE USUÁRIOS";
            // 
            // textoTipoUsuario
            // 
            this.textoTipoUsuario.AutoSize = true;
            this.textoTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTipoUsuario.Location = new System.Drawing.Point(70, 93);
            this.textoTipoUsuario.Name = "textoTipoUsuario";
            this.textoTipoUsuario.Size = new System.Drawing.Size(139, 19);
            this.textoTipoUsuario.TabIndex = 10;
            this.textoTipoUsuario.Text = "TIPO DE USUÁRIO:";
            // 
            // textoEmail
            // 
            this.textoEmail.AutoSize = true;
            this.textoEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.Location = new System.Drawing.Point(71, 163);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(58, 19);
            this.textoEmail.TabIndex = 11;
            this.textoEmail.Text = "EMAIL:";
            // 
            // textoSenha
            // 
            this.textoSenha.AutoSize = true;
            this.textoSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(71, 219);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(64, 19);
            this.textoSenha.TabIndex = 12;
            this.textoSenha.Text = "SENHA:";
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Coordenador de Estágio",
            "Empresa",
            "Aluno"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(215, 95);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(206, 21);
            this.comboBoxTipoUsuario.TabIndex = 13;
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(135, 165);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(410, 20);
            this.campoEmail.TabIndex = 14;
            this.campoEmail.TextChanged += new System.EventHandler(this.campoEmail_TextChanged);
            // 
            // campoSenha
            // 
            this.campoSenha.Location = new System.Drawing.Point(141, 218);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(221, 20);
            this.campoSenha.TabIndex = 15;
            this.campoSenha.UseSystemPasswordChar = true;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(576, 504);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 26;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(657, 504);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 28;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            // 
            // botaoCadUsuario
            // 
            this.botaoCadUsuario.Location = new System.Drawing.Point(738, 504);
            this.botaoCadUsuario.Name = "botaoCadUsuario";
            this.botaoCadUsuario.Size = new System.Drawing.Size(110, 23);
            this.botaoCadUsuario.TabIndex = 29;
            this.botaoCadUsuario.Text = "Cadastrar usuário";
            this.botaoCadUsuario.UseVisualStyleBackColor = true;
            // 
            // TCadatroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(887, 557);
            this.Controls.Add(this.botaoCadUsuario);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.comboBoxTipoUsuario);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.textoEmail);
            this.Controls.Add(this.textoTipoUsuario);
            this.Controls.Add(this.tituloTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCadatroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCadatroUsuario";
            this.Load += new System.EventHandler(this.TCadatroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloTela;
        private System.Windows.Forms.Label textoTipoUsuario;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoSenha;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoCadUsuario;
    }
}