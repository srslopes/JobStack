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

            BancodeDados bd = new BancodeDados();
            msg = true;
            InitializeComponent();
            Cabecalho.Visibility = Visibility.Hidden;
            idChat = -1;
            BancodeDados.SetIdUser(1001);
            Chat n1 = new Chat(1002);
            Chat n2 = new Chat(6001);
            Chat n3 = new Chat(6002);
            n1.NovaMensagem("Olá b");
            n2.NovaMensagem("Hey c");
            n3.NovaMensagem("Opa d");
            BancodeDados.SetIdUser(1002);
            n1.NovaMensagem("Opa a");
            Chat n4 = new Chat(6001);
            Chat n5 = new Chat(6002);
            n4.NovaMensagem("Bom dia c");
            n5.NovaMensagem("Oi d");
            BancodeDados.SetIdUser(6001);
            Chat n6 = new Chat(6002);
            n2.NovaMensagem("Oi a");
            n6.NovaMensagem("Fala d");
            BancodeDados.SetIdUser(6002);
            n3.NovaMensagem("Hey a");
            BancodeDados.SetIdUser(1001);
            n1.NovaMensagem("Td bem, b?");
            n2.NovaMensagem("Td certo, c?");
            n3.NovaMensagem("Td ok, d?");
            BancodeDados.SetIdUser(1002);
            n1.NovaMensagem("Sim, a");
            BancodeDados.SetIdUser(6001);
            n2.NovaMensagem("cerrtissimo, a");
            BancodeDados.SetIdUser(6002);
            n3.NovaMensagem("Td, a");
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
            CaixaDeTexto.Text = "Mensagem";
            Chat.Children.Clear();
            if (idChat == -1) return;
            Chat.Height = 0;
            List <Mensagem> msgs = BancodeDados.BuscarChat(idChat).GetChat();
            for(int i =0; i<msgs.Count; i++)
            {
                if (BancodeDados.GetIdUser() == msgs[i].GetParticipante()) adicionarMensagemR(msgs[i].GetMensagem(), msgs[i].GetData());
                else adicionarMensagemL(msgs[i].GetMensagem(), msgs[i].GetData());
            }
            Nome.Text = ((Usuario)BancodeDados.BuscarUsuario(BancodeDados.BuscarOutroParticipante(idChat))).GetEmail();
            Cabecalho.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.SetIdUser(int.Parse(ID.Text));
            attContatos();
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
    }
}
