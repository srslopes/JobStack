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
            EsconderErros();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.MenuCoordenador.CarregarJanela(parent);
        }
        public void EsconderErros()
        {
            ErroNome.Visibility = Visibility.Hidden;
            ErroCNPJvazio.Visibility = Visibility.Hidden;
            ErroCNPJinvalido.Visibility = Visibility.Hidden;
            ErroEmailExiste.Visibility = Visibility.Hidden;
            ErroEmailVazio.Visibility = Visibility.Hidden;
            ErroSenha.Visibility = Visibility.Hidden;
        }
        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            EsconderErros();
            bool clear = true;
            if (NomeEmpresa.Text.Equals(""))
            {
                ErroNome.Visibility = Visibility.Visible;
                clear = false;
            }
            if (CnpjEmpresa.Text.Equals(""))
            {
                ErroCNPJvazio.Visibility = Visibility.Visible;
            }
            else
            {
                try
                {
                    long x = long.Parse(CnpjEmpresa.Text);
                }
                catch (FormatException)
                {
                    ErroCNPJinvalido.Visibility = Visibility.Visible;
                    CnpjEmpresa.Text = "";
                    clear = false;
                }
            }


            if (EmailEmpresa.Text.Equals(""))
            {
                ErroEmailVazio.Visibility = Visibility.Visible;
                clear = false;
            }
            else if (BancodeDados.BuscarID(EmailEmpresa.Text) != 0)
            {
                ErroEmailExiste.Visibility = Visibility.Visible;
                clear = false;
            }

            if (SenhaEmpresa.Password.Equals(""))
            {
                ErroSenha.Visibility = Visibility.Visible;
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
