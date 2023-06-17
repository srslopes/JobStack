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
    /// Interação lógica para TEmpresasCoordenador.xam
    /// </summary>
    public partial class TEmpresasCoordenador : UserControl
    {
        public TEmpresasCoordenador()
        {
            InitializeComponent();
            AttLista();
        }

        public void AttLista()
        {
            SPEmpresas.Children.Clear();
            SPEmpresas.Height = 0;
            int i = 6001;
            while (BancodeDados.BuscarEmpresa(i) != null)
            {
                DesignUsuarioEmpresa_Coordenador us = new DesignUsuarioEmpresa_Coordenador(i);
                SPEmpresas.Children.Insert(0, us);
                SPEmpresas.Height += 110;
                i++;
            }
        }

        private void BtnNovaEmpresa_Click(object sender, RoutedEventArgs e)
        {
            TFormEmpresaCoordenador t = new TFormEmpresaCoordenador(this);
            BancodeDados.MenuCoordenador.CarregarJanela(t);
        }
    }
}
