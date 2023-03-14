using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Coordenador
    {
        private string email;

        private string senha;
        private string nome;

        public Coordenador(string n,string a)
        {
            email = n;
            senha = "";
            nome = a;
        }
        public Coordenador(string e, string p,string m)
        {
            email = e;
            senha = p;
            nome = m;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetSenha()
        {
            return senha;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetEmail(string e)
        {
            email = e;
        }

        public void SetSenha(string p)
        {
            senha = p;
        }
        public void SetNome(string m)
        {
            nome=m;
        }
    }
}
