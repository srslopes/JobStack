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
        private List<int> Inscritos;
        private string Status;

        public Vaga(int idEmpresa)                  //Cria uma nova vaga; (Obrigatória entrada do ID da empresa)
        {                                           //Vaga salva na lista de vagas não aprovadas
            IdEmpresa = idEmpresa;                  //Status estabelecido como "Aguardando Aprovação"
            Inscritos = new List<int>();
            Status = "Aguardando aprovação";
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

        public string GetStatus()
        {
            return Status;
        }

        public void SetStatus(string status)
        {
            Status = status;
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

        public void Aprovar()   //Muda o status para 'aprovada'
        {
            if (Status.Equals("Aguardando aprovação"))
            {
                Status = "Aprovada";
            }
        }

        public void Desaprovar()
        {
            Status = "Desaprovada";
        }

        public void Encerrar()
        {
            Status = "Encerrada";
        }
    }
}
