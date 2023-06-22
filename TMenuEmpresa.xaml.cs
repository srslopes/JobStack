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
    /// Lógica interna para TMenuEmpresa.xaml
    /// </summary>
    public partial class TMenuEmpresa : Window
    {
        private Empresa empresa;
        private TVagasEmpresa sub;
        public TMenuEmpresa()
        {
            InitializeComponent();
            NotificacaoV.Visibility = Visibility.Visible;
            empresa = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser());
            sub = null;
            NtChat();
            NtVagas();
            if(empresa.IsNovo())
            {
                empresa.SetNovo(false);
                TPerfilEmpresa pf = new TPerfilEmpresa();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(pf);
            }
            else
            {
                sub = new TVagasEmpresa();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(sub);
            }
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //torna visivel o tooltip
            if (BotaoMenu.IsChecked == true)
            {

                tt_logout.Visibility = Visibility.Collapsed;
                tt_chat.Visibility = Visibility.Collapsed;
                tt_perfil.Visibility = Visibility.Collapsed;
                tt_vagas.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_logout.Visibility = Visibility.Visible;
                tt_chat.Visibility = Visibility.Visible;
                tt_perfil.Visibility = Visibility.Visible;
                tt_vagas.Visibility = Visibility.Visible;
            }
        }

        private void BotaoMenu_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void txtBtnVagas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "VAGAS")
            {
                sub = new TVagasEmpresa();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(sub);
            }
        }

        
        private void txtBtnLogout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "LOG OUT/SAIR")
            {
                TesteLogin login = new TesteLogin();
                this.Close();
                login.Show();
            }
        }

        private void txtBtnChat_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "CHAT")
            {
                TBatePapo bp = new TBatePapo();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(bp);
            }
        }
        public void NtChat()
        {
            int n = 0;
            for (int i = 0; i < empresa.GetChats().Count; i++)
            {
                n += BancodeDados.BuscarChat(empresa.GetChats()[i]).GetNotificacoes();
            }
            Notif.Text = n.ToString();
            if (n == 0) Notificacao.Visibility = Visibility.Hidden;
            else Notificacao.Visibility = Visibility.Visible;
        }

        public void NtVagas()
        {
            NotifV.Text = empresa.GetNotificacoes().ToString();
            if (empresa.GetNotificacoes() == 0) NotificacaoV.Visibility = Visibility.Hidden;
            else NotificacaoV.Visibility = Visibility.Visible;
        }

        private void txtBtnPerfil_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "MEU PERFIL")
            {
                TPerfilEmpresa pf = new TPerfilEmpresa();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(pf);
            }
        }

        public void CarregarJanela(UserControl Janela)
        {
            ConteudoJanela.Children.Clear();
            ConteudoJanela.Children.Add(Janela);
        }

        public void CarregarSubJanela(UserControl Janela)
        {
            if (sub != null)
            {
                CarregarJanela(sub);
                sub.CarregarJanela(Janela);
            }
        }

        public void CarregarSubJanela(int i)
        {
            if (sub != null)
            {
                CarregarJanela(sub);
                sub.CarregarJanela(i);                
            }
        }

        public void AttListas()
        {
            if (sub != null) sub.AttListas();
            else Console.WriteLine("Etapa 1 Falhou");
        }
    }
}
