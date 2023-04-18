using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStack.Testes
{
    public partial class ListaConv : Form
    {
        public ListaConv(int participante)
        {
            InitializeComponent();
            labelNome.Text = ((Usuario)BancodeDados.BuscarUsuario(participante)).GetEmail();
        }
    }
}
