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
    /// Interação lógica para TVagaCompletaEmpresa.xam
    /// </summary>
    public partial class TVagaCompletaEmpresa : UserControl
    {
        public TVagaCompletaEmpresa()
        {
            InitializeComponent();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            //é o nome antigo da tela TEditarCadVagaEmpresa
            TEditarCadEmpresa cad = new TEditarCadEmpresa(this);
            cad.Owner = TMenuEmpresa.GetWindow(this);
            cad.ShowDialog();


        }
    }
}
