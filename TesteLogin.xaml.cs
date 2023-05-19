using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Lógica interna para TesteLogin.xaml
    /// </summary>
    public partial class TesteLogin : Window
    {
        public TesteLogin()
        {
            InitializeComponent();
            Passo1();
            InicializarComboBox();
            textBoxEmail.Focus();
        }
        private void InicializarComboBox()
        {
            // Verifica se o combobox já possui itens antes de adicioná-los
            if (erro.Items.Count == 0)
            {
                // Adiciona os itens "Esqueci meu email", "Esqueci minha senha" e "Solicitar cadastro"
                erro.Items.Add("Esqueci meu email");
                erro.Items.Add("Esqueci minha senha ");
                erro.Items.Add("Solicitar cadastro ");
                erro.SelectedIndex = 0;

            }
        }
        private void Passo1()
        {
            // Limpa os campos de email e senha
            textBoxEmail.Clear();
            passwordBoxSenha.Clear();

            gridSenha.Visibility = Visibility.Hidden;
            gridProblema.Visibility = Visibility.Hidden;
            textBlockSuporteTécnico.Visibility = Visibility.Visible;
            botãoVoltar.Visibility = Visibility.Hidden;
            textBlockCondiçãoEmail.Visibility = Visibility.Hidden;
        }

       
        // Método para validar o email inserido pelo usuário
        private void Email()
        {
            // Obtém o email digitado pelo usuário e exibe no console
            string email = textBoxEmail.Text;
            Console.WriteLine("Email: " + email);

            // Busca o ID do usuário no banco de dados
            int id = BancodeDados.BuscarID(email);

            // Verifica se o campo de email está vazio
            if (email.Equals(""))
            {
                // Exibe uma mensagem de erro indicando que o campo de email está vazio
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Campo email vazio";
            }
            // Verifica se o usuário não está cadastrado
            else if (id == 0)
            {
                // Exibe uma mensagem de erro indicando que o usuário não está cadastrado
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Usuario não cadastrado";
            }
            // Se o usuário está cadastrado, identifica o tipo de usuário com base em seu ID
            else
            {
                if (BancodeDados.GetStatusUsuario(id))
                {
                  

                }
                else
                {

                }
                // Método executado quando o botão "Entrar" é clicado
                // Exibe o painel de senha e esconde o painel de email
                gridSenha.Visibility = Visibility.Visible;
                textBlockEmailDaPessoa.Visibility = Visibility.Visible;
                gridSenha.Margin = gridEmail.Margin;
                textBlockCondiçãoSenha.Margin = textBlockCondiçãoEmail.Margin;
                passwordBoxSenha.Margin = textBoxEmail.Margin;
                textBlockSenha.Margin = textBlockEmail.Margin;
                botãoLogin.Margin = botãoPróximoLogin.Margin;
                passwordBoxSenha.Width = textBoxEmail.Width;
                textBlockSenha.Width = textBlockEmail.Width;
                textBlockCondiçãoSenha.Width = textBlockCondiçãoEmail.Width;
                botãoLogin.Width = botãoPróximoLogin.Width;
                textBlockSenha.UseLayoutRounding = textBlockEmail.UseLayoutRounding;
                // Defina as margens corretas para o textBlockEmailDaPessoa
                textBlockEmailDaPessoa.Margin = new Thickness(
textBlockEmailDaPessoa.Margin.Left - 20,   // Subtrai um valor da margem esquerda existente
textBlockSenha.Margin.Top - textBlockEmailDaPessoa.ActualHeight - 5,  // Define a margem superior acima do textBlockSenha
                    textBlockEmailDaPessoa.Margin.Right,  // Mantém a margem direita existente
                    textBlockEmailDaPessoa.Margin.Bottom   // Mantém a margem inferior existente
                );
                gridEmail.Visibility = Visibility.Hidden;
                textBlockCondiçãoSenha.Visibility= Visibility.Hidden;
                botãoVoltar.Visibility = Visibility.Visible;
                textBlockEmailDaPessoa.Text = textBoxEmail.Text;


            }
        }
        private void Senha()
        {
            // Obtém o e-mail e a senha inseridos nos campos de texto
            string email = textBoxEmail.Text;
            string senha = StringSegura(passwordBoxSenha.SecurePassword);
            // Obtém o ID do usuário a partir do e-mail inserido
            int id = BancodeDados.BuscarID(email);
            // Verifica se o campo senha está vazio e exibe uma mensagem de erro caso esteja
            if (passwordBoxSenha.SecurePassword.Length == 0)
            {
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;
                textBlockCondiçãoSenha.Text = "Campo senha vazio";
                passwordBoxSenha.Clear();
            }
            // Verifica se a senha inserida está incorreta e exibe uma mensagem de erro caso esteja
            else if (!BancodeDados.Login(senha))
            {
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;
                textBlockCondiçãoSenha.Text = "Senha incorreta";
                passwordBoxSenha.Clear();
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
        private string StringSegura(SecureString secureString)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Verifica se o usuário selecionou a primeira opção no ComboBox1

            if (erro.SelectedIndex == 0)
            {
                // Esconde o label CondicaoEmailS e limpa o campo de email

                textBlockEmailProblema.Visibility = Visibility.Hidden;
                textBoxEmailProblema.Clear();
            }
            else
            {// Esconde o label CondicaoEmailS e limpa o campo de email

                textBlockEmailProblema.Visibility = Visibility.Hidden;
                textBoxEmailProblema.Clear();
            }
        }
        private void botãoPróximoLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = textBoxEmail.Text;
            Console.WriteLine("Email: " + email);

            // Buscar o ID do usuário no banco de dados
            int id = BancodeDados.BuscarID(email);

            // Verificar se o campo de email está vazio e exibir mensagem de erro caso esteja vazio
            if (email.Equals(""))
            {
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Campo email vazio";
            }
            // Verificar se o usuário não está cadastrado no banco de dados e exibir mensagem de erro caso não esteja
            else if (id == 0)
            {
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Usuario não cadastrado";
            }
            // Se for a primeira vez que o botão é clicado, exibir o campo de senha e mudar o texto do botão
            else
            {
                botãoVoltar.Visibility = Visibility.Visible;
                gridEmail.Visibility = Visibility.Hidden;
                // Chamar o método Email para exibir informações sobre o usuário
                Email();
                passwordBoxSenha.Focus();
                // Exibe o e-mail digitado pelo usuário na label correspondente
                textBlockEmailDaPessoa.Text = textBoxEmail.Text;
                textBlockCondiçãoSenha.Visibility = Visibility.Hidden;
            }
        }

        private void textBoxEmailProblema_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void botãoVoltar_Click_1(object sender, RoutedEventArgs e)
        {
            // Oculta o painel de senha e exibe o painel de e-mail
            gridSenha.Visibility = Visibility.Hidden;
            gridEmail.Visibility = Visibility.Visible;
            // Oculta o painel de suporte
            gridProblema.Visibility = Visibility.Hidden;
            // Oculta o botão "Voltar"
            botãoVoltar.Visibility = Visibility.Hidden;

            // Limpa o campo de e-mail pessoal
            textBoxEmailProblema.Clear();

            // Verifica se os itens já foram adicionados antes de adicioná-los novamente

            // Chama o método Passo1() para atualizar a interface do usuário
            Passo1();
            InicializarComboBox();
        }

        private void botãoLogin_Click(object sender, RoutedEventArgs e)
        {
            Senha();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Verifica se o campo de email pessoal está vazio.
            if (textBoxEmailProblema.Text.Equals(""))
            {// Se estiver vazio, exibe uma mensagem de erro ao usuário
             // e informa que o campo está vazio.
                condiçãoEmailProblema.Visibility = Visibility.Visible;
                condiçãoEmailProblema.Text = "Campo email vazio";
                return;
            }

            // Verifica se o valor do campo de email corresponde ao formato de email
            Regex regex = new Regex(@"^([\w.\-]+)@([\w\-]+)(\.\w{2,3})?((\.com\.br)?)?$");

            if (!regex.IsMatch(textBoxEmailProblema.Text))
            {
                // Se o valor não corresponder, exibe uma mensagem de erro
                condiçãoEmailProblema.Visibility = Visibility.Visible;
                condiçãoEmailProblema.Text = "Formato de email inválido";
                return;
            }

            // Caso contrário, oculta a mensagem de erro
            condiçãoEmailProblema.Visibility = Visibility.Hidden;

            // Verifica se há algum erro selecionado no campo "erro".
            if (erro.SelectedItem != null)
            {
                // Se houver algum erro selecionado, informa que a mensagem foi enviada para o email
                // e exibe uma mensagem de sucesso ao usuário.
                MessageBox.Show("Mensagem enviada para o email");
            }
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            gridProblema.Visibility = Visibility.Visible;
            gridEmail.Visibility = Visibility.Hidden;
            gridSenha.Visibility = Visibility.Hidden;
            botãoVoltar.Visibility = Visibility.Visible;
            textBlockSuporteTécnico.Visibility = Visibility.Hidden;
        }

        private void TextBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Enter) || (e.Key == Key.Return))
            {

                Email();
            }
        }

        private void PasswordBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Enter) || (e.Key == Key.Return))
            {

                Senha();
            }
        }
    }
}
