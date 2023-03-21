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


        public Aluno()
        {
            email = "";
            senha = "";
            ID = 0;
        }
        public Aluno(string e)
        {
            email = e;
            senha = "";
            ID = 0;
        }
        public Aluno(string e, string p)
        {
            email = e;
            senha = p;
            ID = 0;
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

        public void ClonarDe(Aluno a)   //Copia os atributos do objeto indicado para esse objeto
        {
            this.SetEmail(a.GetEmail());
            this.SetSenha(a.GetSenha());
            this.SetID(a.GetID());
        }

        public void Limpar()
        {
            this.SetEmail("");
            this.SetSenha("");
        }

    }
}
