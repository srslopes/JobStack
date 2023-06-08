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

        private TBatePapo parent;

        private BatePapo parent2;

        public Contato(int id, TBatePapo janela)
        {
            parent = janela;
            conversa = BancodeDados.BuscarChat(id);
            InitializeComponent();
            
            Nome.Text = ((Usuario)BancodeDados.BuscarUsuario(conversa.GetParticipante())).GetNome();
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF04121D");
            if (conversa.GetParticipante() < 100)
            {
                Nome.Text = "Suporte Técnico";
                Bt.Background = brush;
            }
            else if(conversa.GetParticipante() < 1000)
            {
                Nome.Text = "Coordenação";
                Bt.Background = brush;
            }
             Img.ImageSource = BancodeDados.BuscarImg(((Usuario)BancodeDados.BuscarUsuario(conversa.GetParticipante())).GetIdImg());            
            if (conversa.GetNotificacoes() == 0) Notificacao.Visibility = Visibility.Hidden;
            else
            {
                Notificacao.Visibility = Visibility.Visible;
                Notif.Text = conversa.GetNotificacoes().ToString();
            }
        }

        public Contato(int id, BatePapo janela)
        {
            parent = null;
            parent2 = janela;
            conversa = BancodeDados.BuscarChat(id);
            InitializeComponent();

            Nome.Text = ((Usuario)BancodeDados.BuscarUsuario(conversa.GetParticipante())).GetNome();
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF04121D");
            if (conversa.GetParticipante() < 100)
            {
                Nome.Text = "Suporte Técnico";
                Bt.Background = brush;
            }
            else if (conversa.GetParticipante() < 1000)
            {
                Nome.Text = "Coordenação";
                Bt.Background = brush;
            }
            Img.ImageSource = BancodeDados.BuscarImg(((Usuario)BancodeDados.BuscarUsuario(conversa.GetParticipante())).GetIdImg());
            if (conversa.GetNotificacoes() == 0) Notificacao.Visibility = Visibility.Hidden;
            else
            {
                Notificacao.Visibility = Visibility.Visible;
                Notif.Text = conversa.GetNotificacoes().ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(parent!=null)parent.setIdChat(conversa.GetID());
            else parent2.setIdChat(conversa.GetID());
            Notificacao.Visibility = Visibility.Hidden;
            conversa.SetNotificacoes();
            BancodeDados.AttNtChat();
        }
    }
}
