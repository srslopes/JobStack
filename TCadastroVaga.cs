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
    public partial class TCadastroVaga : Form
    {
        public TCadastroVaga()
        {
            InitializeComponent();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {

        }

        //esse botão limpa os campos de texto
        private void botaoLimpar_Click(object sender, EventArgs e)
        {

        }

        private void textoRequisitos_Click(object sender, EventArgs e)
        {

        }
    }
}
