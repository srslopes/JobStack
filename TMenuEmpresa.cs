﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStack
{
    public partial class TMenuEmpresa : Form
    {
        public TMenuEmpresa()
        {
            InitializeComponent();


            //Chamando os métodos para mover a tela de login a partir do clique do usuário
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TMenuEmpresa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TMenuEmpresa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TMenuEmpresa_MouseUp);
        }

        //Faz aparecer um form dentro do panel "panelprincipal"
        public void abrirForms(object Form)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form x = Form as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(x);
            this.panelprincipal.Tag = x;
            x.Show();
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login p = new Login();
            p.ShowDialog();
        }

        //Configurando a janela para expandir e diminuir o menu vertical
        bool fundoMenuExpand;
        private void fundoMenuTimer_Tick(object sender, EventArgs e)
        {
            if (fundoMenuExpand)
            {
                //se o menu está expandido/grande, esse comando vai encurtá-lo
                fundoMenu.Width -= 10;
                if (fundoMenu.Width == fundoMenu.MinimumSize.Width)
                {
                    fundoMenuExpand = false;
                    fundoMenuTimer.Stop();
                }
            }
            else
            {
                //se o menu está encurtado, isso vai expandi-lo
                fundoMenu.Width += 10;
                if (fundoMenu.Width == fundoMenu.MaximumSize.Width)
                {
                    fundoMenuExpand = true;
                    fundoMenuTimer.Stop();
                }
            }
        }

        //Ativa o botaoAbreMenu para expandir ou diminuir o menu
        private void botaoAbreMenu_Click(object sender, EventArgs e)
        {
            fundoMenuTimer.Start();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Configurando a janela para se mover de acordo com o clique do usuario
        //A variavel dragging indica que o usuario está "segurando" a tela
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void TMenuEmpresa_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void TMenuEmpresa_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void TMenuEmpresa_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void botaoLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login p = new Login();
            p.ShowDialog();
        }

        //toda vez que o usuário passar o mouse em cima do botão, ele vai mudar a cor
        private void botaoNotificacoes_MouseEnter(object sender, EventArgs e)
        {
            botaoNotificacoes.BackColor = Color.FromArgb(72, 106, 208);
        }

        //toda vez que o usuário tirar o mouse de cima do botão, ele vai voltar ao normal
        private void botaoNotificacoes_MouseLeave(object sender, EventArgs e)
        {
            botaoNotificacoes.BackColor = Color.FromArgb(0, 31, 153);
        }

        private void botaoChat_MouseEnter(object sender, EventArgs e)
        {
            botaoChat.BackColor = Color.FromArgb(72, 106, 208);
        }

        private void botaoChat_MouseLeave(object sender, EventArgs e)
        {
            botaoChat.BackColor = Color.FromArgb(0, 31, 153);
        }

        private void botaoVagas_MouseEnter(object sender, EventArgs e)
        {
            botaoVagas.BackColor = Color.FromArgb(72, 106, 208);
        }

        private void botaoVagas_MouseLeave(object sender, EventArgs e)
        {
            botaoVagas.BackColor = Color.FromArgb(0, 31, 153);
        }

        private void botaoPerfil_MouseEnter(object sender, EventArgs e)
        {
            botaoPerfil.BackColor = Color.FromArgb(72, 106, 208);
        }

        private void botaoPerfil_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void botaoPerfil_MouseLeave(object sender, EventArgs e)
        {
            botaoPerfil.BackColor = Color.FromArgb(0, 31, 153);
        }

        private void botaoLogout_MouseEnter(object sender, EventArgs e)
        {
            botaoLogout.BackColor = Color.FromArgb(72, 106, 208);
        }

        private void botaoLogout_MouseLeave(object sender, EventArgs e)
        {
            botaoLogout.BackColor = Color.FromArgb(0, 31, 153);
        }

        //chama o forms correspondente do botão
        private void botaoNotificacoes_Click(object sender, EventArgs e)
        {
            abrirForms(new TEmpresaNotificacoes());
        }

        //chama o forms correspondente do botão
        private void botaoChat_Click(object sender, EventArgs e)
        {
            abrirForms(new TEmpresaChat());
        }

        //chama o forms correspondente do botão
        private void botaoVagas_Click(object sender, EventArgs e)
        {
            abrirForms(new TCadastroVaga());
        }

        //chama o forms correspondente do botão
        private void botaoPerfil_Click(object sender, EventArgs e)
        {
            abrirForms(new TEmpresaVagas());
        }
    }
}
