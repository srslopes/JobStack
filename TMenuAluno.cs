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

        private void TMenuAluno_Load(object sender, EventArgs e)
        {

        }
        private void TMenuAluno_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
