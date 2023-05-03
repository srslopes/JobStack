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
    /// Lógica interna para TLogin.xaml
    /// </summary>
    public partial class TLogin : Window
    {
        public TLogin()
        {
            InitializeComponent();
        }

        internal class GetWindow : TLogin
        {
            private MainWindow mainWindow;

            public GetWindow(MainWindow mainWindow)
            {
                this.mainWindow = mainWindow;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void botaoFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
