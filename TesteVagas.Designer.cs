namespace JobStack
{
    partial class TesteVagas
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
            this.buttonCriar = new System.Windows.Forms.Button();
            this.textBoxIdEmpresa = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.listBoxVagas = new System.Windows.Forms.ListBox();
            this.buttonAtt = new System.Windows.Forms.Button();
            this.buttonInscrever = new System.Windows.Forms.Button();
            this.labelIdAluno = new System.Windows.Forms.Label();
            this.textBoxIdAluno = new System.Windows.Forms.TextBox();
            this.textBoxIdVaga = new System.Windows.Forms.TextBox();
            this.labelIdVaga = new System.Windows.Forms.Label();
            this.buttonDesinscrever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(58, 77);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 23);
            this.buttonCriar.TabIndex = 0;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.ButtonCriar_Click);
            // 
            // textBoxIdEmpresa
            // 
            this.textBoxIdEmpresa.Location = new System.Drawing.Point(43, 51);
            this.textBoxIdEmpresa.Name = "textBoxIdEmpresa";
            this.textBoxIdEmpresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdEmpresa.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(67, 35);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(62, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID Empresa";
            // 
            // listBoxVagas
            // 
            this.listBoxVagas.FormattingEnabled = true;
            this.listBoxVagas.Location = new System.Drawing.Point(227, 22);
            this.listBoxVagas.Name = "listBoxVagas";
            this.listBoxVagas.Size = new System.Drawing.Size(550, 355);
            this.listBoxVagas.TabIndex = 3;
            // 
            // buttonAtt
            // 
            this.buttonAtt.Location = new System.Drawing.Point(429, 383);
            this.buttonAtt.Name = "buttonAtt";
            this.buttonAtt.Size = new System.Drawing.Size(75, 23);
            this.buttonAtt.TabIndex = 4;
            this.buttonAtt.Text = "Atualizar";
            this.buttonAtt.UseVisualStyleBackColor = true;
            this.buttonAtt.Click += new System.EventHandler(this.ButtonAtt_Click);
            // 
            // buttonInscrever
            // 
            this.buttonInscrever.Location = new System.Drawing.Point(12, 260);
            this.buttonInscrever.Name = "buttonInscrever";
            this.buttonInscrever.Size = new System.Drawing.Size(75, 23);
            this.buttonInscrever.TabIndex = 5;
            this.buttonInscrever.Text = "Inscrever";
            this.buttonInscrever.UseVisualStyleBackColor = true;
            this.buttonInscrever.Click += new System.EventHandler(this.ButtonInscrever_Click);
            // 
            // labelIdAluno
            // 
            this.labelIdAluno.AutoSize = true;
            this.labelIdAluno.Location = new System.Drawing.Point(67, 156);
            this.labelIdAluno.Name = "labelIdAluno";
            this.labelIdAluno.Size = new System.Drawing.Size(48, 13);
            this.labelIdAluno.TabIndex = 6;
            this.labelIdAluno.Text = "ID Aluno";
            // 
            // textBoxIdAluno
            // 
            this.textBoxIdAluno.Location = new System.Drawing.Point(43, 172);
            this.textBoxIdAluno.Name = "textBoxIdAluno";
            this.textBoxIdAluno.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdAluno.TabIndex = 7;
            // 
            // textBoxIdVaga
            // 
            this.textBoxIdVaga.Location = new System.Drawing.Point(43, 234);
            this.textBoxIdVaga.Name = "textBoxIdVaga";
            this.textBoxIdVaga.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdVaga.TabIndex = 8;
            // 
            // labelIdVaga
            // 
            this.labelIdVaga.AutoSize = true;
            this.labelIdVaga.Location = new System.Drawing.Point(69, 207);
            this.labelIdVaga.Name = "labelIdVaga";
            this.labelIdVaga.Size = new System.Drawing.Size(46, 13);
            this.labelIdVaga.TabIndex = 9;
            this.labelIdVaga.Text = "ID Vaga";
            // 
            // buttonDesinscrever
            // 
            this.buttonDesinscrever.Location = new System.Drawing.Point(93, 260);
            this.buttonDesinscrever.Name = "buttonDesinscrever";
            this.buttonDesinscrever.Size = new System.Drawing.Size(90, 23);
            this.buttonDesinscrever.TabIndex = 10;
            this.buttonDesinscrever.Text = "Desinscrever";
            this.buttonDesinscrever.UseVisualStyleBackColor = true;
            this.buttonDesinscrever.Click += new System.EventHandler(this.ButtonDesinscrever_Click);
            // 
            // TesteVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDesinscrever);
            this.Controls.Add(this.labelIdVaga);
            this.Controls.Add(this.textBoxIdVaga);
            this.Controls.Add(this.textBoxIdAluno);
            this.Controls.Add(this.labelIdAluno);
            this.Controls.Add(this.buttonInscrever);
            this.Controls.Add(this.buttonAtt);
            this.Controls.Add(this.listBoxVagas);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxIdEmpresa);
            this.Controls.Add(this.buttonCriar);
            this.Name = "TesteVagas";
            this.Text = "TesteVagas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.TextBox textBoxIdEmpresa;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ListBox listBoxVagas;
        private System.Windows.Forms.Button buttonAtt;
        private System.Windows.Forms.Button buttonInscrever;
        private System.Windows.Forms.Label labelIdAluno;
        private System.Windows.Forms.TextBox textBoxIdAluno;
        private System.Windows.Forms.TextBox textBoxIdVaga;
        private System.Windows.Forms.Label labelIdVaga;
        private System.Windows.Forms.Button buttonDesinscrever;
    }
}