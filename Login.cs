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
            // Executa o método Passo1()

            Passo1();

         
        }
        private void Passo1()
        {
            // Método Passo1() que define a interface do login

            // Esconder o campo de senha
            campoSenha.Visible = false;

            // Desabilitar o campo de senha
            campoSenha.Enabled = false;

            // Esconder a label de aviso
            campoEmail.Visible = true;
            campoEmail.Enabled = true;
            textoEmail.Visible = true;
            textoEmail.Enabled = true;

            // Limpar os campos de email e senha
            campoEmail.Text = "";
            textoEmail.Text = "Email";
            campoSenha.Text = "";

            // Esconder a label de condição da senha
            textoSenha.Visible = false;
            CondicaoSenha.Text = " ";

            // Limpar a label de condição do email
            CondicaoEmail.Text = "";

            // Adicionar evento de clique ao botão

            // Esconder a senha digitada com asteriscos
            campoSenha.PasswordChar = '*';

            // Esconder o botão de voltar
            botaoVoltar.Visible = false;

            // Esconder as labels de condição de senha e email
            CondicaoSenha.Visible = false;
            CondicaoEmail.Visible = false;

            // Mudar o texto do botão para "Próximo"
            BotaoLogin.Visible = false;
            BotaoLogin.Enabled = false;
            BotaoProximo.Visible = true;
            BotaoProximo.Enabled = true;

        }



        
        

        private void Button1_Click2(object sender, EventArgs e)
        {

            // Chamar o método Senha para validar a senha digitada

            // Se não for a primeira vez que o botão é clicado, remover o evento de clique atual e adicionar o evento anterior

               



        }
        
        private void Email()
        {
            // Obter o email digitado pelo usuário e exibir no console
            string email = campoEmail.Text;
            Console.WriteLine("Email: " + email);

            // Buscar o ID do usuário no banco de dados
            int id = BancodeDados.BuscarID(email);

            // Exibir o email do usuário na label
            textoEmail.Text = campoEmail.Text;

            // Desabilita e esconde a primeira caixa de texto
            campoEmail.Enabled = false;
            campoEmail.Visible = false;

            // Mostra a segunda caixa de texto, o rótulo e o botão
            textoSenha.Visible = true;
            campoSenha.Visible = true;
            campoSenha.Enabled = true;
            botaoVoltar.Visible = true;

            // Verifica se o campo de email está vazio
            if (email.Equals(""))
            {
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Campo email vazio";
            }
            // Verificar se o usuário não está cadastrado
            else if (id == 0)
            {
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Usuario não cadastrado";
            }
            // Se o usuário está cadastrado, identifica o tipo de usuário com base em seu ID
            else
            {
                // Esconde o botão "Próximo" e mostra o botão "Login"
                BotaoProximo.Visible = false;
                BotaoProximo.Enabled = false;
                BotaoLogin.Visible = true;
                BotaoLogin.Enabled = true;

                // Verifica o tipo de usuário
                if (id / 1000 > 0 && id / 1000 < 6)
                {
                    // Se for um aluno, exibe uma mensagem
                 
                     //   MessageBox.Show("Usuario é um aluno");
                     
                }
                else if (id / 1000 > 5)
                {
                    // Se for uma empresa, exibe uma mensagem
                 
                       // MessageBox.Show("Usuario é uma empresa");
                   
                }
                else if (id / 100 == 1)
                {
                    // Se for um coordenador, exibe uma mensagem
                  
                      //  MessageBox.Show("Usuario é um Coordenador");
                       
                }
                else
                {
                    // Se for um admin, exibe uma mensagem
                   
                      //  MessageBox.Show("Usuario é um Admin");
                    
                }
            }
        }



                private void Senha()
        {     // Exibe o e-mail digitado pelo usuário na label correspondente
            textoEmail.Text = campoEmail.Text;

            // Esconde o campo de texto do e-mail
            campoEmail.Visible = false;

            // Exibe o campo de texto da senha
            textoSenha.Visible = true;

            // Torna o campo de texto da senha visível e habilitado
            campoSenha.Visible = true;
            campoSenha.Enabled = true;

            // Obtém o e-mail e a senha inseridos nos campos de texto
            string email = campoEmail.Text;
            string senha = campoSenha.Text;

            // Obtém o ID do usuário a partir do e-mail inserido
            int id = BancodeDados.BuscarID(email);

            // Verifica se o campo senha está vazio e exibe uma mensagem de erro caso esteja
            if (campoSenha.Text == "")
            {
                CondicaoSenha.Visible = true;
                CondicaoSenha.Text = "Campo senha vazio";
            }

            // Verifica se a senha inserida está incorreta e exibe uma mensagem de erro caso esteja
            else if (!BancodeDados.Login(senha))
            {
                CondicaoSenha.Visible = true;
                CondicaoSenha.Text = "Senha incorreta";
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
                TEmpresa p = new TEmpresa();
                p.ShowDialog();
            }

            // Verifica se o usuário é um coordenador e exibe a janela do formulário Coordenador1
            else if (id / 100 == 1)
            {
                this.Hide();
                TCoordenador p = new TCoordenador();
                p.ShowDialog();
            }

            // Se não for nenhum dos tipos anteriores, exibe a janela do formulário TAdmin
            else
            {
                this.Hide();
                TAdmin p = new TAdmin();
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

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       

        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            Senha();
        }

        private void BotaoProximo_Click(object sender, EventArgs e)
        {
            

            // Obter o email digitado pelo usuário
            string email = campoEmail.Text;
            Console.WriteLine("Email: " + email);

            // Buscar o ID do usuário no banco de dados
            int id = BancodeDados.BuscarID(email);

            // Verificar se o campo de email está vazio
            if (email.Equals(""))
            {
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Campo email vazio";
            }
            // Verificar se o usuário não está cadastrado
            else if (id == 0)
            {
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Usuario não cadastrado";
            }
            // Se for a primeira vez que o botão é clicado, exibir o campo de senha e mudar o texto do botão
            else
            {
                CondicaoEmail.Visible = false;
                // Chamar o método Email para exibir informações sobre o usuário
                Email();
                // Remover o evento de clique anterior e adicionar o novo evento
                // Atualizar a variável de controle para saber que o botão já foi clicado uma vez
            }
        
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            Passo1();
        }
    }
}

