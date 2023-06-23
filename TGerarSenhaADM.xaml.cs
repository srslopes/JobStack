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
    /// Lógica interna para TGerarSenhaADM.xaml
    /// </summary>
    public partial class TGerarSenhaADM : Window
    {
        private Usuario user;
        public TGerarSenhaADM(DesignExibiçãoUsuario designExibiçãoUsuario, int id)
        {
            InitializeComponent();
            user = (Usuario)BancodeDados.BuscarUsuario(id);
        }

        private void BtnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Erro.Visibility = Visibility.Hidden;
            if(NovaSenha.Password.Equals(""))
            {
                Erro.Visibility = Visibility.Visible;
            }
            else
            {
                user.SetSenha(NovaSenha.Password);
                this.Close();
                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemSucesso("Senha alterada");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                
            }
        }
    }
}
