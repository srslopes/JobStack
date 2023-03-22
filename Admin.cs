using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Admin
    {
        private string email;

        private string senha;

        private int ID;

        public Admin()
        {
            email = "";
            senha = "";
        }

        public Admin(string n)
        {
            email = n;
            senha = "";
        }
        public Admin(string e, string p)
        {
            email = e;
            senha = p;
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

        public void ClonarDe(Admin admin) //Copia os atributos do objeto indicado para esse objeto
        {
            this.SetEmail(admin.GetEmail());
            this.SetEmail(admin.GetSenha());
            this.SetID(admin.GetID());
        }
        public void Limpar()
        {
            this.SetEmail("");
            this.SetSenha("");
        }
    }
}
