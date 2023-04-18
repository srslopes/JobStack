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
            this.panelConversas.Location = new System.Drawing.Point(18, 18);
            this.panelConversas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConversas.Name = "panelConversas";
            this.panelConversas.Size = new System.Drawing.Size(300, 655);
            this.panelConversas.TabIndex = 0;
            this.panelConversas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelConversas_Paint);
            // 
            // panelChat
            // 
            this.panelChat.Location = new System.Drawing.Point(327, 18);
            this.panelChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(855, 597);
            this.panelChat.TabIndex = 1;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(1022, 625);
            this.buttonEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(160, 49);
            this.buttonEnviar.TabIndex = 3;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // textBoxMensagem
            // 
            this.textBoxMensagem.Location = new System.Drawing.Point(327, 635);
            this.textBoxMensagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMensagem.Name = "textBoxMensagem";
            this.textBoxMensagem.Size = new System.Drawing.Size(684, 26);
            this.textBoxMensagem.TabIndex = 4;
            // 
            // TesteChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.textBoxMensagem);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.panelConversas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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