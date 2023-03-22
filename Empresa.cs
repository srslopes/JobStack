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

        public Empresa()
        {
            email = "";
            senha = "";
        }

        public Empresa(string e)
        {
            email = e;
            senha = "";
        }
        public Empresa(string e, string s)
        {
            email = e;
            senha =s;

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

        

        public void ClonarDe(Empresa empresa) //Copia os atributos do objeto indicado para esse objeto
        {
            this.SetEmail(empresa.GetEmail());
            this.SetSenha(empresa.GetSenha());
            this.SetID(empresa.GetID());
        }
        public void Limpar()
        {
            this.SetEmail("");
            this.SetSenha("");
        }

    }
}
