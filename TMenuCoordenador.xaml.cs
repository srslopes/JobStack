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
    /// Lógica interna para TMenuCoordenador.xaml
    /// </summary>
    public partial class TMenuCoordenador : Window
    {
        private Coordenador coordenador;
        public TMenuCoordenador()
        {
            InitializeComponent();
            coordenador = BancodeDados.BuscarCoordenador(BancodeDados.GetIdUser());
            NtChat();
        }

        private void BotaoMenu_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //torna visivel o tooltip
            if (BotaoMenu.IsChecked == true)
            {
                tt_logout.Visibility = Visibility.Collapsed;
                tt_chat.Visibility = Visibility.Collapsed;
                tt_empresa.Visibility = Visibility.Collapsed;
                tt_alunos.Visibility = Visibility.Collapsed;
                tt_vagas.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_logout.Visibility = Visibility.Visible;
                tt_chat.Visibility = Visibility.Visible;
                tt_vagas.Visibility = Visibility.Visible;
                tt_empresa.Visibility = Visibility.Visible;
                tt_alunos.Visibility = Visibility.Visible;
            }
        }

        private void txtBtnAnalisar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "VAGAS")
            {
                TSolicitacoesVagasCoordenador analisar = new TSolicitacoesVagasCoordenador();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(analisar);
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
            for (int i = 0; i < coordenador.GetChats().Count; i++)
            {
                n += BancodeDados.BuscarChat(coordenador.GetChats()[i]).GetNotificacoes();
            }
            Notif.Text = n.ToString();
            if (n == 0) Notificacao.Visibility = Visibility.Hidden;
            else Notificacao.Visibility = Visibility.Visible;
        }

        private void txtBtnAlunos_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "ALUNOS")
            {
                TAlunosCoordenador alunos = new TAlunosCoordenador();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(alunos);
            }
        }

        private void txtBtnEmpresa_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if(textBlock.Text == "EMPRESAS")
            {
                TEmpresasCoordenador empresas = new TEmpresasCoordenador();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(empresas);
            }
        }
        public void CarregarJanela(UserControl Janela)
        {
            ConteudoJanela.Children.Clear();
            ConteudoJanela.Children.Add(Janela);
        }
        public void CarregarJanela(Window Janela)
        {
            ConteudoJanela.Children.Clear();
            ConteudoJanela.Children.Add(Janela);
        }
        public void AttListas()
        {

        }
    }
}
