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
            ID = 0;
        }
        public Coordenador(string e, string p)
        {
            SetEmail(e);
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
        
        public bool SetEmail(string e)
        {
            if (BancodeDados.BuscarID(e) != 0) return false;
            email = e;
            return true;
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
            email = coordenador.GetEmail();
            this.SetSenha(coordenador.GetSenha());
            this.SetID(coordenador.GetID());
        }
        public void Limpar()
        {
            email = "";
            this.SetSenha("");
        }
    }
}
