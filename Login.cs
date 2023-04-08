
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
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

            //Chamando os métodos para mover a tela de login a partir do clique do usuário
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
        }
        // declaração da variavel ListViewItem com nome  lvItem


        private ListViewItem lvItem;

        // Método Passo1() que realiza várias configurações iniciais do formulário
        private void Passo1()
        {
            // Define o botão padrão do formulário como BotaoProximo
            this.AcceptButton = BotaoProximo;

            // Define o botão padrão do formulário como BotaoLogin quando o campo de senha recebe o foco
            campoSenha.Enter += (sender, e) => { this.AcceptButton = BotaoLogin; };
            campoSenha.Leave += (sender, e) => { this.AcceptButton = BotaoProximo; };

            // Limpa os campos de email e senha
            campoEmail.Text = "";
            textoEmail.Text = "Email";
            campoSenha.Text = "";

            // Esconde as mensagens de erro relacionadas ao email e senha
            CondicaoEmail.Visible = false;
            CondicaoSenha.Visible = false;

            // Define o caracter utilizado para representar a senha como um asterisco
            campoSenha.PasswordChar = '*';
        }

        // Evento de clique do botão Button1
        private void Button1_Click2(object sender, EventArgs e)
        {
            // Este método não faz nada
        }

        // Método para inicializar o combobox de erro
        private void InicializarComboBox()
        {
            // Verifica se o combobox já possui itens antes de adicioná-los
            if (erro.Items.Count == 0)
            {
                // Adiciona os itens "Esqueci meu email", "Esqueci minha senha" e "Solicitar cadastro"
                erro.Items.Add("Esqueci meu email");
                erro.Items.Add("Esqueci minha senha ");
                erro.Items.Add("Solicitar cadastro ");
            }
        }

        // Método para validar o email inserido pelo usuário
        private void Email()
        {
            // Obtém o email digitado pelo usuário e exibe no console
            string email = campoEmail.Text;
            Console.WriteLine("Email: " + email);

            // Busca o ID do usuário no banco de dados
            int id = BancodeDados.BuscarID(email);

            // Verifica se o campo de email está vazio
            if (email.Equals(""))
            {
                // Exibe uma mensagem de erro indicando que o campo de email está vazio
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Campo email vazio";
            }
            // Verifica se o usuário não está cadastrado
            else if (id == 0)
            {
                // Exibe uma mensagem de erro indicando que o usuário não está cadastrado
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Usuario não cadastrado";
            }
            // Se o usuário está cadastrado, identifica o tipo de usuário com base em seu ID
            else
            {
                // Exibe o painel de senha e esconde o painel de email
                painelSenha.Visible = true;
                // Método executado quando o botão "Entrar" é clicado
            }
        }
        private void BotaoEntrar_Click(object sender, EventArgs e)
                {
                    // Chama o método Senha
                    Senha();
                }

                // Método que verifica a senha e exibe as telas correspondentes
                private void Senha()
                {
                    // Exibe o e-mail digitado pelo usuário na label correspondente
                    textoEmail.Text = campoEmail.Text;

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
                        campoSenha.Clear();
                    }

                    // Verifica se a senha inserida está incorreta e exibe uma mensagem de erro caso esteja
                    else if (!BancodeDados.Login(senha))
                    {
                        CondicaoSenha.Visible = true;
                        CondicaoSenha.Text = "Senha incorreta";
                        campoSenha.Clear();
                    }

                    // Verifica o tipo de usuário
                    else if (id / 1000 > 0 && id / 1000 < 6) // se for um aluno
                    {
                        // Esconde a tela atual
                        this.Hide();

                        // Cria e exibe a janela do formulário TMenuAluno (menu do aluno)
                        TMenuAluno p = new TMenuAluno();
                        p.ShowDialog();
                    }
                    else if (id / 1000 > 5) // se for uma empresa
                    {
                        // Esconde a tela atual
                        this.Hide();

                        // Cria e exibe a janela do formulário Empresa1
                        TMenuEmpresa p = new TMenuEmpresa();
                        p.ShowDialog();
                    }
                    else if (id / 100 == 1) // se for um coordenador
                    {
                        // Esconde a tela atual
                        this.Hide();

                        // Cria e exibe a janela do formulário Coordenador1
                        TMenuCoordenador p = new TMenuCoordenador();
                        p.ShowDialog();
                    }
                    else // se for um admin
                    {
                        // Esconde a tela atual
                        this.Hide();

                        // Cria e exibe a janela do formulário TAdmin
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
            //chamar metodo senha
            Senha();

        }

        private void BotaoProximo_Click(object sender, EventArgs e)
        {// Obter o email digitado pelo usuário
            string email = campoEmail.Text;
            Console.WriteLine("Email: " + email);

            // Buscar o ID do usuário no banco de dados
            int id = BancodeDados.BuscarID(email);

            // Verificar se o campo de email está vazio e exibir mensagem de erro caso esteja vazio
            if (email.Equals(""))
            {
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Campo email vazio";
            }
            // Verificar se o usuário não está cadastrado no banco de dados e exibir mensagem de erro caso não esteja
            else if (id == 0)
            {
                CondicaoEmail.Visible = true;
                CondicaoEmail.Text = "Usuario não cadastrado";
            }
            // Se for a primeira vez que o botão é clicado, exibir o campo de senha e mudar o texto do botão
            else
            {
                botaoVoltar.Visible = true;
                CondicaoEmail.Visible = false;
                // Chamar o método Email para exibir informações sobre o usuário
                Email();
            }

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

        }

        // Este método é chamado quando o botão "Voltar" é clicado
        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            // Oculta o painel de senha e exibe o painel de e-mail
            painelSenha.Visible = false;
            painelEmail.Visible = true;
            // Oculta o painel de suporte
            painelSuporte.Visible = false;

            // Oculta o botão "Voltar"
            botaoVoltar.Visible = false;

            // Limpa o campo de e-mail pessoal
            campoEmailPessoal.Clear();

            // Verifica se os itens já foram adicionados antes de adicioná-los novamente

            // Chama o método Passo1() para atualizar a interface do usuário
            Passo1();
            InicializarComboBox();
        }

        // Esse método é chamado quando o usuário clica no link "Suporte" no formulário
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Oculta o painel de recuperação de senha, se estiver visível
            painelSenha.Visible = false;

            // Oculta o painel de entrada de email, se estiver visível
            painelEmail.Visible = false;

            // Exibe o painel de suporte
            painelSuporte.Visible = true;

            // Exibe o botão "Voltar" para que o usuário possa voltar ao painel anterior
            botaoVoltar.Visible = true;

            // Oculta a mensagem de erro que possa estar visível
            CondicaoEmailS.Visible = false;

            // Inicializa o ComboBox para permitir que o usuário escolha o tipo de suporte desejado
            InicializarComboBox();

            // Define a seleção do ComboBox como a primeira opção (Esqueci meu email)
            erro.SelectedIndex = 0;
        }


        private void PainelEmail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PainelSenha_Paint(object sender, PaintEventArgs e)
        { // responsável por ajustar posição do painel "PainelSenha"
            // ficando alinhado ao painel "painelEmail"
            this.painelSenha.Location = this.painelEmail.Location;
            // Exibir o email do usuário na label
            copiarEmail.Text = campoEmail.Text;
            painelSenha.BringToFront();

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PainelSuporte_Paint(object sender, PaintEventArgs e)
        {
            // responsável por ajustar posição do painel "PainelSuporte"
            // ficando alinhado ao painel "painelEmail"
            this.painelSuporte.Location = this.painelEmail.Location;
            this.AcceptButton = BotaoEnviar;


        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Este método é acionado sempre que o usuário seleciona uma opção no ComboBox1
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou a primeira opção no ComboBox1

            if (erro.SelectedIndex == 0)
            {
                // Esconde o label CondicaoEmailS e limpa o campo de email

                CondicaoEmailS.Visible = false;
                campoEmailPessoal.Clear();
            }
            else
            {// Esconde o label CondicaoEmailS e limpa o campo de email

                CondicaoEmailS.Visible = false;
                campoEmailPessoal.Clear();

            }


        }
        // O método "BotaoEnviar_Click" é acionado quando o botão de enviar é clicado pelo usuário.
        private void BotaoEnviar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo de email pessoal está vazio.
            if (campoEmailPessoal.Text.Equals(""))
            {// Se estiver vazio, exibe uma mensagem de erro ao usuário
             // e informa que o campo está vazio.
                CondicaoEmailS.Visible = true;
                CondicaoEmailS.Text = "Campo email vazio";
                return;
            }

            // Verifica se o valor do campo de email corresponde ao formato de email
            Regex regex = new Regex(@"^([\w.\-]+)@([\w\-]+)?(\.\w{2,3})?(outlook\.com(\.br)?)?$");
            if (!regex.IsMatch(campoEmailPessoal.Text))
            {
                // Se o valor não corresponder, exibe uma mensagem de erro
                CondicaoEmailS.Visible = true;
                CondicaoEmailS.Text = "Formato de email inválido";
                return;
            }

            // Caso contrário, oculta a mensagem de erro
            CondicaoEmailS.Visible = false;

            // Verifica se há algum erro selecionado no campo "erro".
            if (erro.SelectedItem != null)
            {
                // Se houver algum erro selecionado, informa que a mensagem foi enviada para o email
                // e exibe uma mensagem de sucesso ao usuário.
                MessageBox.Show("Mensagem enviada para o email");
            }
        }


        private void CampoEmailPessoal_TextChanged(object sender, EventArgs e)
            {
               
            }


        


        //faz a picturebox, assim que for clicada, fechar o programa
        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //faz a picturebox, assim que clicada, minimizar a janela
        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CampoEmailPessoal_KeyDown(object sender, KeyEventArgs e)
        {
            // verifica se a tecla pressionada é "Enter".
            if (e.KeyCode == Keys.Enter)
            {// define o foco no botão "Enviar".
                BotaoEnviar.Focus();
                //simula o clique no botão "Enviar".
                BotaoEnviar.PerformClick();
                //informa que o evento já foi tratado e não precisa ser propagado para outros controles.
                e.Handled = true;
                //informa ao sistema para suprimir a tecla "Enter" pressionada 
                e.SuppressKeyPress = true;
            }

        }
        

        private void copiarEmail_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void copiarEmail_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void copiarEmail_MouseUp(object sender, MouseEventArgs e)
        {
        }

        //Configurando a janela para se mover de acordo com o clique do usuario
        //A variavel dragging indica que o usuario está "segurando" a tela
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
    }


