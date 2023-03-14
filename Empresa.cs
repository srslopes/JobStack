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
        private string nome;
        private string endereco;
        private int cnpj;



        public Empresa(string n,string a,string b)
        {
            email = n;
            senha = "";
            nome = a;
            endereco = b;
        }
        public Empresa(string e, string p,string c,string d)
        {
            email = e;
            senha = p;
            nome = c;
            endereco = d;

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
        public string GetEndereco()
        {
            return endereco;
        }
        public void SetEmail(string e)
        {
            email = e;
        }

        public void SetSenha(string p)
        {
            senha = p;
        }
        public void SetNome(string c)
        {
            email = c;
        }
        public void SetEndereco(string d)
        {
            email = d;
        }

        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

    }
}
