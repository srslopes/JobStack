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
    public partial class TesteDB : Form
    {
        bool car = false;
        public TesteDB()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(!BancodeDados.CriarAluno(textBox1.Text, textBox2.Text))
            {
                label3.Text = "Usuario ja existe";
            }
            AtualizarLista();
            ///
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void AtualizarLista()
        {
            textBox3.Text = BancodeDados.ExibirAlunos();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Aluno al = new Aluno();
            al = BancodeDados.BuscarAluno(textBox1.Text);
            textBox1.Text = al.GetEmail();
            textBox2.Text = al.GetSenha();
            car = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(car)
            {
                Aluno al = new Aluno(textBox1.Text, textBox2.Text);
                BancodeDados.SalvarAluno(al);
                AtualizarLista();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BancodeDados.ExcluirAluno(BancodeDados.BuscarAluno(textBox1.Text));
            AtualizarLista();
        }
    }
}
