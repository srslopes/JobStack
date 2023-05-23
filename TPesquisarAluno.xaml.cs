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
    /// Interação lógica para TPesquisarAluno.xam
    /// </summary>
    public partial class TPesquisarAluno : UserControl
    {
        public TPesquisarAluno()
        {
            InitializeComponent();
        }

        private void CaixaPesquisa_GotFocus(object sender, RoutedEventArgs e)
        {
            //oculta o texto da textbox quando o usuário clica pela primeira vez
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Pesquisar")
            {
                textBox.Text = " ";
                textBox.Foreground = Brushes.Black;
            }
        }
    }
}
