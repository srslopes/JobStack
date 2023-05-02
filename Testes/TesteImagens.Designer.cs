namespace JobStack.Testes
{
    partial class TesteImagens
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botãoProcurarImagem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // botãoProcurarImagem
            // 
            this.botãoProcurarImagem.Location = new System.Drawing.Point(760, 180);
            this.botãoProcurarImagem.Name = "botãoProcurarImagem";
            this.botãoProcurarImagem.Size = new System.Drawing.Size(192, 29);
            this.botãoProcurarImagem.TabIndex = 1;
            this.botãoProcurarImagem.Text = "Adicionar Imagem";
            this.botãoProcurarImagem.UseVisualStyleBackColor = true;
            this.botãoProcurarImagem.Click += new System.EventHandler(this.BotãoProcurarImagem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "Carregar imagem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TesteImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botãoProcurarImagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TesteImagens";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botãoProcurarImagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}