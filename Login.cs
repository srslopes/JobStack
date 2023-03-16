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

           label2.Visible = false;
            textBox2.Visible = false;
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "E-mail";

            string email = textBox1.Text;
                Console.WriteLine("Email: " + email);

            label2.Text = "Senha";

            string senha = textBox2.Text;
            Console.WriteLine("Senha " + senha);


            switch (BancodeDados.Login(email))
                {
                    case 0:
                        MessageBox.Show("Usuario não cadastrado");

                        break;
                    case 1:
                        MessageBox.Show("Usuario é um aluno");
                    label1.Visible = false;
                    textBox1.Visible = false;

                    label2.Visible = true;
                    textBox2.Visible = true;
                    

                    break;
                    case 2:
                        MessageBox.Show("Usuario é uma empresa");
                    label1.Visible = false;
                    textBox1.Visible = false;

                    label2.Visible = true;
                    textBox2.Visible = true;
                 
                    break;
                    case 3:
                        MessageBox.Show("Usuario é um administrador");
                    label1.Visible = false;
                    textBox1.Visible = false;

                    label2.Visible = true;
                    textBox2.Visible = true;
                    
                    break;
                    case 4:
                        MessageBox.Show("Usuario é um coordenador");
                    label1.Visible = false;
                    textBox1.Visible = false;

                    label2.Visible = true;
                    textBox2.Visible = true;
               
                    break;
              

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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
