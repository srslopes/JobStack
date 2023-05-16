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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            BancodeDados bd = new BancodeDados();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BatePapo bp = new BatePapo();
            bp.Show();
            this.Hide();
        }

        private void botaoLogin_Click(object sender, RoutedEventArgs e)
        {
            TLogin x = new TLogin();
            x.Show();
        }

        private void BImagem_Click(object sender, RoutedEventArgs e)
        {
          TesteImagem x = new TesteImagem();
            x.Show();
        }
    }
}
