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
        private Aluno aluno;
        public TMenuAluno()
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
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
                tt_vagasdisp.Visibility = Visibility.Collapsed;
                tt_logout.Visibility = Visibility.Collapsed;
                tt_chat.Visibility = Visibility.Collapsed;
                tt_perfil.Visibility = Visibility.Collapsed;
                tt_inscricoes.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_vagasdisp.Visibility = Visibility.Visible;
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
            if (textBlock.Text == "VAGAS DISPONÍVEIS")
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

        private void txtBtnLogout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if(textBlock.Text == "LOG OUT/SAIR")
            {
                TesteLogin login = new TesteLogin();
                this.Close();
                login.Show();
            }
        }

        private void txtBtnInscricoes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if(textBlock.Text == "MINHAS INSCRIÇÕES")
            {
                TMinhasInscricoesAluno insc = new TMinhasInscricoesAluno();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(insc);
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
        public void AbrirChat(int id)
        {
            TBatePapo bp = new TBatePapo(id);
            ConteudoJanela.Children.Clear();
            ConteudoJanela.Children.Add(bp);
        }

        public void NtChat()
        {
            int n = 0;
            for(int i=0; i<aluno.GetChats().Count; i++)
            {
                n+=BancodeDados.BuscarChat(aluno.GetChats()[i]).GetNotificacoes();
            }
            Notif.Text = n.ToString();
            if (n==0)Notificacao.Visibility = Visibility.Hidden;
            else Notificacao.Visibility = Visibility.Visible;
        }

        private void txtBtnPerfil_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "MEU PERFIL")
            {
                TPerfilAluno pf = new TPerfilAluno();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(pf);
            }
        }
    }
}
