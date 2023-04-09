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
    }
}
