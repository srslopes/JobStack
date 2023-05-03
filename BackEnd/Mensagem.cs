using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Mensagem
    {
        private int participante;
        private string msg;
        private DateTime data;

        public Mensagem(string m)
        {
            participante = BancodeDados.GetIdUser();
            msg = m;
            data = System.DateTime.Now;
        }

        public int GetParticipante()
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
