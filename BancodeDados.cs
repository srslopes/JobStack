﻿/*********************************************************************************************************************************************
/                                        MODELO DE BANCO DE DADOS USANDO MEMÓRIA PRINCIPAL                                                   /
/                          Utiliza listas para armazenar os diferentes tipos de objetos usados no projeto                                    /
/                                                        Autor: Samuel Lopes                                                                 /
*********************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class BancodeDados
    {
        private static List<Aluno> Alunos;                  //Banco de dados dos alunos (Lista de objetos da classe Aluno)
        private static int proxIdAluno;                     //Id do próximo aluno

        private static List<Empresa> Empresas;              //Banco de dados das empresas (Lista de objetos da classe Empresa)
        private static int proxIdEmpresa;                   //Id da próxima empresa

        private static List<Admin> Admins;                  //Banco de dados dos administradores (Lista de objetos da classe Admin)
        private static int proxIdAdmin;                     //Id do próximo Admin

        private static List<Coordenador> Coordenadores;     //Banco de dados dos coordenadores (Lista de objetos da classe Coordenador)
        private static int proxIdCoordenador;               //Id do próximo coordenador

        private static int IdUser;                          //ID do usuário 

        private static List<Vaga> Vagas;                    //Lista de vagas
        private static int proxIdVaga;

        //O sistema utiliza um sistema de ID onde cada usuário possui um ID de 4 dígitos que identificam não só o usúario individualmente como também o tipo de usuário
        // 00XX - Administradores do sistema
        // 01XX - Coordenadores
        // 1xxx ~ 5XXX - Alunos
        // 6XXX ~ 9XXX - Empresas


        private string[] emails = {"a", "b", "c", "d", "e", "f", "g", "h"};                     //emails e senhas de usuários para popular os bancos de dados
        private string[] senhas = {"123", "234", "345", "456", "567", "678", "789", "890"};

        public BancodeDados()
        {
            Alunos = new List<Aluno>();
            Empresas = new List<Empresa>();
            Admins = new List<Admin>();
            Coordenadores = new List<Coordenador>();
            proxIdAluno = 1000;
            proxIdEmpresa = 6000;
            proxIdAdmin = 0;
            proxIdCoordenador = 100;
            proxIdVaga = 0;
            IdUser = 0;

            for (int i = 0; i < 2; i++) //Popula o banco de dados com os usuarios
            {
                Aluno n1 = new Aluno(emails[i], senhas[i]);
                AdicionarAluno(n1);

                Empresa n2 = new Empresa(emails[i + 2], senhas[i + 2]);
                AdicionarEmpresa(n2);

                Admin n3 = new Admin(emails[i + 4], senhas[i + 4]);
                AdicionarAdmin(n3);

                Coordenador n4 = new Coordenador(emails[i + 6], senhas[i + 6]);
                AdicionarCoordenador(n4);

            }
        }

        
        //------------------------------------------ Métodos - Alunos -----------------------------------------------------
        
        
        public static bool AdicionarAluno(Aluno aluno)                  //Método para adicionar um novo aluno ao banco de dados,
        {                                                               //Retorna verdadeiro se o aluno foi adicionado com sucesso
            if (BuscarID(aluno.GetEmail()) != 0) return false;     //Retorna falso se um aluno com mesmo email já existe
            aluno.SetID(GetNextIdAluno());
            Alunos.Add(aluno);
            return true;
        }

        public static int BuscarIdAluno(string email)               //Retorna o ID do aluno com o email inserido,
        {                                                           //Retorna 0 se esse aluno não existir        
            for (int i = 0; i < Alunos.Count; i++)
            {
                if (Alunos[i].GetEmail().Equals(email)) return Alunos[i].GetID();
            }
            return 0;           
        }

        public static Aluno BuscarAluno(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            if(id/1000>=1 && id/1000<6) return Alunos[(id % 1000) - 1];
            return null;
        }

        public static Aluno CarregarAluno()         //Retorna o objeto aluno com o ID indicado,
        {
            int id = GetIdUser();
            if (id / 1000 >= 1 && id / 1000 < 6) return Alunos[(id % 1000) - 1];
            return null;
        }

        public static int GetNextIdAluno()  //retorna um novo ID
        {
            proxIdAluno++;
            return proxIdAluno;
        }

        public static string ExibirAlunos()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            for (int i = 0; i < Alunos.Count; i++)
            {
                txt += "ID: " + Alunos[i].GetID() + ", Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha() + "?";
                Console.WriteLine("ID: " + Alunos[i].GetID() + "Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha());
            }
            return txt;
        }


        //-------------------------------------------------------- Métodos - Empresas --------------------------------------------------------------------------

        public static bool AdicionarEmpresa(Empresa empresa)                  //Método para adicionar uma nova empresa ao banco de dados,
        {                                                               //Retorna verdadeiro se a empresa foi adicionada com sucesso
            if (BuscarID(empresa.GetEmail()) != 0) return false;     //Retorna falso se uma empresa com mesmo email já existe
            empresa.SetID(GetNextIdEmpresa());
            Empresas.Add(empresa);
            return true;
        }

        public static int BuscarIdEmpresa(string email)               //Retorna o ID do aluno com o email inserido,
        {                                                           //Retorna 0 se esse aluno não existir
            for (int i = 0; i < Empresas.Count; i++)
            {
                if (Empresas[i].GetEmail().Equals(email)) return Empresas[i].GetID();
            }
            return 0;
        }

        public static Empresa BuscarEmpresa(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            if (id / 1000 >= 6 && id / 1000 < 10) return Empresas[(id % 1000) - 1];
            return null;
        }

        public static Empresa CarregarEmpresa()         //Retorna o objeto aluno logado,
        {
            int id = GetIdUser();
            if (id / 1000 >= 6 && id / 1000 < 10) return Empresas[(id % 1000) - 1];
            return null;
        }

        public static int GetNextIdEmpresa()
        {
            proxIdEmpresa++;
            return proxIdEmpresa;
        }

        public static string ExibirEmpresas()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            for (int i = 0; i < Empresas.Count; i++)
            {
                txt += "ID: " + Empresas[i].GetID() + ", Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha() + "?";
                Console.WriteLine("ID: " + Empresas[i].GetID() + "Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha());
            }
            return txt;           
        }        

        //-------------------------------------------------- Métodos - Administradores ----------------------------------------------------------------------------

        public static bool AdicionarAdmin(Admin admin)                  //Método para adicionar uma nova empresa ao banco de dados,
        {                                                               //Retorna verdadeiro se a empresa foi adicionada com sucesso
            if (BuscarID(admin.GetEmail()) != 0) return false;     //Retorna falso se uma empresa com mesmo email já existe
            admin.SetID(GetNextIdAdmin());
            Admins.Add(admin);
            return true;
        }

        public static int BuscarIdAdmin(string email)               //Retorna o ID do aluno com o email inserido,
        {                                                           //Retorna 0 se esse aluno não existir
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].GetEmail().Equals(email)) return Admins[i].GetID();
            }
            return 0;
        }

        public static Admin BuscarAdmin(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            if (id/1000 == 0 && id/100 == 0) return Admins[(id % 100) - 1];
            return null;
        }

        public static Admin CarregarAdmin()         //Retorna o objeto aluno com o ID indicado,
        {
            int id = GetIdUser();
            if (id / 1000 == 0 && id / 100 == 0) return Admins[(id % 100) - 1];
            return null;
        }


        public static int GetNextIdAdmin()
        {
            proxIdAdmin++;
            return proxIdAdmin;
        }

        public static string ExibirAdmins()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            for (int i = 0; i < Admins.Count; i++)
            {
                txt += "ID: " + Admins[i].GetID() + ", Admin: " + Admins[i].GetEmail() + ", senha: " + Admins[i].GetSenha() + "?";
                Console.WriteLine("ID: " + Admins[i].GetID() + "Empresa: " + Admins[i].GetEmail() + ", senha: " + Admins[i].GetSenha());
            }
            return txt;            
        }

        //-------------------------------------------- Métodos - Coordenadores --------------------------------------------------------------------

        public static bool AdicionarCoordenador(Coordenador coordenador)                  //Método para adicionar uma nova empresa ao banco de dados,
        {                                                               //Retorna verdadeiro se a empresa foi adicionada com sucesso
            if (BuscarIdCoordenador(coordenador.GetEmail()) != 0) return false;     //Retorna falso se uma empresa com mesmo email já existe
            coordenador.SetID(GetNextIdCoordenador());
            Coordenadores.Add(coordenador);
            return true;
        }

        public static int BuscarIdCoordenador(string email)               //Retorna o ID do aluno com o email inserido,
        {                                                           //Retorna 0 se esse aluno não existir
            for (int i = 0; i < Coordenadores.Count; i++)
            {
                if (Coordenadores[i].GetEmail().Equals(email)) return Coordenadores[i].GetID();
            }
            return 0;            
        }

        public static Coordenador BuscarCoordenador(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            if (id/1000 ==0 && id/100 ==1) return Coordenadores[(id % 100) - 1];
            return null;
        }

        public static Coordenador CarregarCoordenador()         //Retorna o objeto aluno com o ID indicado,
        {
            int id = GetIdUser();
            if (id / 1000 == 0 && id / 100 == 1) return Coordenadores[(id % 100) - 1];
            return null;
        }

        public static int GetNextIdCoordenador()
        {
            proxIdCoordenador++;
            return proxIdCoordenador;
        }

        public static string ExibirCoordenadores()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            for (int i = 0; i < Coordenadores.Count; i++)
            {
                txt += "ID: " + Coordenadores[i].GetID() + ", Coordenador: " + Coordenadores[i].GetEmail() + ", senha: " + Coordenadores[i].GetSenha() + "?";
                Console.WriteLine("ID: " + Coordenadores[i].GetID() + "Coordenador: " + Coordenadores[i].GetEmail() + ", senha: " + Coordenadores[i].GetSenha());
            }
            return txt;            
        }

        //--------------------------------------------------------- Métodos Universais ---------------------------------------------------------------
                                                         //Interagem com todos os tipos de usuário

        public static bool Login(string senha)  //Retorna verdadeiro se a senha inserida é a mesma que a do usuário com o ID indicado
        {                                               //Retorna falso se a senha estiver incorreta
            int id = GetIdUser();
            if ((id / 1000 > 5) && (Empresas[(id % 1000) - 1].GetSenha().Equals(senha))) return true;
            else if ((id / 1000 > 0) && (id / 1000 < 5) && (Alunos[(id % 1000) - 1].GetSenha().Equals(senha))) return true;
            else if ((id / 1000 == 0) && (id / 100 == 1) && (Coordenadores[(id % 100) - 1].GetSenha().Equals(senha))) return true;
            else if ((id / 1000 == 0) && (id / 100 == 0) && (Admins[id - 1].GetSenha().Equals(senha))) return true;
            return false;
        }

        public static int BuscarID(string email)    //Procura no banco de dados o usuário com o  email inserido e retorna o id dele,
        {                                           //Retorna 0 se nao existir usuario com esse email    
            IdUser = BuscarIdAluno(email);
            if ( IdUser != 0) return IdUser;
            IdUser = BuscarIdEmpresa(email);
            if (IdUser != 0) return IdUser;
            IdUser = BuscarIdAdmin(email);
            if (IdUser != 0) return IdUser;
            IdUser = BuscarIdCoordenador(email);
            if (IdUser != 0) return IdUser;
            return 0;
        }

        public static object BuscarUsuario(int id)      //Retorna o usuario que possui o ID inserido
        {
            IdUser = id;
            if (id / 1000 > 5) return Empresas[(id % 1000) - 1];
            else if (id / 1000 > 0) return Alunos[(id % 1000) - 1];
            else if (id / 100 == 1) return Coordenadores[(id % 100) - 1];
            else return Admins[id - 1];
        }

        public static bool AdicionarUsuario(Object obj) 
        {
            switch(obj.GetType().ToString())
            {
                case "JobStack.Aluno":
                    return AdicionarAluno((Aluno)obj);
                case "JobStack.Empresa":
                    return AdicionarEmpresa((Empresa)obj);
                case "JobStack.Admin":
                    return AdicionarAdmin((Admin)obj);
                case "JobStack.Coordenador":
                    return AdicionarCoordenador((Coordenador)obj);
            }
            return false;
        }
    
        public static string ExibirDB()
        {
            return ExibirAlunos() + ExibirEmpresas() + ExibirAdmins() + ExibirCoordenadores();
        }

        public static int GetIdUser()
        {
            return IdUser;
        }


        //----------------------------------- Métodos - Vagas ---------------------------------------------------------

        public static int AdicionarVaga(Vaga vaga)                  //Método para adicionar um novo aluno ao banco de dados,
        {
            Vagas.Add(vaga);
            return Vagas.IndexOf(vaga);
        }        

        public static Vaga BuscarVaga(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            return Vagas[id];
        } 

        public static int GetNextIdVaga()  //retorna um novo ID
        {
            proxIdVaga++;
            return proxIdVaga;
        }

        public static string ExibirVagas()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            for (int i = 0; i < Vagas.Count; i++)
            {
                txt += "ID: " + Vagas[i].GetID() + ", Empresa: " + BuscarEmpresa(Vagas[i].GetIdEmpresa()).GetEmail() + ", Status: " + Vagas[i].GetStatus() + "?";
                Console.WriteLine("ID: " + Vagas[i].GetID() + "Empresa: " + BuscarEmpresa(Vagas[i].GetIdEmpresa()).GetEmail() + ", Status: " + Vagas[i].GetStatus());
            }
            return txt;
            
        }
    }
}
