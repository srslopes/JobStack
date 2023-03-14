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
        private string nome;
        private int  ra;
        private int dataNascimento;

        private string senha;


        public Aluno(string n,string o,int r,int d)
        {
            email = n;
            nome = o;
            senha = "";
        }
        public Aluno(string e, string p,string a)
        {
            email = e;
            senha = p;
            nome = a;

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
        public string Getnome()
        {
            return nome;
        }
       
        
        public void Setnome(string a)
        {
            nome=a;
        }


        public int  DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }


        public int Ra
        {
            get { return ra; }
            set { ra = value; }
        }

    }
}
