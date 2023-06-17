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
    /// Interação lógica para TEditarPerfilAluno_Coordenador.xam
    /// </summary>
    public partial class TEditarPerfilAluno_Coordenador : UserControl
    {
        public TEditarPerfilAluno_Coordenador()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
            notificationWindow.Owner = TMenuCoordenador.GetWindow(this);
            notificationWindow.Topmost = true;
            //aqui atualiza o texto da notificação
            notificationWindow.AtualizarMensagemSucesso("Os dados do usuário foram atualizados.");
            notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            notificationWindow.ShowDialog();

        }
    }
}
