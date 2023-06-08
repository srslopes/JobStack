using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
   class Vaga
    {
        private int ID;                 //ID de 4 digitos, se o primeiro digito for 0 a vaga ainda não foi aprovada
        private int IdEmpresa;
        private string nome;
        private string descricao;
        private string tipo;
        private string curso;
        private string turno;
        private string jornada;
        private List<int> Inscritos;
        private int status;
        private int nvagas;

        //         Status
        // 0 : Aguardando aprovação
        // 1 : Aprovação rejeitada
        // 2 : Aprovado
        // 3 : Encerrado

        public Vaga(int idEmpresa)                  //Cria uma nova vaga; (Obrigatória entrada do ID da empresa)
        {                                           //Vaga salva na lista de vagas não aprovadas
            IdEmpresa = idEmpresa;                  //Status estabelecido como "Aguardando Aprovação"
            Inscritos = new List<int>();
            status = 0;
            nome = "";
            descricao = "";
            tipo = "";
            curso = "";
            turno = "";
            jornada = "";
            nvagas = 0;
            BancodeDados.AdicionarVaga(this);
        }
        
        public int GetID()
        {
            return ID;
        }
        public void SetID(int id)
        {
            ID = id;
        }
        public int GetIdEmpresa()
        {
            return IdEmpresa;
        }

        public int GetStatus()
        {
            return status;
        }

        public void Aprovar()
        {
            status = 2;
        }

        public void Rejeitar()
        {
            status = 1;
        }

        public void Encerrar()
        {
            status = 3;
        }

        public List<int> GetLista()
        {
            return Inscritos;
        }

        public void Inscrever(int id)       //Adiciona o ID do usuario inscrito à lista de inscritos
        {
            for(int i=0; i< Inscritos.Count; i++) if(Inscritos[i] == id) return;
            Inscritos.Add(id);
        }

        public void Desinscrever(int id)    //Remove o ID do Usuario da lista de inscritos
        {
            for (int i = 0; i < Inscritos.Count; i++)
            {
                if (Inscritos[i] == id) Inscritos.RemoveAt(i);
            }
        }

        public void SetNome(string Nome)
        {
            nome = Nome;
        }

        public string GetNome()
        {
            return nome;
        }        
        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string Tipo)
        {
            tipo = Tipo;
        }
        public void SetDescricao(string Descricao)
        {
            descricao = Descricao;
        }
        public string GetDescricao()
        {
            return descricao;
        }
        public void SetCurso(string Curso)
        {
            curso = Curso;
        }
        public string GetCurso()
        {
            return curso;
        }
        public void SetTurno(string Turno)
        {
            turno = Turno;
        }
        public string GetTurno()
        {
            return turno;
        }
        public void SetJornada(string Jornada)
        {
            jornada = Jornada;
        }
        public string GetJornada()
        {
            return jornada;
        }
        public void SetNVagas(int nVagas)
        {
            nvagas = nVagas;
        }
        public int GetNVagas()
        {
            return nvagas;
        }
    }
}
