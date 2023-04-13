namespace JobStack.Testes
{
    partial class TesteChat
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
            this.panelConversas = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.textBoxMensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelConversas
            // 
            this.panelConversas.Location = new System.Drawing.Point(12, 12);
            this.panelConversas.Name = "panelConversas";
            this.panelConversas.Size = new System.Drawing.Size(200, 426);
            this.panelConversas.TabIndex = 0;
            // 
            // panelChat
            // 
            this.panelChat.Location = new System.Drawing.Point(218, 12);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(570, 388);
            this.panelChat.TabIndex = 1;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(681, 406);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(107, 32);
            this.buttonEnviar.TabIndex = 3;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // textBoxMensagem
            // 
            this.textBoxMensagem.Location = new System.Drawing.Point(218, 413);
            this.textBoxMensagem.Name = "textBoxMensagem";
            this.textBoxMensagem.Size = new System.Drawing.Size(457, 20);
            this.textBoxMensagem.TabIndex = 4;
            // 
            // TesteChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMensagem);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.panelConversas);
            this.Name = "TesteChat";
            this.Text = "TesteChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConversas;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.TextBox textBoxMensagem;
    }
}