using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Admin : Usuario
    {

        public Admin(string e, string p)
        {
            SetChats(BancodeDados.GetChatsAdm());
            SetEmail(e);
            SetSenha(p);
            SetIdImg(2);
        }   

    }
}
