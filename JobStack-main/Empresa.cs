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

        public void ClonarDe(Empresa a) //Copia os atributos do objeto indicado para esse objeto
        {
            this.SetEmail(a.GetEmail());
            this.SetEmail(a.GetSenha());
        }

    }
}
