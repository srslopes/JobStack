using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Lógica interna para TLogin.xaml
    /// </summary>
    public partial class TLogin : Window
    {
        public TLogin()
        {
            InitializeComponent();
            InicializarComboBox();
            CondicaoEmail.Visibility = Visibility.Collapsed;
        }

        internal class GetWindow : TLogin
        {
            private MainWindow mainWindow;

            public GetWindow(MainWindow mainWindow)
            {
                this.mainWindow = mainWindow;
            }
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
                CondicaoEmail.Visibility = Visibility.Visible;
                CondicaoEmail.Text = "Campo email vazio";
            }
            // Verifica se o usuário não está cadastrado
            else if (id == 0)
            {
                // Exibe uma mensagem de erro indicando que o usuário não está cadastrado
                CondicaoEmail.Visibility = Visibility.Visible;
                CondicaoEmail.Text = "Usuario não cadastrado";
            }
            // Se o usuário está cadastrado, identifica o tipo de usuário com base em seu ID
            else
            {
                
                // Método executado quando o botão "Entrar" é clicado
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Email();
        }

        private void botaoFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
