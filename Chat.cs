using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Chat
    {
        private int id;
        private int participante1;
        private int participante2;
        private List<Mensagem> Mensagens;

        public Chat(int id)
        {
            participante1 = BancodeDados.GetIdUser();
            participante2 = id;
            Mensagens = new List<Mensagem>();
            BancodeDados.AdicionarChat(this);
            ((Usuario)BancodeDados.BuscarUsuario(participante1)).AdicionarChat(id);
            ((Usuario)BancodeDados.BuscarUsuario(participante2)).AdicionarChat(id);

        }

        public void NovaMensagem(string mensagem)
        {
            Mensagem msg = new Mensagem( participante1 == BancodeDados.GetIdUser(), mensagem);
            Mensagens.Insert(0, msg);
        }
       
        public Mensagem GetMensagem(int id)
        {
            return Mensagens[id];
        }

        public List<Mensagem> GetChat()
        {
            return Mensagens;
        }

        public void SetID(int ID)
        {
            id = ID;
        }

        public int GetID()
        {
            return id;
        }
    }
}
