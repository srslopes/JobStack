﻿using System;
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
    /// Lógica interna para TMenuAdministrador.xaml
    /// </summary>
    public partial class TMenuAdministrador : Window
    {
        private Admin admin;

        public TMenuAdministrador()
        {
            InitializeComponent();
            admin = BancodeDados.BuscarAdmin(BancodeDados.GetIdUser());
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
                tt_usuarios.Visibility = Visibility.Collapsed;
             
                tt_logout.Visibility = Visibility.Collapsed;
                tt_chat.Visibility = Visibility.Collapsed;
                tt_cadusuario.Visibility = Visibility.Collapsed;
                
            }
            else
            {
                tt_usuarios.Visibility = Visibility.Visible;
             
                tt_logout.Visibility = Visibility.Visible;
                tt_chat.Visibility = Visibility.Visible;
                tt_cadusuario.Visibility = Visibility.Visible;
                
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

        private void txtBtnCadUsuarios_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if(textBlock.Text == "CADASTRAR")
            {
                TCadastrarUsuarioAdm cad = new TCadastrarUsuarioAdm();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(cad);
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
            for (int i = 0; i < admin.GetChats().Count; i++)
            {
                n += BancodeDados.BuscarChat(admin.GetChats()[i]).GetNotificacoes();
            }
            Notif.Text = n.ToString();
            if (n == 0) Notificacao.Visibility = Visibility.Hidden;
            else Notificacao.Visibility = Visibility.Visible;
        }

        private void txtBtnUsuarios_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (textBlock.Text == "USUÁRIOS")
            {
                TExibirUsuários eu = new TExibirUsuários();
                ConteudoJanela.Children.Clear();
                ConteudoJanela.Children.Add(eu);
            }
        }
    }
}
