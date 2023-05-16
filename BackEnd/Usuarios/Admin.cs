using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Admin : Usuario
    {
        private static List<int> Chats;

        public Admin(string e, string p)
        {
            SetEmail(e);
            SetSenha(p);
        }

    }
}
