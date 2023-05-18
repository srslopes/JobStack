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
            BancodeDados.SetIdUser(GetID());
            Chat adm = new Chat(1);
        }
       

    }
}
