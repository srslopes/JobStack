using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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

            textBox2.Visible = false;

            textBox2.Enabled = false;

            label2.Visible = false;
            button1.Click += Button1_Click1;
          
            textBox2.PasswordChar = "*";


        }

        private bool pvez = true;


    private void Button1_Click(object sender, EventArgs e)
        {


        }
        private void Button1_Click1(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            Console.WriteLine("Email: " + email);

            
            int usuario = BancodeDados.Login(email);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Campo email vazio");

            }
          
             else if (usuario == 0)
            {
                MessageBox.Show("Usuario nao cadastrado");

            }
            else
            {
                if (pvez)
                {
                    Email();

                    button1.Click -= Button1_Click1;

                    button1.Click += Button1_Click2;


                    pvez = false;




                }

            }
        }

        private void Button1_Click2(object sender, EventArgs e)
        {


            Senha();
            if (!pvez)
            {z

                button1.Click += Button1_Click2;
                button1.Click -= Button1_Click2;

                button1.Click -= Button1_Click1;




                pvez = true;


            }
      


        }
        private bool Emailm = false;
        private void Email()
        {

            string email = textBox1.Text;
            Console.WriteLine("Email: " + email);



            int usuario = BancodeDados.Login(email);
            switch (usuario)
            {
                case 1:
                    label1.Enabled = false;
                    textBox1.Enabled = false;
                    label1.Visible = false;
                    textBox1.Visible = false;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    textBox2.Enabled = true;
                    if (!Emailm)
                    {
                        MessageBox.Show("Usuario é um aluno");
                        Emailm = true;
                    }
                    break;
                case 2:
                    label1.Enabled = false;
                    textBox1.Enabled = false;
                    label1.Visible = false;
                    textBox1.Visible = false;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    textBox2.Enabled = true;

                    if (!Emailm)
                    {
                        MessageBox.Show("Usuario é uma empresa");
                        Emailm = true;
                    }

                    break;
                case 3:
                    label1.Enabled = false;
                    textBox1.Enabled = false;
                    label1.Visible = false;
                    textBox1.Visible = false;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    textBox2.Enabled = true;

                    if (!Emailm)
                    {
                        MessageBox.Show("Usuario é um Admin");
                        Emailm = true;
                    }

                    break;
                case 4:
                    label1.Enabled = false;
                    textBox1.Enabled = false;
                    label1.Visible = false;
                    textBox1.Visible = false;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    textBox2.Enabled = true;

                    if (!Emailm)
                    {
                        MessageBox.Show("Usuario é um Coordenador");
                        Emailm = true;
                    }

                    break;


            }
        }


        private void Senha()
        {
            button1.Click -= Button1_Click1;

            button1.Click += Button1_Click2;
            button1.Click -= Button1_Click2;

            if (textBox2.Text == "")
            {
                MessageBox.Show(" campo senha vazio");
            }
            else
            {
                string email = textBox1.Text;







                int usuario = BancodeDados.Login(email);


                switch (usuario)
                {
                    case 1:
                        label1.Enabled = false;
                        textBox1.Enabled = false;
                        label1.Visible = false;
                        textBox1.Visible = false;
                        label2.Visible = true;
                        textBox2.Visible = true;
                        textBox2.Enabled = true;

                        if (BancodeDados.BuscarAluno(email).GetSenha().Equals(textBox2.Text))
                        {

                            MessageBox.Show("sucesso");
                            Aluno1 p = new Aluno1();
                            p.ShowDialog();
                        }

                        else
                        {
                            label1.Enabled = false;
                            textBox1.Enabled = false;
                            label1.Visible = false;
                            textBox1.Visible = false;
                            label2.Visible = true;
                            textBox2.Visible = true;
                            textBox2.Enabled = true;

                            MessageBox.Show("erro");

                        }

                        break;
                    case 2:
                        label1.Enabled = false;
                        textBox1.Enabled = false;
                        label1.Visible = false;
                        textBox1.Visible = false;
                        label2.Visible = true;
                        textBox2.Visible = true;
                        textBox2.Enabled = true;

                        if (BancodeDados.BuscarEmpresa(email).GetSenha().Equals(textBox2.Text))
                        {

                            MessageBox.Show("sucesso");
                            Aluno1 p = new Aluno1();
                            p.ShowDialog();
                        }
                        else if (textBox2.Text == "")
                        {
                            MessageBox.Show(" campo senha vazio");
                        }
                        else
                        {
                            label1.Enabled = false;
                            textBox1.Enabled = false;
                            label1.Visible = false;
                            textBox1.Visible = false;
                            label2.Visible = true;
                            textBox2.Visible = true;
                            textBox2.Enabled = true;
                            MessageBox.Show("erro");

                        }

                        break;
                    case 3:
                        label1.Enabled = false;
                        textBox1.Enabled = false;
                        label1.Visible = false;
                        textBox1.Visible = false;
                        label2.Visible = true;
                        textBox2.Visible = true;
                        textBox2.Enabled = true;
                        if (BancodeDados.BuscarAdmin(email).GetSenha().Equals(textBox2.Text))
                        {

                            MessageBox.Show("sucesso");
                            Aluno1 p = new Aluno1();
                            p.ShowDialog();
                        }
                        else if (textBox2.Text == "")
                        {
                            MessageBox.Show(" campo senha vazio");
                        }
                        else
                        {
                            label1.Enabled = false;
                            textBox1.Enabled = false;
                            label1.Visible = false;
                            textBox1.Visible = false;
                            label2.Visible = true;
                            textBox2.Visible = true;
                            textBox2.Enabled = true;
                            MessageBox.Show("erro");

                        }

                        break;
                    case 4:

                        label1.Enabled = false;
                        textBox1.Enabled = false;
                        label1.Visible = false;
                        textBox1.Visible = false;
                        label2.Visible = true;
                        textBox2.Visible = true;
                        textBox2.Enabled = true;
                        if (BancodeDados.BuscarCoordenador(email).GetSenha().Equals(textBox2.Text))
                        {

                            MessageBox.Show("sucesso");
                            Aluno1 p = new Aluno1();
                            p.ShowDialog();
                        }
                        else if (textBox2.Text == "")
                        {
                            MessageBox.Show(" campo senha vazio");
                        }
                        else
                        {
                            label1.Enabled = false;
                            textBox1.Enabled = false;
                            label1.Visible = false;
                            textBox1.Visible = false;
                            label2.Visible = true;
                            textBox2.Visible = true;
                            textBox2.Enabled = true;
                            MessageBox.Show("erro");

                        }

                        break;
                }
            }
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }

       
    }
}
