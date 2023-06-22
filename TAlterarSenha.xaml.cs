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
    /// Lógica interna para TAlterarSenha.xaml
    /// </summary>
    public partial class TAlterarSenha : Window
    {
        private TFormInfoEmpresa formInfoEmpresa;
        private Usuario user;

        public TAlterarSenha(TFormCurriculoAluno formCurriculoAluno)
        {
            user = ((Usuario)BancodeDados.BuscarUsuario(BancodeDados.GetIdUser()));
            InitializeComponent();
        }

        public TAlterarSenha(TFormInfoEmpresa formInfoEmpresa)
        {
            user = ((Usuario)BancodeDados.BuscarUsuario(BancodeDados.GetIdUser()));
            InitializeComponent();
        }

        public TAlterarSenha()
        {
            user = ((Usuario)BancodeDados.BuscarUsuario(BancodeDados.GetIdUser()));
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Erro.Visibility = Visibility.Hidden;
            if (!NovaSenha.Password.Equals(""))
            {
                user.SetSenha(NovaSenha.Password);
                this.Close();
                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Topmost = true;
                notificationWindow.AtualizarMensagemSucesso("Senha alterada com sucesso");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
            }
            else
            {
                Erro.Visibility = Visibility.Visible;
            }
            
        }
    }
}
