﻿using System;
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
        private int notificacoes1;
        private int participante2;
        private int notificacoes2;
        private List<Mensagem> Mensagens;

        public Chat(int ID)
        {
            participante1 = BancodeDados.GetIdUser();
            participante2 = ID;
            Mensagens = new List<Mensagem>();
            notificacoes1 = 0;
            notificacoes2 = 0;
            id = BancodeDados.AdicionarChat(this);
            ((Usuario)BancodeDados.BuscarUsuario(participante1)).AdicionarChat(id);
            ((Usuario)BancodeDados.BuscarUsuario(participante2)).AdicionarChat(id);
        }

        public void NovaMensagem(string mensagem)
        {
            Mensagem msg = new Mensagem(mensagem);
            Mensagens.Add(msg);
            if (BancodeDados.GetIdUser() == participante1) notificacoes2++;
            else notificacoes1++;
        }

        public int GetParticipante()
        {
            if (BancodeDados.GetIdUser()==participante1) return participante2;
            return participante1;
        }
        public int GetParticipante1()
        {
            return participante1;
        }

        public int GetParticipante2()
        {
            return participante2;
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

        public int GetNotificacoes()
        {
            if (BancodeDados.GetIdUser() == participante1) return notificacoes1;
            return notificacoes2;
        }

        public int GetNotificacoes1()
        {
            return notificacoes1;
        }
        public int GetNotificacoes2()
        {
            return notificacoes2;
        }

        public void SetNotificacoes()
        {
            if (BancodeDados.GetIdUser() == participante1) notificacoes1 = 0;
            else notificacoes2 = 0;
        }

        public void SetNotificacoes1()
        {
            notificacoes1 = 0;
        }
        public void SetNotificacoes2()
        {
            notificacoes2 = 0;
        }
    }
}