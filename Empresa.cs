using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Empresa
    {
        private string email;

        private string senha;

        private int ID;

        private List<int> Vagas;

        public Empresa()
        {
            Vagas = new List<int>();
        }
        public Empresa(string e, string s)
        {
            email = e;
            senha =s;
            Vagas = new List<int>();
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetSenha()
        {
            return senha;
        }
  
        public void SetEmail(string e)
        {
            email = e;
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
        

        public void ClonarDe(Empresa empresa) //Copia os atributos do objeto indicado para esse objeto
        {
            this.SetEmail(empresa.GetEmail());
            this.SetSenha(empresa.GetSenha());
            this.SetID(empresa.GetID());
            this.SetVagas(empresa.GetVagas());
        }
        public void Limpar()
        {
            this.SetEmail("");
            this.SetSenha("");
        }

    }
}
