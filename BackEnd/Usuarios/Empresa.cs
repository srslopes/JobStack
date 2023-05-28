using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Empresa : Usuario
    {
        private List<int> Vagas;
     
        public Empresa(string e, string s)
        {
            SetEmail(e);
            SetSenha(s);
            Vagas = new List<int>();
            BancodeDados.AdicionarEmpresa(this);
            BancodeDados.SetIdUser(GetID());
            Chat adm = new Chat(1);
            Chat coo = new Chat(101);
        }

        public Empresa()
        {
            SetID(-1);
        }

        public void salvar()
        {
            if (GetID() != -1) return;
            Vagas = new List<int>();
            BancodeDados.AdicionarEmpresa(this);            
            Chat adm = new Chat(GetID(),1);
            Chat coo = new Chat(GetID(),101);
        }
        public List<int> GetVagas()
        {
            return Vagas;
        }

        public void SetVagas(List<int> vagas)
        {
            Vagas.Clear();
            for (int i = 0; i < vagas.Count; i++) Vagas.Add(vagas[i]);
        }

        public void AdicionarVaga(int id)   //Adiciona o ID da vaga à lista de vagas criadas
        {
            Vagas.Add(id);
        }

        public void RemoverVaga(int id)   //Adiciona o ID da vaga à lista de vagas inscritas
        {
            for (int i = 0; i < Vagas.Count; i++) if (Vagas[i] == id) Vagas.RemoveAt(i);
        }

    }
}
