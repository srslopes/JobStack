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
            // Esconder o campo de senha

            textBox2.Visible = false;
            // Desabilitar o campo de senha

            textBox2.Enabled = false;
            // Esconder a label de aviso

            label2.Visible = false;
            // Adicionar evento de clique ao botão
            button1.Click += Button1_Click1;
            // Esconder a senha digitada com asteriscos

            textBox2.PasswordChar = '*';
            // Esconder o botão 

            button2.Visible = false;
            // Esconder as labels 

            label3.Visible = false;
            label4.Visible = false;
            // Mudar o texto do botão para "Próximo"

            button1.Text = "Próximo";


        }
        // Variável de controle para saber se o botão já foi clicado antes

        private bool pvez = true;


        private void Button1_Click(object sender, EventArgs e)
        {


        }
        private void Button1_Click1(object sender, EventArgs e)
        {    // Obter o email digitado pelo usuário

            string email = textBox1.Text;
            Console.WriteLine("Email: " + email);

            // Buscar o ID do usuário no banco de dados

            int id = BancodeDados.BuscarID(email);
            // Verificar se o campo de email está vazio

            if (textBox1.Text == "")
            {
                label4.Visible = true;

                label4.Text = "Campo email vazio";

            }
            // Verificar se o usuário não está cadastrado

            else if (id == 0)

            {
                label4.Visible = true;

                label4.Text = "Usuario não cadastrado";

            }
            // Se for a primeira vez que o botão é clicado, exibir o campo de senha e mudar o texto do botão

            else

            {
                if (pvez)
                {
                    label4.Visible = false;
                    button1.Text = "Entrar";
                    // Chamar o método Email para exibir informações sobre o usuário

                    Email();
                    // Remover o evento de clique anterior e adicionar o novo evento

                    button1.Click -= Button1_Click1;

                    button1.Click += Button1_Click2;

                    // Atualizar a variável de controle para saber que o botão já foi clicado uma vez

                    pvez = false;




                }

            }
        }

        private void Button1_Click2(object sender, EventArgs e)
        {

            // Chamar o método Senha para validar a senha digitada

            Senha();
            // Se não for a primeira vez que o botão é clicado, remover o evento de clique atual e adicionar o evento anterior

            if (!pvez)
            {

                button1.Click += Button1_Click2;
                button1.Click -= Button1_Click2;

                button1.Click -= Button1_Click1;




                pvez = true;


            }



        }
        // Variável de controle para saber se as informações do usuário já foram exibidas

        private bool Emailm = false;
        private void Email()
        {
            // Obter o email digitado pelo usuário

            string email = textBox1.Text;
            Console.WriteLine("Email: " + email);
            // Buscar o ID do usuário no banco de dados

            int id = BancodeDados.BuscarID(email);
            // Exibir o email do usuário na label

            label1.Text = textBox1.Text;
            // Desabilita e esconde a primeira caixa de texto

            textBox1.Enabled = false;

            textBox1.Visible = false;
            // Mostra a segunda caixa de texto, o rótulo e o botão

            label2.Visible = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            button2.Visible = true;
            // Identifica o tipo de usuário com base em seu ID

            if (id / 1000 > 0 && id / 1000 < 6)
            {

                // Se for um aluno, exibe uma mensagem

                if (!Emailm)
                {
                    MessageBox.Show("Usuario é um aluno");
                    Emailm = true;
                }
            }
            else if (id / 1000 > 5)

            {

                // Se for uma empresa, exibe uma mensagem

                if (!Emailm)
                {
                    MessageBox.Show("Usuario é uma empresa");
                    Emailm = true;
                }

            }



            else if (id / 100 == 1)
            {
                // Se for um coordenador, exibe uma mensagem

                if (!Emailm)
                {
                    MessageBox.Show("Usuario é um Coordenador");
                    Emailm = true;
                }
            }
            else
            {
                // Se for um admin, exibe uma mensagem

                if (!Emailm)
                {
                    MessageBox.Show("Usuario é um Admin");
                    Emailm = true;
                }

            }

        }



        private void Senha()
        {    // Desassocia o evento Button1_Click1 do botão button1

            button1.Click -= Button1_Click1;
            // Associa o evento Button1_Click2 ao botão button1

            button1.Click += Button1_Click2;
            // Desassocia o evento Button1_Click2 do botão button1

            button1.Click -= Button1_Click2;
            // Define o texto do label1 como o texto inserido no textBox1

            label1.Text = textBox1.Text;
            // Torna o textBox1 invisível

            textBox1.Visible = false;
            // Torna o label2 visível

            label2.Visible = true;
            // Torna o textBox2 visível e habilitado

            textBox2.Visible = true;
            textBox2.Enabled = true;
            // Obtém o e-mail e a senha inseridos nos textBoxes

            string email = textBox1.Text;
            string senha = textBox2.Text;
            // Obtém o ID do usuário a partir do e-mail

            int id = BancodeDados.BuscarID(email);
            // Verifica se o campo senha está vazio e exibe uma mensagem de erro caso esteja

            if (textBox2.Text == "")
            {
                label3.Visible = true;
                label3.Text = "Campo senha vazio";

            }
            // Verifica se a senha inserida está incorreta e exibe uma mensagem de erro caso esteja

            else if (!BancodeDados.Login(id, senha))
            {
                label3.Visible = true;
                label3.Text = "Senha incorreta";
            }





            // Verifica se o usuário é um aluno e exibe a janela do formulário Aluno1

            else if (id / 1000 > 0 && id / 1000 < 6)
            {

                this.Hide();
                Aluno1 p = new Aluno1();

                p.ShowDialog();
            }





            // Verifica se o usuário é uma empresa e exibe a janela do formulário Empresa1

            else if (id / 1000 > 5)
            {
                this.Hide();

                Empresa1 p = new Empresa1();
                p.ShowDialog();
            }


            // Verifica se o usuário é um coordenador e exibe a janela do formulário Coordenador1

            else if (id / 100 == 1)
            {


                this.Hide();

                Coordenador1 p = new Coordenador1();
                p.ShowDialog();
            }


            else
            {

                this.Hide();

                Admin1 p = new Admin1();
                p.ShowDialog();
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
            Button1_Click1(sender, e);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}

