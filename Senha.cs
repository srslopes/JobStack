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
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Senha";
            string senha = textBox1.Text;
            Console.WriteLine("Senha " + senha);
            Aluno1 p = new Aluno1();
            this.Hide();

            p.ShowDialog();

        }
    }
}
