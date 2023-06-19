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
            bool clear = true;
            if (NomeEmpresa.Text.Equals(""))
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuEmpresa.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("A empresa precisa ter um nome.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }

            try
            {
                long x = long.Parse(CnpjEmpresa.Text);
            }
            catch (FormatException)
            {
                NotificacaoErro notificationWindow = new NotificacaoErro();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemErro("O CNPJ inserido é inválido.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                CnpjEmpresa.Text = "";
                clear = false;
            }

            if (EmailEmpresa.Text.Equals(""))
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("Insira um e-mail para o usuário.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }
            else if (BancodeDados.BuscarID(EmailEmpresa.Text) != 0)
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("Esse e-mail já existe.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }

            if(SenhaEmpresa.Password.Equals(""))
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("Crie uma senha inicial para o usuário.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }

            if (clear)
            {
                Empresa empresa = new Empresa();
                empresa.SetNome(NomeEmpresa.Text);
                empresa.SetCNPJ(long.Parse(CnpjEmpresa.Text));
                empresa.SetEmail(EmailEmpresa.Text);
                empresa.SetSenha(SenhaEmpresa.Password);
                empresa.salvar();
                parent.AttLista();
                BancodeDados.MenuCoordenador.CarregarJanela(parent);

                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this);
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemSucesso("A empresa foi cadastrada.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
            }
        }
    }
}
