using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Empresa : Usuario
    {
        private List<int> Vagas;

        private string sobre;

        private long cnpj;

        private int ntAprovacoes;
        private int ntRejeicoes;

        public Empresa(string e, string s)
        {
            SetEmail(e);
            SetSenha(s);
            cnpj = 0;
            sobre = "";
            Vagas = new List<int>();
            SetIdImg(13);
            ntAprovacoes = 0;
            ntRejeicoes = 0;
            BancodeDados.AdicionarEmpresa(this);
            BancodeDados.SetIdUser(GetID());
            Chat adm = new Chat(1);
            Chat coo = new Chat(101);
        }

        public Empresa()
        {
            SetID(-1);
            cnpj = 0;
            ntAprovacoes = 0;
            ntRejeicoes = 0;
            sobre = "";
            SetIdImg(13);
            Vagas = new List<int>();
        }

        public void salvar()
        {
            if (GetID() != -1) return;
            BancodeDados.AdicionarEmpresa(this);            
            Chat adm = new Chat(GetID(),1);
            Chat coo = new Chat(GetID(),101);
        }
        public List<int> GetVagas()
        {
            return Vagas;
        }

        public void SetVagas(List<int> vagas)
        {
            Vagas.Clear();
            for (int i = 0; i < vagas.Count; i++) Vagas.Add(vagas[i]);
        }

        public void AdicionarVaga(int id)   //Adiciona o ID da vaga à lista de vagas criadas
        {
            Vagas.Add(id);
        }

        public void RemoverVaga(int id)   //Adiciona o ID da vaga à lista de vagas inscritas
        {
            for (int i = 0; i < Vagas.Count; i++) if (Vagas[i] == id) Vagas.RemoveAt(i);
        }

        public void SetSobre(string Sobre)
        {
            sobre = Sobre;
        }

        public string GetSobre()
        {
            return sobre;
        }

        public void SetCNPJ(long CNPJ)
        {
            cnpj = CNPJ;
        }

        public long GetCNPJ()
        {
            return cnpj;
        }

        public int GetNtAprovacoes()
        {
            return ntAprovacoes;
        }

        public void AddNtAprovacoes()
        {
            ntAprovacoes++;
        }

        public void ResetNtAprovacoes()
        {
            ntAprovacoes = 0;
        }
        public int GetNtRejeicoes()
        {
            return ntRejeicoes;
        }

        public void AddNtRejeicoes()
        {
            ntRejeicoes++;
        }

        public void ResetNtRejeicoes()
        {
            ntRejeicoes = 0;
        }

        public int GetNotificacoes()
        {
            return GetNtAprovacoes() + GetNtRejeicoes();
        }

    }
}
