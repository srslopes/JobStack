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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            BancodeDados bd = new BancodeDados();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //BatePapo bp = new BatePapo();
            //bp.Show();
        }

        private void botaoLogin_Click(object sender, RoutedEventArgs e)
        {
            TesteLogin x = new TesteLogin();
            x.Show();
            this.Hide();
        }

        private void BImagem_Click(object sender, RoutedEventArgs e)
        {
          TesteImagem x = new TesteImagem();
            x.Show();
        }

        private void btnMenuAluno_Click(object sender, RoutedEventArgs e)
        {

            BancodeDados.SetIdUser(1001);
            TMenuAluno x = new TMenuAluno();
            BancodeDados.MenuAluno = x;
            BancodeDados.MenuAluno.Show();
        }

        private void btnMenuEmpresa_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.SetIdUser(6001);
            TMenuEmpresa s = new TMenuEmpresa();
            BancodeDados.MenuEmpresa = s;
            s.Show();
        }

        private void BtnMenuCoordenador_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.SetIdUser(101);
            TMenuCoordenador a = new TMenuCoordenador();
            BancodeDados.MenuCoordenador = a;
            a.Show();
        }

        private void BtnMenuAdm_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.SetIdUser(1);
            TMenuAdministrador i = new TMenuAdministrador();
            BancodeDados.MenuAdministrador = i;
            i.Show();
        }

        private void BotaoCadastrar_Click(object sender, RoutedEventArgs e)
        {
            TelaCadastrarAluno c = new TelaCadastrarAluno();

            c.Show();
        }

        private void bCadastrarEmpresa_Click(object sender, RoutedEventArgs e)
        {
            TMenuAdministrador t = new TMenuAdministrador();
            t.Show();
        }
    }
}
