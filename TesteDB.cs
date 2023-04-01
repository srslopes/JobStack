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
        Empresa empresa;
        Admin admin;
        Coordenador coordenador;
        public TesteDB()
        {
            InitializeComponent();
            AttLista();
            comboBox1.Items.Add("Aluno");
            comboBox1.Items.Add("Empresa");
            comboBox1.Items.Add("Coordenador");
            comboBox1.Items.Add("Admin");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Aluno":
                    Aluno n1 = new Aluno(textBox1.Text, textBox2.Text);
                    if (!BancodeDados.AdicionarUsuario(n1)) label3.Text = "Usuario ja existe";
                    break;
                case "Empresa":
                    Empresa n2 = new Empresa(textBox1.Text, textBox2.Text);
                    if (!BancodeDados.AdicionarUsuario(n2)) label3.Text = "Usuario ja existe";
                    break;
                case "Coordenador":
                    Coordenador n3 = new Coordenador(textBox1.Text, textBox2.Text);
                    if (!BancodeDados.AdicionarUsuario(n3)) label3.Text = "Usuario ja existe";
                    break;
                case "Admin":
                    Admin n4 = new Admin(textBox1.Text, textBox2.Text);
                    if (!BancodeDados.AdicionarUsuario(n4)) label3.Text = "Usuario ja existe";
                    break;
            }
            
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
            if (id / 1000 > 5)
            {
                empresa = (Empresa)BancodeDados.BuscarUsuario(id);
                textBox4.Text = "" + empresa.GetID();
                textBox1.Text = empresa.GetEmail();
                textBox2.Text = empresa.GetSenha();
            }
            else if (id / 1000 > 0)
            {
                aluno = (Aluno)BancodeDados.BuscarUsuario(id);
                textBox4.Text = "" + aluno.GetID();
                textBox1.Text = aluno.GetEmail();
                textBox2.Text = aluno.GetSenha();
            }
            else if (id / 100 == 1)
            {
                coordenador = (Coordenador)BancodeDados.BuscarUsuario(id);
                textBox4.Text = "" + coordenador.GetID();
                textBox1.Text = coordenador.GetEmail();
                textBox2.Text = coordenador.GetSenha();
            }
            else
            {
                admin = (Admin)BancodeDados.BuscarUsuario(id);
                textBox4.Text = "" + admin.GetID();
                textBox1.Text = admin.GetEmail();
                textBox2.Text = admin.GetSenha();
            }

            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int id = BancodeDados.GetIdUser();
            if (id / 1000 > 5)
            {
                empresa.SetEmail(textBox1.Text);
                empresa.SetSenha(textBox2.Text);
            }
            else if (id / 1000 > 0)
            {
                aluno.SetEmail(textBox1.Text);
                aluno.SetSenha(textBox2.Text);
            }
            else if (id / 100 == 1)
            {
                coordenador.SetEmail(textBox1.Text);
                coordenador.SetSenha(textBox2.Text);
            }
            else if (id / 100 ==0)
            {
                admin.SetEmail(textBox1.Text);
                admin.SetSenha(textBox2.Text);
            }

            
            AttLista();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AttLista();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AttLista();            
        }
        public void AttLista()
        {
            listBox1.Items.Clear();
            string[] lista = BancodeDados.ExibirDB().Split('?');
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
