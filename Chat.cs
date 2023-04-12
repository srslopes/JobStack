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

            switch (BancodeDados.BuscarUsuario(participante1).GetType().ToString())
            {
                case "JobStack.Aluno":
                    BancodeDados.BuscarAluno(participante1).AdicionarChat(id);
                    break;
                case "JobStack.Empresa":
                    BancodeDados.BuscarEmpresa(participante1).AdicionarChat(id);
                    break;
                case "JobStack.Admin":
                    BancodeDados.BuscarAdmin(participante1).AdicionarChat(id);
                    break;
                case "JobStack.Coordenador":
                    BancodeDados.BuscarCoordenador(participante1).AdicionarChat(id);
                    break;
            }

            switch (BancodeDados.BuscarUsuario(participante2).GetType().ToString())
            {
                case "JobStack.Aluno":
                    BancodeDados.BuscarAluno(participante2).AdicionarChat(id);
                    break;
                case "JobStack.Empresa":
                    BancodeDados.BuscarEmpresa(participante2).AdicionarChat(id);
                    break;
                case "JobStack.Admin":
                    BancodeDados.BuscarAdmin(participante2).AdicionarChat(id);
                    break;
                case "JobStack.Coordenador":
                    BancodeDados.BuscarCoordenador(participante2).AdicionarChat(id);
                    break;
            }
        }

        public void NovaMensagem(string mensagem)
        {
            Mensagem msg = new Mensagem( participante1 == BancodeDados.GetIdUser(), mensagem);
            Mensagens.Prepend(msg);
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
