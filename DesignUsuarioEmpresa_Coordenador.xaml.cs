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
    /// Interação lógica para DesignUsuarioEmpresa_Coordenador.xam
    /// </summary>
    public partial class DesignUsuarioEmpresa_Coordenador : UserControl
    {
        private Empresa empresa;
        public DesignUsuarioEmpresa_Coordenador(int id)
        {
            InitializeComponent();
            empresa = BancodeDados.BuscarEmpresa(id);
            Img.ImageSource = BancodeDados.BuscarImg(empresa.GetIdImg());
            NomeEmpresa.Text = empresa.GetNome();
        }

        private void BtnVerPerfil_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilEmpresa_Coordenador te = new TExibirPerfilEmpresa_Coordenador(empresa.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }
    }
}
