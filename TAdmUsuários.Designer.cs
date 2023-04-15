
namespace JobStack
{
    partial class TAdmUsuários
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
            this.components = new System.ComponentModel.Container();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botaoMinimizar = new System.Windows.Forms.PictureBox();
            this.botaoFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToOrderColumns = true;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NomeUsuario,
            this.emailUsuario,
            this.StatusUsuario});
            this.dataGridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuarios.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.Size = new System.Drawing.Size(618, 653);
            this.dataGridUsuarios.TabIndex = 0;
            this.dataGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(JobStack.Empresa);
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "ID";
            this.IdUsuario.Name = "IdUsuario";
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.HeaderText = "NOME";
            this.NomeUsuario.Name = "NomeUsuario";
            // 
            // emailUsuario
            // 
            this.emailUsuario.HeaderText = "E-MAIL";
            this.emailUsuario.Name = "emailUsuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridUsuarios);
            this.panel1.Location = new System.Drawing.Point(349, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 653);
            this.panel1.TabIndex = 1;
            // 
            // StatusUsuario
            // 
            this.StatusUsuario.HeaderText = "STATUS";
            this.StatusUsuario.Name = "StatusUsuario";
            // 
            // botaoMinimizar
            // 
            this.botaoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoMinimizar.Image = global::JobStack.Properties.Resources.botao_minimizar;
            this.botaoMinimizar.Location = new System.Drawing.Point(929, 12);
            this.botaoMinimizar.Name = "botaoMinimizar";
            this.botaoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botaoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoMinimizar.TabIndex = 8;
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
            this.botaoFechar.TabIndex = 7;
            this.botaoFechar.TabStop = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // TAdmUsuários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.botaoMinimizar);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.panel1);
            this.Name = "TAdmUsuários";
            this.Text = "TAdmUsuários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusUsuario;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox botaoMinimizar;
        private System.Windows.Forms.PictureBox botaoFechar;
    }
}