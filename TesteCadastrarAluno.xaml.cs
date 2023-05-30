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
    /// Lógica interna para TelaCadastrarAluno.xaml
    /// </summary>
    public partial class TelaCadastrarAluno : Window
    {
        public TelaCadastrarAluno()
        {
            InitializeComponent();
            passo1();
        }
        private void passo1(){
            textBlockCondiçãoEmail.Visibility = Visibility.Hidden;
            textBlockCondiçãoNome.Visibility = Visibility.Hidden;
            textBlockCondiçãoSenha.Visibility = Visibility.Hidden;
            textBlockCondiçãoRa.Visibility = Visibility.Hidden;



        }
        private void BotaoCadastrar_Click(object sender, RoutedEventArgs e)
        {
          
            if(textBoxNome.Text.Equals("")&& textBoxRa.Text.Equals("")&& textBoxEmail.Text.Equals("")&& textBoxSenha.Text.Equals(""))
            {
                textBlockCondiçãoNome.Visibility = Visibility.Visible;

                textBlockCondiçãoNome.Text = "Campo Nome vazio";
                textBlockCondiçãoRa.Visibility = Visibility.Visible;

                textBlockCondiçãoRa.Text = "Campo Ra vazio";
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;

                textBlockCondiçãoEmail.Text = "Campo Email vazio";
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;

                textBlockCondiçãoSenha.Text = "Campo Senha vazio";
            }
           else if (textBoxNome.Text.Equals(""))
            {
                textBlockCondiçãoNome.Visibility = Visibility.Visible;

                textBlockCondiçãoNome.Text = "Campo Nome vazio";
            }
            else if(textBoxRa.Text.Equals("")) { 
                    textBlockCondiçãoRa.Visibility = Visibility.Visible;

                textBlockCondiçãoRa.Text = "Campo Ra vazio";
        }
            else if (textBoxEmail.Text.Equals(""))
            {
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;

                textBlockCondiçãoEmail.Text = "Campo Email vazio";
            }
            else if (textBoxSenha.Text.Equals(""))
            {
                textBlockCondiçãoSenha.Visibility = Visibility.Visible;

                textBlockCondiçãoSenha.Text = "Campo Senha vazio";
            }
          
            // Verifica se o valor do campo de email corresponde ao formato de email
            Regex regex = new Regex(@"^([\w.\-]+)@([\w\-]+)(\.\w{2,3})?((\.com\.br)?)?$");

            if (!regex.IsMatch(textBoxEmail.Text) && BancodeDados.BuscarID(textBoxEmail.Text)==0)
            {
                // Se o valor não corresponder, exibe uma mensagem de erro
                textBlockCondiçãoEmail.Visibility = Visibility.Visible;
                textBlockCondiçãoEmail.Text = "Formato de email inválido";
                return;
            }
            else {
                Aluno N = new Aluno();

                N.SetNome(textBoxNome.Text);
                N.SetRa(int.Parse(textBoxRa.Text));
                N.SetSenha(textBoxSenha.Text);
                N.SetEmail(textBoxEmail.Text);
                N.salvar();
                textBoxID.Text = N.GetID().ToString();
                passo1();

                MessageBox.Show("cadastrado com sucesso");
            }


        }
    }
}
