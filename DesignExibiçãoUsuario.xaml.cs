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
    /// Interação lógica para DesignExibiçãoUsuario.xam
    /// </summary>
    public partial class DesignExibiçãoUsuario : UserControl
    {
        private object user;
        public DesignExibiçãoUsuario(int id)
        {
            InitializeComponent();
            user = BancodeDados.BuscarUsuario(id);
            AttDados();
        }

        public void AttDados()
        {
            NomeUsuario.Text = ((Usuario)user).GetNome();
            IDUsuario.Text = "ID: " + ((Usuario)user).GetID();
            TipoUsuario.Text = user.GetType().ToString();
            var converter = new BrushConverter();
            if (((Usuario)user).GetStatus())
            {
                Status.Text = "Ativo";
                BtnDesativar.Content = "Desativar";
                BtnDesativar.Background = (Brush)converter.ConvertFromString("Red");
            }
            else
            {
                Status.Text = "Desativado";
                BtnDesativar.Content = "Ativar";
                BtnDesativar.Background = (Brush)converter.ConvertFromString("#FF27597E");
            }
            Img.ImageSource = BancodeDados.BuscarImg(((Usuario)user).GetIdImg());
        }

        private void BtnDesativar_Click(object sender, RoutedEventArgs e)
        {
            if (((Usuario)user).GetStatus()) ((Usuario)user).SetStatus(false);
            else ((Usuario)user).SetStatus(true);
            AttDados();
        }

        private void BtnGerarSenha_Click(object sender, RoutedEventArgs e)
        {
            TGerarSenhaADM senha = new TGerarSenhaADM(this);
            senha.Owner = TMenuAdministrador.GetWindow(this);
            senha.ShowDialog();
        }
    }
}
