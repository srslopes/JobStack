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
    /// Interação lógica para Contato.xam
    /// </summary>
    public partial class Contato : UserControl
    {        
        private Chat conversa;

        private BatePapo parent;

        public Contato(int id, BatePapo janela)
        {
            parent = janela;
            conversa = BancodeDados.BuscarChat(id);
            InitializeComponent();
            Nome.Text = ((Usuario)BancodeDados.BuscarUsuario(conversa.GetParticipante())).GetEmail();
            
            if (conversa.GetNotificacoes() == 0) Notificacao.Visibility = Visibility.Hidden;
            else
            {
                Notificacao.Visibility = Visibility.Visible;
                Notif.Text = conversa.GetNotificacoes().ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            parent.setIdChat(conversa.GetID());
            Notificacao.Visibility = Visibility.Hidden;
            conversa.SetNotificacoes();
        }
    }
}
