using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Mensagem
    {
        private bool participante;
        private string msg;
        private DateTime data;

        public Mensagem(bool p, string m)
        {
            participante = p;
            msg = m;
            data = System.DateTime.Now;
        }

        public bool GetParticipante()
        {
            return participante;
        }

        public string GetMensagem()
        {
            return msg;
        }

        public DateTime GetData()
        {
            return data;
        }
    }
}
