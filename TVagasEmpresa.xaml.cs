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
    /// Interação lógica para TVagasEmpresa.xam
    /// </summary>
    public partial class TVagasEmpresa : UserControl
    {
        public TVagasEmpresa()
        {
            InitializeComponent();
        }

        private void BtnCriar_Click(object sender, RoutedEventArgs e)
        {
            TCadastrarVagaEmpresa cadv = new TCadastrarVagaEmpresa();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(cadv);
            
        }

        private void BtnPendentes_Click(object sender, RoutedEventArgs e)
        {
            TVagasPendentesEmpresa pendentes = new TVagasPendentesEmpresa();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(pendentes);
        }

        private void BtnEmAberto_Click(object sender, RoutedEventArgs e)
        {
            TVagasEmAberto aberto = new TVagasEmAberto();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(aberto);
        }

        private void BtnFinalizadas_Click(object sender, RoutedEventArgs e)
        {
            TVagasFinalizadasEmpresa finalizadas = new TVagasFinalizadasEmpresa();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(finalizadas);
        }
    }
}
