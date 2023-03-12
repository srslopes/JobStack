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

        public Aluno(string n)
        {
            email = n;
            senha = "";
        }
        public Aluno(string e, string p)
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
    }
}
