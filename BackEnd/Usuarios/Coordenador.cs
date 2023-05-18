using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Coordenador : Usuario
    {

        public Coordenador(string e, string p)
        {
            SetChats(BancodeDados.GetChatsCoord());
            SetEmail(e);
            SetSenha(p);
            SetIdImg(1);
            BancodeDados.AdicionarCoordenador(this);
            
        }
        public new void AddTopo(int id)
        {
            GetChats().Remove(id);
            if (GetChats().Count < 2) GetChats().Add(id);
            else GetChats().Insert(1, id);
        }


    }
}
