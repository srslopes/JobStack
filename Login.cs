using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
          
            textBox2.PasswordChar = '*';
            button2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button1.Text = "Próximo";
            button2.Click += new EventHandler(botaoRetornar_Click);


        }

        private bool pvez = true;


    private void Button1_Click(object sender, EventArgs e)
        {


        }
        private void Button1_Click1(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            Console.WriteLine("Email: " + email);


            int id = BancodeDados.BuscarID(email);
            if (textBox1.Text == "")
            {
                label4.Visible = true;

                label4.Text="Campo email vazio";

            }
          
             else if (id==0)

            {
                label4.Visible = true;

                label4.Text = "Usuario não cadastrado";

            }
            else
            {
                if (pvez)
                {
                    label4.Visible = false;
                    button1.Text = "Entrar";

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
            {

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
            int id = BancodeDados.BuscarID(email);
            label1.Text = textBox1.Text;
            textBox1.Enabled = false;

            textBox1.Visible = false;
            label2.Visible = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            button2.Visible = true;

            if (id / 1000 > 0 && id / 1000 < 6)
            {
               

                if (!Emailm)
                {
                    MessageBox.Show("Usuario é um aluno");
                    Emailm = true;
                }
            }
            else if (id / 1000 > 5)

            {
                

                if (!Emailm)
                {
                    MessageBox.Show("Usuario é uma empresa");
                    Emailm = true;
                }

            }



            else if (id / 100 == 1)
            {
               
                if (!Emailm)
                {
                    MessageBox.Show("Usuario é um Coordenador");
                    Emailm = true;
                }
            }
            else
            {

                if (!Emailm)
                {
                    MessageBox.Show("Usuario é um Admin");
                    Emailm = true;
                }

            }

        }



        private void Senha()
        {
            button1.Click -= Button1_Click1;

            button1.Click += Button1_Click2;
            button1.Click -= Button1_Click2;
            label1.Text = textBox1.Text;
            textBox1.Visible = false;
            label2.Visible = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            string email = textBox1.Text;
            string senha = textBox2.Text;

            int id = BancodeDados.BuscarID(email);
            if (textBox2.Text == "")
            {
                label3.Visible = true;
                label3.Text = "Campo senha vazio";

            }
           if (BancodeDados.Login(id, senha))
            {






                if (id / 1000 > 0 && id / 1000 < 6)
                {


                    Aluno1 p = new Aluno1();

                    p.ShowDialog();
                }






                if (id / 1000 > 5)
                {

                    Empresa1 p = new Empresa1();
                    p.ShowDialog();
                }



                else if (id / 100 == 1)
                {



                    Coordenador1 p = new Coordenador1();
                    p.ShowDialog();
                }


               else if( id / 100 == 0)
                {


                    Admin1 p = new Admin1();
                    p.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void botaoRetornar_Click(object sender,EventArgs e)
        {
            string email = textBox1.Text;
            Console.WriteLine("Email: " + email);


            int id = BancodeDados.BuscarID(email);
            if (textBox1.Text == "")
            {
                label4.Visible = true;

                label4.Text = "Campo email vazio";

            }

            else if (id == 0)

            {
                label4.Visible = true;

                label4.Text = "Usuario não cadastrado";

            }
            else
            {
                if (pvez)
                {
                    label4.Visible = false;
                    button1.Text = "Entrar";

                    Email();

                    button1.Click -= Button1_Click1;

                    button1.Click += Button1_Click2;


                    pvez = false;




                }

            }
        }
    }
}
