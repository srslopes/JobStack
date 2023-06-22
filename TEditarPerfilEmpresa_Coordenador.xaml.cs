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
    /// Interação lógica para TEditarPerfilEmpresa_Coordenador.xam
    /// </summary>
    public partial class TEditarPerfilEmpresa_Coordenador : UserControl
    {
        private Empresa empresa;
        private bool bt;
        public TEditarPerfilEmpresa_Coordenador(int id)
        {
            InitializeComponent();
            empresa = BancodeDados.BuscarEmpresa(id);
            bt = false;
            AttDados();
            EsconderErros();
        }

        public void AttDados()
        {
            NomeEmpresa.Text = empresa.GetNome();
            CnpjEmpresa.Text = empresa.GetCNPJ().ToString();
            EmailEmpresa.Text = empresa.GetEmail();

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
            if(NomeEmpresa.Text.Equals(""))
            {
                ErroNome.Visibility = Visibility.Visible;
                clear = false;
            }
            if(CnpjEmpresa.Text.Equals(""))
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
            

            if(EmailEmpresa.Text.Equals(""))
            {
                ErroEmailVazio.Visibility = Visibility.Visible;
                clear = false;
            }
            else if(BancodeDados.BuscarID(EmailEmpresa.Text)!=0 && BancodeDados.BuscarID(EmailEmpresa.Text) != empresa.GetID())
            {
                ErroEmailExiste.Visibility = Visibility.Visible;
                clear = false;
            }

            if(bt && SenhaEmpresa.Password.Equals(""))
            {
                ErroSenha.Visibility = Visibility.Visible;
                clear = false;
            }

            if (clear)
            {
                empresa.SetNome(NomeEmpresa.Text);
                empresa.SetCNPJ(long.Parse(CnpjEmpresa.Text));
                empresa.SetEmail(EmailEmpresa.Text);
                if (bt) empresa.SetSenha(SenhaEmpresa.Password);
                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this);
                notificationWindow.Topmost = true;
                notificationWindow.AtualizarMensagemSucesso("Os dados do usuário foram atualizados.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                TExibirPerfilEmpresa_Coordenador te = new TExibirPerfilEmpresa_Coordenador(empresa.GetID());
                BancodeDados.MenuCoordenador.CarregarJanela(te);
            }
            
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilEmpresa_Coordenador te = new TExibirPerfilEmpresa_Coordenador(empresa.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }

        private void BtnSenha_Click(object sender, RoutedEventArgs e)
        {
            if (bt)
            {
                SenhaEmpresa.Password = "";
                SenhaEmpresa.IsEnabled = false;
                BtnSenha.Content = "Nova Senha";
                bt = false;
            }
            else
            {
                SenhaEmpresa.Password = "";
                SenhaEmpresa.IsEnabled = true;
                BtnSenha.Content = "Cancelar";
                bt = true;
            }
        }
    }
}
