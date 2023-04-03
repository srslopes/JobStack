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
            this.SuspendLayout();
            // 
            // buttonDB
            // 
            this.buttonDB.Location = new System.Drawing.Point(713, 35);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(75, 23);
            this.buttonDB.TabIndex = 0;
            this.buttonDB.Text = "DB";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.ButtonDB_Click);
            // 
            // buttonVagas
            // 
            this.buttonVagas.Location = new System.Drawing.Point(713, 73);
            this.buttonVagas.Name = "buttonVagas";
            this.buttonVagas.Size = new System.Drawing.Size(75, 23);
            this.buttonVagas.TabIndex = 1;
            this.buttonVagas.Text = "Vagas";
            this.buttonVagas.UseVisualStyleBackColor = true;
            this.buttonVagas.Click += new System.EventHandler(this.ButtonVagas_Click);
            // 
            // TesteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVagas);
            this.Controls.Add(this.buttonDB);
            this.Name = "TesteMenu";
            this.Text = "TesteMenu";
            this.Load += new System.EventHandler(this.TesteMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDB;
        private System.Windows.Forms.Button buttonVagas;
    }
}