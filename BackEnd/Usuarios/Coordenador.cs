using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Coordenador : Usuario
    {
        private static List<int> Chats;

        public Coordenador(string e, string s)
        {
            SetEmail(e);
            SetSenha(s);
        }

    }
}
