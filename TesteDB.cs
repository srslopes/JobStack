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
        
        Aluno aluno;
        public TesteDB()
        {
            InitializeComponent();
            AttLista();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Aluno novo = new Aluno(textBox1.Text, textBox2.Text);
            if(!BancodeDados.AdicionarAluno(novo)) label3.Text = "Usuario ja existe";
            AttLista();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            AttLista();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox4.Text);
            aluno = BancodeDados.BuscarAluno(id);
            textBox4.Text = "" +aluno.GetID();
            textBox1.Text =  aluno.GetEmail();
            textBox2.Text = aluno.GetSenha();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            aluno.SetEmail(textBox1.Text);
            aluno.SetSenha(textBox2.Text);
            BancodeDados.SalvarUsuario(aluno);
            AttLista();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BancodeDados.ExcluirUsuario(aluno.GetID());
            AttLista();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AttLista();            
        }
        public void AttLista()
        {
            listBox1.Items.Clear();
            string[] lista = BancodeDados.ExibirAlunos().Split('?');
            for (int i = 0; i < lista.Length; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
