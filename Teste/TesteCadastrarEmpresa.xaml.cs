using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Lógica interna para TesteCadastrarEmpresa.xaml
    /// </summary>
    public partial class TesteCadastrarEmpresa : Window
    {
        public TesteCadastrarEmpresa()
        {
            InitializeComponent();
            passo1();
        }
        private void passo1()
        {
            textBlockCondiçãoEmail.Visibility = Visibility.Hidden;
            textBlockCondiçãoNome.Visibility = Visibility.Hidden;
            textBlockCondiçãoSenha.Visibility = Visibility.Hidden;
        }

        private void BotaoCadastrar_Click(object sender, RoutedEventArgs e)
        {
            // Verifica se o valor do campo de email corresponde ao formato de email
            Regex regex = new Regex(@"^([\w.\-]+)@([\w\-]+)(\.\w{2,3})?((\.com\.br)?)?$");
            if (textBoxNome.Text.Equals("") &&  textBoxEmail.Text.Equals("") && PasswordBoxSenha.Password.Equals(""))
            {
                textBlockCondiçãoNome.Visibility = Visibility.Visible;

                textBlockCondiçãoNome.Text = "Campo Nome vazio";

                textBlockCondiçãoEmail.Visibility = Visibility.Visible;

                textBlockCondiçãoEmail.Text = "Campo Email vazio";
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;

                textBlockCondiçãoSenha.Text = "Campo Senha vazio";
            }

            else if (!regex.IsMatch(textBoxEmail.Text))
            {
                // Se o valor não corresponder, exibe uma mensagem de erro
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Formato de email inválido";
                return;
            }
           
            else if (textBoxNome.Text.Equals("") && textBoxEmail.Text.Equals("") && PasswordBoxSenha.Password.Equals(""))
            {
                passo1();
                // Nome, Email e Senha estão vazios
                textBlockCondiçãoNome.Visibility = Visibility.Visible;
                textBlockCondiçãoNome.Text = "Campo Nome vazio";
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Campo Email vazio";
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;
                textBlockCondiçãoSenha.Text = "Campo Senha vazio";
            }
           
           
            else if (textBoxNome.Text.Equals("") && textBoxEmail.Text.Equals(""))
            {
                passo1();
                textBlockCondiçãoSenha.Visibility = Visibility.Hidden;
                // Nome e Email estão vazios
                textBlockCondiçãoNome.Visibility = Visibility.Visible;
                textBlockCondiçãoNome.Text = "Campo Nome vazio";
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Campo Email vazio";
            }
            else if (textBoxNome.Text.Equals("") && PasswordBoxSenha.Password.Equals(""))
            {
                passo1();
                textBlockCondiçãoEmail.Visibility = Visibility.Hidden;
                // Nome e Senha estão vazios
                textBlockCondiçãoNome.Visibility = Visibility.Visible;
                textBlockCondiçãoNome.Text = "Campo Nome vazio";
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;
                textBlockCondiçãoSenha.Text = "Campo Senha vazio";
            }
           
         
            else if (textBoxEmail.Text.Equals("") && PasswordBoxSenha.Password.Equals(""))
            {
                passo1();
                textBlockCondiçãoEmail.Visibility = Visibility.Hidden;
                // Email e Senha estão vazios
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Campo Email vazio";
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;
                textBlockCondiçãoSenha.Text = "Campo Senha vazio";
            }
            else if (textBoxNome.Text.Equals(""))
            {
                passo1();
                textBlockCondiçãoNome.Visibility = Visibility.Visible;

                textBlockCondiçãoNome.Text = "Campo Nome vazio";
            }
          
            else if (textBoxEmail.Text.Equals(""))
            {
                passo1();
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;

                textBlockCondiçãoEmail.Text = "Campo Email vazio";
            }
            else if (PasswordBoxSenha.Password.Equals(""))
            {
                passo1();
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;

                textBlockCondiçãoSenha.Text = "Campo Senha vazio";
            }
            else if (BancodeDados.BuscarID(textBoxEmail.Text) != 0)
            {
                passo1();
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;

                textBlockCondiçãoEmail.Text = "Email já consta no sistema";
            }
            else
            {
              Empresa N = new Empresa();

                N.SetNome(textBoxNome.Text);
                N.SetSenha(PasswordBoxSenha.Password);
                N.SetEmail(textBoxEmail.Text);
                N.salvar();
                textBoxID.Text = N.GetID().ToString();
                passo1();

                MessageBox.Show("cadastrado com sucesso");
            }
        }
    }
}
