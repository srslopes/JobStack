﻿using System;
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
        public void ClonarDe(Admin a)   //Copia os atributos do objeto indicado para esse objeto
        {
            this.SetEmail(a.GetEmail());
            this.SetEmail(a.GetSenha());
        }
    }
}
