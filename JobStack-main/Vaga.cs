using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
   class Vaga
    {
        private string tipo;
        private int quantidade;
        private string descricao;
        private string nomeEmpresa;
        private int status;
        public Vaga(string a, string b, string c)
        {
            tipo = a;
            descricao = b;
            nomeEmpresa = c;
            status = 0;
        }
        public Vaga(string e, string f, string g, int h)
        {
           tipo = e;
            descricao = f;
            nomeEmpresa = g;
            status = h;

        }

        public string GetTipo()
        {
            return tipo;
        }

        public string GetDescricao()
        {
            return descricao;
        }
        public string GetNomeEmpresa()
        {
            return nomeEmpresa;
        }
        public int GetStatus()
        {
            return status;
        }
        public void SetTipo(string e)
        {
            tipo = e;
        }

        public void SetDescricao(string f)
        {
           descricao = f;
        }
        public void SetNomeEmpresa(string g)
        {
            nomeEmpresa = g;
        }
        public void SetStatus(int h)
        {
            status = h;
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}
