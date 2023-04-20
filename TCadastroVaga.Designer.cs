
namespace JobStack
{
    partial class TCadastroVaga
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
            this.botaoMinimizar = new System.Windows.Forms.PictureBox();
            this.botaoFechar = new System.Windows.Forms.PictureBox();
            this.tituloTela = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.Label();
            this.campoNomeVaga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoTipoVaga = new System.Windows.Forms.Label();
            this.comboBoxTipoVaga = new System.Windows.Forms.ComboBox();
            this.textoCursos = new System.Windows.Forms.Label();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.textoDescricao = new System.Windows.Forms.Label();
            this.campoDescricao = new System.Windows.Forms.TextBox();
            this.textoSalario = new System.Windows.Forms.Label();
            this.campoSalario = new System.Windows.Forms.TextBox();
            this.textoHorario = new System.Windows.Forms.Label();
            this.campoHorario = new System.Windows.Forms.TextBox();
            this.qtdeVaga = new System.Windows.Forms.NumericUpDown();
            this.textoQtdeVagas = new System.Windows.Forms.Label();
            this.textoRequisitos = new System.Windows.Forms.Label();
            this.campoRequisitos = new System.Windows.Forms.TextBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoCadVaga = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdeVaga)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoMinimizar
            // 
            this.botaoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoMinimizar.Image = global::JobStack.Properties.Resources.botao_minimizar;
            this.botaoMinimizar.Location = new System.Drawing.Point(881, 12);
            this.botaoMinimizar.Name = "botaoMinimizar";
            this.botaoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botaoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoMinimizar.TabIndex = 6;
            this.botaoMinimizar.TabStop = false;
            this.botaoMinimizar.Click += new System.EventHandler(this.botaoMinimizar_Click);
            // 
            // botaoFechar
            // 
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.Image = global::JobStack.Properties.Resources.botao_fechar;
            this.botaoFechar.Location = new System.Drawing.Point(923, 12);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(25, 25);
            this.botaoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoFechar.TabIndex = 5;
            this.botaoFechar.TabStop = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // tituloTela
            // 
            this.tituloTela.AutoSize = true;
            this.tituloTela.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTela.Location = new System.Drawing.Point(78, 22);
            this.tituloTela.Name = "tituloTela";
            this.tituloTela.Size = new System.Drawing.Size(228, 25);
            this.tituloTela.TabIndex = 7;
            this.tituloTela.Text = "CADASTRO DE VAGA";
            // 
            // textoNome
            // 
            this.textoNome.AutoSize = true;
            this.textoNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.Location = new System.Drawing.Point(79, 57);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(115, 19);
            this.textoNome.TabIndex = 8;
            this.textoNome.Text = "NOME/TÍTULO:";
            // 
            // campoNomeVaga
            // 
            this.campoNomeVaga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNomeVaga.Location = new System.Drawing.Point(200, 53);
            this.campoNomeVaga.Name = "campoNomeVaga";
            this.campoNomeVaga.Size = new System.Drawing.Size(479, 27);
            this.campoNomeVaga.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoTipoVaga
            // 
            this.textoTipoVaga.AutoSize = true;
            this.textoTipoVaga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTipoVaga.Location = new System.Drawing.Point(79, 93);
            this.textoTipoVaga.Name = "textoTipoVaga";
            this.textoTipoVaga.Size = new System.Drawing.Size(46, 19);
            this.textoTipoVaga.TabIndex = 11;
            this.textoTipoVaga.Text = "TIPO:";
            // 
            // comboBoxTipoVaga
            // 
            this.comboBoxTipoVaga.FormattingEnabled = true;
            this.comboBoxTipoVaga.Items.AddRange(new object[] {
            "Estágio",
            "Freelance",
            "Contratação"});
            this.comboBoxTipoVaga.Location = new System.Drawing.Point(131, 95);
            this.comboBoxTipoVaga.Name = "comboBoxTipoVaga";
            this.comboBoxTipoVaga.Size = new System.Drawing.Size(163, 21);
            this.comboBoxTipoVaga.TabIndex = 12;
            // 
            // textoCursos
            // 
            this.textoCursos.AutoSize = true;
            this.textoCursos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCursos.Location = new System.Drawing.Point(326, 93);
            this.textoCursos.Name = "textoCursos";
            this.textoCursos.Size = new System.Drawing.Size(153, 19);
            this.textoCursos.TabIndex = 13;
            this.textoCursos.Text = "ÁREA DE INTERESSE:";
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Items.AddRange(new object[] {
            "Análise e Desenvolvimento de Sistemas",
            "Gestão Empresarial",
            "Gestão Industrial",
            "Eventos"});
            this.comboBoxCursos.Location = new System.Drawing.Point(479, 95);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(254, 21);
            this.comboBoxCursos.TabIndex = 14;
            // 
            // textoDescricao
            // 
            this.textoDescricao.AutoSize = true;
            this.textoDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescricao.Location = new System.Drawing.Point(79, 130);
            this.textoDescricao.Name = "textoDescricao";
            this.textoDescricao.Size = new System.Drawing.Size(102, 19);
            this.textoDescricao.TabIndex = 15;
            this.textoDescricao.Text = "DESCRIÇÃO:";
            // 
            // campoDescricao
            // 
            this.campoDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescricao.Location = new System.Drawing.Point(83, 164);
            this.campoDescricao.Multiline = true;
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(449, 186);
            this.campoDescricao.TabIndex = 16;
            // 
            // textoSalario
            // 
            this.textoSalario.AutoSize = true;
            this.textoSalario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSalario.Location = new System.Drawing.Point(544, 164);
            this.textoSalario.Name = "textoSalario";
            this.textoSalario.Size = new System.Drawing.Size(135, 19);
            this.textoSalario.TabIndex = 17;
            this.textoSalario.Text = "FAIXA SALARIAL:";
            // 
            // campoSalario
            // 
            this.campoSalario.Location = new System.Drawing.Point(548, 186);
            this.campoSalario.Name = "campoSalario";
            this.campoSalario.Size = new System.Drawing.Size(173, 20);
            this.campoSalario.TabIndex = 18;
            // 
            // textoHorario
            // 
            this.textoHorario.AutoSize = true;
            this.textoHorario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoHorario.Location = new System.Drawing.Point(544, 219);
            this.textoHorario.Name = "textoHorario";
            this.textoHorario.Size = new System.Drawing.Size(84, 19);
            this.textoHorario.TabIndex = 19;
            this.textoHorario.Text = "HORÁRIO:";
            // 
            // campoHorario
            // 
            this.campoHorario.Location = new System.Drawing.Point(548, 241);
            this.campoHorario.Name = "campoHorario";
            this.campoHorario.Size = new System.Drawing.Size(173, 20);
            this.campoHorario.TabIndex = 20;
            this.campoHorario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // qtdeVaga
            // 
            this.qtdeVaga.Location = new System.Drawing.Point(548, 307);
            this.qtdeVaga.Name = "qtdeVaga";
            this.qtdeVaga.Size = new System.Drawing.Size(64, 20);
            this.qtdeVaga.TabIndex = 21;
            // 
            // textoQtdeVagas
            // 
            this.textoQtdeVagas.AutoSize = true;
            this.textoQtdeVagas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoQtdeVagas.Location = new System.Drawing.Point(544, 275);
            this.textoQtdeVagas.Name = "textoQtdeVagas";
            this.textoQtdeVagas.Size = new System.Drawing.Size(265, 19);
            this.textoQtdeVagas.TabIndex = 22;
            this.textoQtdeVagas.Text = "QUANTIDADE DE VAGAS ABERTAS:";
            // 
            // textoRequisitos
            // 
            this.textoRequisitos.AutoSize = true;
            this.textoRequisitos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRequisitos.Location = new System.Drawing.Point(79, 373);
            this.textoRequisitos.Name = "textoRequisitos";
            this.textoRequisitos.Size = new System.Drawing.Size(183, 19);
            this.textoRequisitos.TabIndex = 23;
            this.textoRequisitos.Text = "REQUISITOS (opcional):";
            this.textoRequisitos.Click += new System.EventHandler(this.textoRequisitos_Click);
            // 
            // campoRequisitos
            // 
            this.campoRequisitos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRequisitos.Location = new System.Drawing.Point(83, 412);
            this.campoRequisitos.Multiline = true;
            this.campoRequisitos.Name = "campoRequisitos";
            this.campoRequisitos.Size = new System.Drawing.Size(479, 141);
            this.campoRequisitos.TabIndex = 24;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(687, 565);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 25;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botaoCadVaga
            // 
            this.botaoCadVaga.Location = new System.Drawing.Point(849, 565);
            this.botaoCadVaga.Name = "botaoCadVaga";
            this.botaoCadVaga.Size = new System.Drawing.Size(87, 23);
            this.botaoCadVaga.TabIndex = 26;
            this.botaoCadVaga.Text = "Criar vaga";
            this.botaoCadVaga.UseVisualStyleBackColor = true;
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(768, 565);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 27;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // TCadastroVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoCadVaga);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.campoRequisitos);
            this.Controls.Add(this.textoRequisitos);
            this.Controls.Add(this.textoQtdeVagas);
            this.Controls.Add(this.qtdeVaga);
            this.Controls.Add(this.campoHorario);
            this.Controls.Add(this.textoHorario);
            this.Controls.Add(this.campoSalario);
            this.Controls.Add(this.textoSalario);
            this.Controls.Add(this.campoDescricao);
            this.Controls.Add(this.textoDescricao);
            this.Controls.Add(this.comboBoxCursos);
            this.Controls.Add(this.textoCursos);
            this.Controls.Add(this.comboBoxTipoVaga);
            this.Controls.Add(this.textoTipoVaga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoNomeVaga);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.tituloTela);
            this.Controls.Add(this.botaoMinimizar);
            this.Controls.Add(this.botaoFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCadastroVaga";
            this.Text = "TCadastroVaga";
            ((System.ComponentModel.ISupportInitialize)(this.botaoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdeVaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox botaoMinimizar;
        private System.Windows.Forms.PictureBox botaoFechar;
        private System.Windows.Forms.Label tituloTela;
        private System.Windows.Forms.Label textoNome;
        private System.Windows.Forms.TextBox campoNomeVaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textoTipoVaga;
        private System.Windows.Forms.ComboBox comboBoxTipoVaga;
        private System.Windows.Forms.Label textoCursos;
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.Label textoDescricao;
        private System.Windows.Forms.TextBox campoDescricao;
        private System.Windows.Forms.Label textoSalario;
        private System.Windows.Forms.TextBox campoSalario;
        private System.Windows.Forms.Label textoHorario;
        private System.Windows.Forms.TextBox campoHorario;
        private System.Windows.Forms.NumericUpDown qtdeVaga;
        private System.Windows.Forms.Label textoQtdeVagas;
        private System.Windows.Forms.Label textoRequisitos;
        private System.Windows.Forms.TextBox campoRequisitos;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoCadVaga;
        private System.Windows.Forms.Button botaoLimpar;
    }
}