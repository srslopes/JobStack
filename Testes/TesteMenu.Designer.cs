namespace JobStack
{
    partial class TesteMenu
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
            this.buttonDB = new System.Windows.Forms.Button();
            this.buttonVagas = new System.Windows.Forms.Button();
            this.buttonChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDB
            // 
            this.buttonDB.Location = new System.Drawing.Point(1070, 54);
            this.buttonDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(112, 35);
            this.buttonDB.TabIndex = 0;
            this.buttonDB.Text = "DB";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.ButtonDB_Click);
            // 
            // buttonVagas
            // 
            this.buttonVagas.Location = new System.Drawing.Point(1070, 112);
            this.buttonVagas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVagas.Name = "buttonVagas";
            this.buttonVagas.Size = new System.Drawing.Size(112, 35);
            this.buttonVagas.TabIndex = 1;
            this.buttonVagas.Text = "Vagas";
            this.buttonVagas.UseVisualStyleBackColor = true;
            this.buttonVagas.Click += new System.EventHandler(this.ButtonVagas_Click);
            // 
            // buttonChat
            // 
            this.buttonChat.Location = new System.Drawing.Point(1070, 172);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(112, 31);
            this.buttonChat.TabIndex = 2;
            this.buttonChat.Text = "Chat";
            this.buttonChat.UseVisualStyleBackColor = true;
            // 
            // TesteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.buttonVagas);
            this.Controls.Add(this.buttonDB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TesteMenu";
            this.Text = "TesteMenu";
            this.Load += new System.EventHandler(this.TesteMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDB;
        private System.Windows.Forms.Button buttonVagas;
        private System.Windows.Forms.Button buttonChat;
    }
}