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

        private int ra;
      
        public Aluno(string e, string p)
        {
            SetEmail(e);
            SetSenha(p);
            Vagas = new List<int>();
            BancodeDados.AdicionarAluno(this);
            BancodeDados.SetIdUser(GetID());
            Chat adm = new Chat(1);
            Chat coo = new Chat(101);
        }

        public Aluno()
        {
            SetID(-1);
        }

        public void salvar()
        {
            if (GetID() != -1) return;
            Vagas = new List<int>();
            BancodeDados.AdicionarAluno(this);
            Chat adm = new Chat(GetID(), 1);
            Chat coo = new Chat(GetID(), 101);
        }
        
        public void AdicionarVaga(int id)   //Adiciona o ID da vaga à lista de vagas inscritas
        {
            for (int i = 0; i < Vagas.Count; i++) if (Vagas[i] == id) return;
            Vagas.Insert(0, id);
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

        public bool VagaInscrita(int idVaga)
        {
            for(int i=0; i<Vagas.Count; i++)
            {
                if (Vagas[i] == idVaga) return true;
            }
            return false;
        }
        public int GetRa()
        {
            return ra;
        }

        public void SetRa(int Ra)
        {
            ra = Ra;
        }
       

        

    }
}
