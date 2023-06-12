using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Usuario 
    {
        private string email;
        private string senha;
        private string nome;
        private int ID;
        private bool status;
        private List<int> Chats;
        private int IdImg;

        public Usuario()
        {
            ID = 0;
            IdImg = 0;
            nome = "";
            SetStatus(true);
            Chats = new List<int>();
        }

        public string GetNome()
        {
            return nome;
        }
       
        public string GetEmail()
        {
            return email;
        }

        public string GetSenha()
        {
            return senha;
        }

        public void SetNome(string Nome)
        {
            nome = Nome;
        }

        public bool SetEmail(string e)
        {
            if (BancodeDados.BuscarID(e) != 0) return false;
            email = e;
            return true;
        }

        public void SetSenha(string p)
        {
            senha = BancodeDados.CriptografarSenha(p);
        }

        public int GetID()
        {
            return ID;
        }

        public void SetID(int id)
        {
            ID = id;
        }
        
        public void SetStatus(bool valor)
        {
            status = valor;
        }
        public bool GetStatus()
        {
            return status;
        }
        public void AdicionarChat(int id)
        {
            for (int i = 0; i < Chats.Count; i++) if (Chats[i] == id) return;
            if (Chats.Count < 3) Chats.Add(id);
            else Chats.Insert(2, id);
        }

        public void AddTopo(int id)
        {
            Chats.Remove(id);
            if (Chats.Count < 3) Chats.Add(id);
            else Chats.Insert(2, id);
        }

        public List<int> GetChats()
        {
            return Chats;
        }

        public void SetChats(List<int> lista)
        {
            Chats = lista;
        }

        public int GetIdImg()
        {
            return IdImg;
        }
        public void SetIdImg(int id)
        {
            IdImg = id;
        }
        public int ChatExiste(int id)
        {
            for(int i=0; i<Chats.Count; i++)
            {
                if (BancodeDados.BuscarChat(Chats[i]).GetParticipante() == id) return Chats[i];
            }
            return -1;
        }

    }
}
