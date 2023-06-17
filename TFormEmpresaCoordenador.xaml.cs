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
    /// Interação lógica para TFormEmpresaCoordenador.xam
    /// </summary>
    public partial class TFormEmpresaCoordenador : UserControl
    {
        private TEmpresasCoordenador parent;
        public TFormEmpresaCoordenador(TEmpresasCoordenador janela)
        {
            InitializeComponent();
            parent = janela;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.MenuCoordenador.CarregarJanela(parent);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
            notificationWindow.Owner = TMenuCoordenador.GetWindow(this);
            notificationWindow.Topmost = true;
            //aqui atualiza o texto da notificação
            notificationWindow.AtualizarMensagemSucesso("O usuário foi cadastrado.");
            notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            notificationWindow.ShowDialog();

        }
    }
}
