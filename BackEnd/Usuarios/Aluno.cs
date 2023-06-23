using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class Aluno : Usuario
    {
        private List<int> Vagas;

        private long ra;

        private int curso;

        private int semestre;

        private string formacao;

        private string experiencia;

        private int aprov;



        public Aluno(string e, string p)
        {
            SetEmail(e);
            SetSenha(p);
            curso = -1;
            semestre = 0;
            aprov = 0;
            formacao = "";
            experiencia = "";
            SetIdImg(0);
            Vagas = new List<int>();
            BancodeDados.AdicionarAluno(this);
            BancodeDados.SetIdUser(GetID());
            Chat adm = new Chat(1);
            Chat coo = new Chat(101);
        }

        public Aluno()
        {
            SetID(-1);
            semestre = 0;
            aprov = 0;
            formacao = "";
            experiencia = "";
            SetIdImg(0);
            Vagas = new List<int>();
        }

        public Aluno(string n)
        {
            if(n.Equals("Login"))
            {
                SetEmail("login");
                SetSenha("login");
                SetNome(n);
                curso = -1;
                semestre = 0;
                aprov = 0;
                formacao = "";
                experiencia = "";
                SetIdImg(14);
                Vagas = new List<int>();
                BancodeDados.AdicionarAluno(this);
                BancodeDados.SetIdUser(GetID());
                Chat adm = new Chat(1);
                Chat coord = new Chat(101);
            }
        }

        public void salvar()
        {
            if (GetID() != -1) return;
            BancodeDados.AdicionarAluno(this);
            Chat adm = new Chat(GetID(), 1);
            Chat coo = new Chat(GetID(), 101); 
        }
        
        public void AdicionarVaga(int id)   //Adiciona o ID da vaga à lista de vagas inscritas
        {
            for (int i = 0; i < Vagas.Count; i++) if (Vagas[i] == id) return;
            Vagas.Insert(0, id);
        }

        public void RemoverVaga(int id)   //Adiciona o ID da vaga à lista de vagas inscritas
        {
            for (int i = 0; i < Vagas.Count; i++) if (Vagas[i] == id) Vagas.RemoveAt(i);
        }

        public List<int> GetVagas()
        {
            return Vagas;
        }

        public void SetVagas(List<int> vagas)
        {
            Vagas.Clear();
            for (int i = 0; i <= vagas.IndexOf(vagas.Last()); i++) Vagas.Add(vagas[i]);
        }

        public bool VagaInscrita(int idVaga)
        {
            for(int i=0; i<Vagas.Count; i++)
            {
                if (Vagas[i] == idVaga) return true;
            }
            return false;
        }
        public long GetRa()
        {
            return ra;
        }

        public void SetRa(long Ra)
        {
            ra = Ra;
        }
       
        public void SetCurso(int Curso)
        {
            curso = Curso;
        }
        
        public int GetCurso()
        {
            return curso;
        }

        public void SetSemestre(int Semestre)
        {
            semestre = Semestre;
        }

        public int GetSemestre()
        {
            return semestre;
        }

        public void SetFormacao(string Formacao)
        {
            formacao = Formacao;
        }

        public string GetFormacao()
        {
            return formacao;
        }

        public void SetExperiencia(string Experiencias)
        {
            experiencia = Experiencias;
        }

        public string GetExperiencia()
        {
            return experiencia;
        }

        public void Aprovar()
        {
            aprov++;
        }

        public int GetAprov()
        {
            return aprov;
        }
        public void ResetAprov()
        {
            aprov = 0;
        }
    }
}
