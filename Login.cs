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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "E-mail";
            string email = textBox1.Text;
            string senha = textBox2.Text;
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Senha: " + senha);
            try
            {
                if (BancodeDados.BuscarAluno(email).GetSenha().Equals(textBox2.Text)) MessageBox.Show  ("Sucesso");
                else label1.Text = "Fracasso 1";
               
            }
            catch (System.NullReferenceException)
            {
                label1.Text = "Fracasso 2";
            }

            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Aluno chn = new Aluno("a");
            BancodeDados.BuscarAluno("a");
            chn.SetEmail("j");
            chn.SetSenha("564");
            BancodeDados.SalvarAluno(chn);
            BancodeDados.ExibirAlunos();
            //textBox3.Text = BancodeDados.BuscarAluno("a").GetSenha();
        }
    }
}
