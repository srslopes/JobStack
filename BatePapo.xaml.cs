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
    public partial class BatePapo : Window
    {
        private int idChat;
        private bool msg;

        public BatePapo()
        {

            msg = true;
            InitializeComponent();
            Cabecalho.Visibility = Visibility.Hidden;
            idChat = -1;
            BancodeDados.SetIdUser(1001);
            attContatos();

        }

        public void adicionarChat(int id)
        {
            Contato novo = new Contato(id, this);
            Lista.Children.Add(novo);
            ScrollContatos.ScrollToTop();
            Lista.Height += 86;
        }

        public void adicionarMensagemR(string mensagem, DateTime data)
        {
            Mensagem_R novo = new Mensagem_R(mensagem, data);
            Chat.Height += novo.getAltura();
            Chat.Children.Add(novo);
            ScrollMensagens.ScrollToBottom();
        }

        public void adicionarMensagemL(string mensagem, DateTime data)
        {
            Mensagem_L novo = new Mensagem_L(mensagem, data);
            Chat.Height += novo.getAltura();
            Chat.Children.Add(novo);
            ScrollMensagens.ScrollToBottom();
        }

        private void BotaoEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (idChat != -1)
            {
                BancodeDados.BuscarChat(idChat).NovaMensagem(CaixaDeTexto.Text);
                CaixaDeTexto.Text = "";
                attChat();
            }
        }

        public int getIdChat()
        {
            return idChat;
        }

        public void attContatos()
        {
            Lista.Height = 0;
            idChat = -1;
            Cabecalho.Visibility = Visibility.Hidden;
            Chat.Children.Clear();
            Lista.Children.Clear();
            List<int> chats = ((Usuario)BancodeDados.BuscarUsuario(BancodeDados.GetIdUser())).GetChats();
            for(int i=0; i<chats.Count; i++)
            {
                adicionarChat(chats[i]);
            }
        }
        public void setIdChat(int id)
        {
            idChat = id;
            attChat();
        }

        public void attChat()
        {
            msg = true;
            CaixaDeTexto.Text = "";
            if (!CaixaDeTexto.IsSelectionActive) CaixaDeTexto.Text = "Mensagem";
            Chat.Children.Clear();
            ChatFiller x = new ChatFiller();
            Chat.Height += 200;
            Chat.Children.Add(x);
            ScrollMensagens.ScrollToBottom();
            if (idChat == -1) return;
            List <Mensagem> msgs = BancodeDados.BuscarChat(idChat).GetChat();
            for(int i =0; i<msgs.Count; i++)
            {
                if ( BancodeDados.BuscarUsuario(BancodeDados.GetIdUser()).GetType().ToString().Equals(BancodeDados.BuscarUsuario(msgs[i].GetParticipante()).GetType().ToString())) adicionarMensagemR(msgs[i].GetMensagem(), msgs[i].GetData());
                else adicionarMensagemL(msgs[i].GetMensagem(), msgs[i].GetData());
            }
            Nome.Text = ((Usuario)BancodeDados.BuscarUsuario(BancodeDados.BuscarOutroParticipante(idChat))).GetNome();
            Img.ImageSource = BancodeDados.BuscarImg(((Usuario)BancodeDados.BuscarUsuario(BancodeDados.BuscarOutroParticipante(idChat))).GetIdImg());
            Cabecalho.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.SetIdUser(int.Parse(ID.Text));
            attContatos();
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Enter) || (e.Key == Key.Return))
            {
                BancodeDados.SetIdUser(int.Parse(ID.Text));
                attContatos();
            }            
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if ((idChat != -1) && ((e.Key == Key.Enter)||(e.Key == Key.Return)))
            {
                BancodeDados.BuscarChat(idChat).NovaMensagem(CaixaDeTexto.Text);
                CaixaDeTexto.Text = "";
                attChat();
            }
        }

        private void CaixaDeTexto_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(msg)
            {
                msg = false;
                CaixaDeTexto.Text = "";
            }
        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
