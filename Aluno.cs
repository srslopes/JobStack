using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Aluno
    {
        private string email;
        private string senha;
        private int ID;
        private List<int> Vagas;
        private bool status;


        public Aluno()
        {
            ID = 0;
            Vagas = new List<int>();
            SetStatus(false);
        }
        
        public Aluno(string e, string p)
        {
            SetEmail(e);
            senha = p;
            ID = 0;
            Vagas = new List<int>();
            SetStatus(false);
        }

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

        public void ClonarDe(Aluno aluno)   //Copia os atributos do objeto indicado para esse objeto
        {
            email = aluno.GetEmail();
            this.SetSenha(aluno.GetSenha());
            this.SetID(aluno.GetID());
            this.SetVagas(aluno.GetVagas());
        }

        public void SetStatus(bool valor)
        {
            status = valor;
        }

        public bool GetStatus()
        {
            return status;
        }

        public void Limpar()
        {
            email = "";
            this.SetSenha("");
        }

    }
}
