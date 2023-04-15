using System;
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
    public partial class TMenuAluno : Form
    {
        public TMenuAluno()
        {
            InitializeComponent();

            //Chamando os métodos para mover a tela de login a partir do clique do usuário
 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TMenuAluno_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TMenuAluno_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TMenuAluno_MouseUp);
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login p = new Login();
            p.ShowDialog();
        }

        //transforma a picturebox em um botão para fechar o programa sempre que usuário clicar
        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //faz a picture box ter a função de minimizar a janela sempre que o usuário clicar
        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Esse método vai definir o tamanho máximo e mínimo que o menu vertical vai possuir
        bool fundoMenuExpand;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fundoMenuExpand)
            {
                //se o menu está expandido/grande, esse comando vai encurtá-lo
                fundoMenu.Width -= 10;
                if(fundoMenu.Width == fundoMenu.MinimumSize.Width)
                {
                    fundoMenuExpand = false;
                    fundoMenuTimer.Stop();
                }
            }
            else
            {
                //se o menu está encurtado, isso vai expandi-lo
                fundoMenu.Width += 10;
                if(fundoMenu.Width == fundoMenu.MaximumSize.Width)
                {
                    fundoMenuExpand = true;
                    fundoMenuTimer.Stop();
                }
            }
        }

        //Esse botão vai ativar o timer que expande e diminui a barra de menu vertical
        private void botaoAbreMenu_Click(object sender, EventArgs e)
        {
            fundoMenuTimer.Start();
        }

        //Configurando a janela para se mover de acordo com o clique do usuario
        //A variavel dragging indica que o usuario está "segurando" a tela
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void TMenuAluno_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void TMenuAluno_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void TMenuAluno_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void botaoInscricoes_Click(object sender, EventArgs e)
        {

        }

        private void TMenuAluno_Load(object sender, EventArgs e)
        {
            //Faz com que a janela, ao ser maximizada, não oculte a barra de tarefa do windows
            Rectangle areaTrabalho = Screen.GetWorkingArea(this);
            this.MaximumSize = new Size(areaTrabalho.Width, areaTrabalho.Height);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login p = new Login();
            p.ShowDialog();
        }

        private void fundoMenu_StyleChanged(object sender, EventArgs e)
        {

        }

        private void fundoMenu_SizeChanged(object sender, EventArgs e)
        {
            // Obtém o tamanho da área cliente do Form
            var size = this.ClientSize;

            // Define a altura do FlowLayoutPanel para ocupar toda a área cliente
            this.fundoMenu.Height = size.Height;
        }

        //toda vez que o usuário passar o mouse em cima do botão, ele vai mudar a cor
        private void botaoPesquisar_MouseEnter(object sender, EventArgs e)
        {
            botaoPesquisar.BackColor = Color.FromArgb(72, 106, 208);
        }

        //toda vez que o usuário tirar o mouse de cima do botão, ele vai voltar ao normal
        private void botaoPesquisar_MouseLeave(object sender, EventArgs e)
        {
            botaoPesquisar.BackColor = Color.FromArgb(0, 31, 153);
        }

        //dá a função para a picturebox "botaoMaximizar" maximizar a janela
        private void botaoMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void botaoNotificacoes_MouseEnter(object sender, EventArgs e)
        {
            botaoNotificacoes.BackColor = Color.FromArgb(72, 106, 208);
        }

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

        private void botaoInscricoes_MouseEnter(object sender, EventArgs e)
        {
            botaoInscricoes.BackColor = Color.FromArgb(72, 106, 208);
        }

        private void botaoInscricoes_MouseLeave(object sender, EventArgs e)
        {
            botaoInscricoes.BackColor = Color.FromArgb(0, 31, 153);
        }

        private void botaoFavoritos_MouseEnter(object sender, EventArgs e)
        {
            botaoFavoritos.BackColor = Color.FromArgb(72, 106, 208);
        }

        private void botaoFavoritos_MouseLeave(object sender, EventArgs e)
        {
            botaoFavoritos.BackColor = Color.FromArgb(0, 31, 153);
        }

        private void botaoPerfil_MouseEnter(object sender, EventArgs e)
        {
            botaoPerfil.BackColor = Color.FromArgb(72, 106, 208);
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
    }

}
