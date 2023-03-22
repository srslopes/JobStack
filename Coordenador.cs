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

        private int ID;
        public Coordenador()
        {
            email = "";
            senha = "";
        }

        public Coordenador(string e)
        {
            email = e;
            senha = "";
        }
        public Coordenador(string e, string p)
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

        public void ClonarDe(Coordenador coordenador) //Copia os atributos do objeto indicado para esse objeto
        {
            this.SetEmail(coordenador.GetEmail());
            this.SetSenha(coordenador.GetSenha());
            this.SetID(coordenador.GetID());
        }
        public void Limpar()
        {
            this.SetEmail("");
            this.SetSenha("");
        }
    }
}
