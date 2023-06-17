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

namespace JobStack.Teste
{
    /// <summary>
    /// Lógica interna para TesteNotificacoes.xaml
    /// </summary>
    public partial class TesteNotificacoes : Window
    {
        public TesteNotificacoes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //chamando a notificação de inscrição bem sucedida
            NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
            notificationWindow.Owner = TesteNotificacoes.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
            notificationWindow.Topmost = true;
            //aqui atualiza o texto da notificação
            notificationWindow.AtualizarMensagemSucesso("Testando a window de notificação.");
            notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            notificationWindow.ShowDialog();
        }

        private void BtnAtencao_Click(object sender, RoutedEventArgs e)
        {
            //chamando a notificação de inscrição bem sucedida
            NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
            notificationWindow.Owner = TesteNotificacoes.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
            notificationWindow.Topmost = true;
            //aqui atualiza o texto da notificação
            notificationWindow.AtualizarMensagemAtencao("Testando a window de notificação.");
            notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            notificationWindow.ShowDialog();
        }

        private void BtnErro_Click(object sender, RoutedEventArgs e)
        {
            //chamando a notificação de inscrição bem sucedida
            NotificacaoErro notificationWindow = new NotificacaoErro();
            notificationWindow.Owner = TesteNotificacoes.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
            notificationWindow.Topmost = true;
            //aqui atualiza o texto da notificação
            notificationWindow.AtualizarMensagemErro("Testando a window de notificação.");
            notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            notificationWindow.ShowDialog();
        }
    }
}
