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
        public TMenuEmpresa()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //torna visivel o tooltip
            if (BotaoMenu.IsChecked == true)
            {
                tt_notificacoes.Visibility = Visibility.Collapsed;
                tt_logout.Visibility = Visibility.Collapsed;
                tt_chat.Visibility = Visibility.Collapsed;
                tt_perfil.Visibility = Visibility.Collapsed;
                tt_vagas.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_notificacoes.Visibility = Visibility.Visible;
                tt_logout.Visibility = Visibility.Visible;
                tt_chat.Visibility = Visibility.Visible;
                tt_perfil.Visibility = Visibility.Visible;
                tt_vagas.Visibility = Visibility.Visible;
            }
        }

        private void BotaoMenu_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
