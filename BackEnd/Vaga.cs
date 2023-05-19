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
        private List<int> Inscritos;
        private int status;

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

        public void SetNome(string nome)
        {

        }

        public string getNome()
        {
            return nome;
        }
        public void SetDescricao(string nome)
        {

        }

        public string getDescricao()
        {
            return descricao;
        }
    }
}
