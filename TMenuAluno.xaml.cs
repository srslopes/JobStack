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
    /// Lógica interna para TMenuAluno.xaml
    /// </summary>
    public partial class TMenuAluno : Window
    {
        public TMenuAluno()
        {
            InitializeComponent();
        }

        private void BotaoMenu_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //torna visivel o tooltip
            if (BotaoMenu.IsChecked == true)
            {
                tt_pesquisar.Visibility = Visibility.Collapsed;
                tt_notificacoes.Visibility = Visibility.Collapsed;
                tt_logout.Visibility = Visibility.Collapsed;
                tt_chat.Visibility = Visibility.Collapsed;
                tt_perfil.Visibility = Visibility.Collapsed;
                tt_inscricoes.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_pesquisar.Visibility = Visibility.Visible;
                tt_notificacoes.Visibility = Visibility.Visible;
                tt_logout.Visibility = Visibility.Visible;
                tt_chat.Visibility = Visibility.Visible;
                tt_perfil.Visibility = Visibility.Visible;
                tt_inscricoes.Visibility = Visibility.Visible;
            }
        }

       /* private void txtBtnPesquisa_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if(textBlock.Text == "PESQUISAR VAGA")
            {
                TPesquisarAluno pesquisar = new TPesquisarAluno();
                conteudoFrame.Content = pesquisar;
            }
        }*/


        private void txtBtnPesquisa_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "PESQUISAR VAGA")
            {
                TPesquisarAluno pesquisar = new TPesquisarAluno();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(pesquisar);
            }
            }

        private void txtBtnNotificacoes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "NOTIFICAÇÕES")
            {
                TNotificacoes notificar = new TNotificacoes();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(notificar);
            }
        }
    }
}
