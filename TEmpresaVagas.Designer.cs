
namespace JobStack
{
    partial class TEmpresaVagas
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
            this.txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(226, 194);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(432, 29);
            this.txt.TabIndex = 5;
            this.txt.Text = "TELA DE GESTÃO GERAL DAS VAGAS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "CADASTRAR VAGAS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TEmpresaVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TEmpresaVagas";
            this.Text = "TEmpresaVagas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Button button1;
    }
}