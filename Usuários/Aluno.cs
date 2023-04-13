using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Aluno : Usuario
    {
        private List<int> Vagas;
        /*
        private string email;
        private string senha;
        private int ID;
        
        private List<int> Chats;
        private bool status;
        


        public Aluno()
        {
            ID = 0;
            Vagas = new List<int>();
            Chats = new List<int>();
            SetStatus(false);
        }
        */
        public Aluno()
        {
            Vagas = new List<int>();
        }
        public Aluno(string e, string p)
        {
            SetEmail(e);
            SetSenha(p);
            Vagas = new List<int>();
        }
        /*
        public string GetEmail()
        {
            return email;
        }

        public string GetSenha()
        {
            return senha;
        }
        public bool SetEmail(string e)
        {
            if (BancodeDados.BuscarID(e) != 0) return false;
            email = e;
            return true;
        }

        public void SetSenha(string p)
        {
            senha = p;
        }

        public int GetID()
        {
            return ID;
        }
        public void SetID(int id)
        {
            ID = id;
        }
        public void AdicionarChat(int id)
        {
            for (int i = 0; i < Chats.Count; i++) if (Chats[i] == id) return;
            Chats.Prepend(id);
        }

        public List<int> GetChats()
        {
            return Chats;
        }

        public void SetStatus(bool valor)
        {
            status = valor;
        }

        public bool GetStatus()
        {
            return status;
        }

    */
        public void AdicionarVaga(int id)   //Adiciona o ID da vaga à lista de vagas inscritas
        {
            for (int i = 0; i < Vagas.Count; i++) if (Vagas[i] == id) return;
            Vagas.Add(id);
        }

        public void RemoverVaga(int id)   //Adiciona o ID da vaga à lista de vagas inscritas
        {
            for (int i = 0; i < Vagas.Count; i++) if (Vagas[i] == id) Vagas.RemoveAt(i);
        }

        public List<int> GetVagas()
        {
            return Vagas;
        }

        public void SetVagas(List<int> vagas)
        {
            Vagas.Clear();
            for (int i = 0; i <= vagas.IndexOf(vagas.Last()); i++) Vagas.Add(vagas[i]);
        }

        


    }
}
