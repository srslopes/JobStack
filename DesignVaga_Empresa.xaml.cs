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
    /// Interação lógica para DesignVaga_Empresa.xam
    /// </summary>
    public partial class DesignVaga_Empresa : UserControl
    {
        public DesignVaga_Empresa()
        {
            InitializeComponent();
        }

        private void BtnVerMais_Click(object sender, RoutedEventArgs e)
        {
            TVagaCompletaEmpresa vaga = new TVagaCompletaEmpresa();            
            vaga.Topmost = true;
            vaga.Show();
        }
    }
}
