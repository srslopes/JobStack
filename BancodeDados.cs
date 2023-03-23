/*********************************************************************************************************************************************
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
        private static int indexAluno;                      //Index da posição do aluno pesquisado
        private static int proxIdAluno;                     //Id do próximo aluno

        private static List<Empresa> Empresas;              //Banco de dados das empresas (Lista de objetos da classe Empresa)                           
        private static int indexEmpresa;                    //Index da posição da empresa pesquisada
        private static int proxIdEmpresa;                   //Id da próxima empresa

        private static List<Admin> Admins;                  //Banco de dados dos administradores (Lista de objetos da classe Admin)
        private static int indexAdmin;                      //Index da posição do administrador pesquisado
        private static int proxIdAdmin;                     //Id do próximo Admin

        private static List<Coordenador> Coordenadores;     //Banco de dados dos coordenadores (Lista de objetos da classe Coordenador)
        private static int indexCoordenador;                //Index da posição do coordenador pesquisado
        private static int proxIdCoordenador;               //Id do próximo coordenador

        private static int IdUser;

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
            try
            {
                for (int i = 0; i <= Alunos.IndexOf(Alunos.Last()); i++)
                {
                    if (Alunos[i].GetEmail().Equals(email)) return Alunos[i].GetID();
                }
                return 0;
            }
            catch (System.InvalidOperationException)
            {
                return 0;
            }
            
        }

        public static Aluno BuscarAluno(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            Aluno busc = new Aluno();
            busc.ClonarDe(Alunos[(id % 1000) - 1]);
            return busc;
        }

        public static bool SalvarAluno(Aluno aluno) //Salva o aluno na sua posição original
        {
            if (aluno.GetID() == 0 || BuscarID(aluno.GetEmail()) != 0) return false;
            Alunos[(aluno.GetID()%1000)-1].ClonarDe(aluno);
            return true;
        }


        public static string ExibirAlunos()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            try
            {
                for (int i = 0; i <= Alunos.IndexOf(Alunos.Last()); i++)
                {
                    txt += "ID: " + Alunos[i].GetID() + ", Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha() + "?";
                    Console.WriteLine("ID: " + Alunos[i].GetID() + "Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha());
                }
                return txt;
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Alunos");
                return txt;
            }
        }

        public static void ResetarIdsAlunos()       //Reseta os IDs dos alunos mantendo a ordem da lista
        {
            proxIdAluno = 1000;
            for (int i = 0; i <= Alunos.IndexOf(Alunos.Last()); i++) Alunos[i].SetID(GetNextIdAluno());
        }

        public static int GetNextIdAluno()  //retorna um novo ID
        {
            proxIdAluno++;
            return proxIdAluno;

        }

        //-------------------------------------------------------------------------------------------------


        public static bool CriarAluno(string email, string senha) //Método para criar um novo aluno e adiciona-lo ao banco de dados, retorna falso se o aluno ja existe
        {
            Aluno novo = new Aluno(email, senha);
            if (AlunoExiste(novo)) return false;
            Alunos.Add(novo);
            indexAluno = Alunos.IndexOf(novo);
            return true;
        }

        public static Aluno BuscarAluno(string email)         //Retorna o objeto aluno com o ID indicado,
        {
            Aluno busc = new Aluno();
            busc.ClonarDe(Alunos[1]);
            return busc;
        }
        public static void ExcluirAluno(Aluno aluno)    //Remove o aluno indicado
        {
            Alunos.Remove(Alunos[indexAluno]);
        }
        public static bool AlunoExiste(Aluno aluno) //Retorna verdadeiro se o aluno existe, falso se não
        {
            try
            {
                if (Alunos.Exists(obj => obj.GetEmail().Equals(aluno.GetEmail())))
                {
                    indexAluno = Alunos.FindIndex(obj => obj.GetEmail().Equals(aluno.GetEmail()));
                    return true;
                }
                indexAluno = 0;
                return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
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
            try
            {
                for (int i = 0; i <= Empresas.IndexOf(Empresas.Last()); i++)
                {
                    if (Empresas[i].GetEmail().Equals(email)) return Empresas[i].GetID();
                }
                return 0;
            }
            catch (System.InvalidOperationException)
            {
                return 0;
            }

        }

        public static Empresa BuscarEmpresa(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            Empresa busc = new Empresa();
            busc.ClonarDe(Empresas[(id % 1000) - 1]);
            return busc;
        }

        public static bool SalvarEmpresa(Empresa empresa) //Salva o aluno na sua posição original
        {
            if (empresa.GetID() == 0 || BuscarID(empresa.GetEmail()) != 0) return false;
            Empresas[(empresa.GetID() % 1000) - 1].ClonarDe(empresa);
            return true;
        }
        

        public static string ExibirEmpresas()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            try
            {
                for (int i = 0; i <= Empresas.IndexOf(Empresas.Last()); i++)
                {
                    txt += "ID: " + Empresas[i].GetID() + ", Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha() + "?";
                    Console.WriteLine("ID: " + Empresas[i].GetID() + "Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha());
                }
                return txt;
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Empresas");
                return txt;
            }
        }

        public static void ResetarIdsEmpresas()
        {
            proxIdEmpresa = 6000;
            for (int i = 0; i <= Empresas.IndexOf(Empresas.Last()); i++) Empresas[i].SetID(GetNextIdEmpresa());
        }
        public static int GetNextIdEmpresa()
        {
            proxIdEmpresa++;
            return proxIdEmpresa;
        }

        //------------------------------------------------------------------------------------------------------------



        public static bool CriarEmpresa(string email, string senha)
        {
            Empresa novo = new Empresa(email, senha);
            if (EmpresaExiste(novo)) return false;
            Empresas.Add(novo);
            indexEmpresa = Empresas.IndexOf(novo);
            return true;
        }

        public static void ExcluirEmpresa(Empresa empresa)
        {
            Empresas.Remove(empresa);
        }

        public static Empresa BuscarEmpresa(string email)
        {
            Empresa chk = new Empresa(email);
            if (EmpresaExiste(chk))
            {
                chk.ClonarDe(Empresas[indexEmpresa]);
                return chk;
            }
            return null;
        }


        public static bool EmpresaExiste(Empresa empresa)
        {
            try
            {
                if (Empresas.Exists(obj => obj.GetEmail().Equals(empresa.GetEmail())))
                {
                    indexEmpresa = Empresas.FindIndex(obj => obj.GetEmail().Equals(empresa.GetEmail()));
                    return true;
                }
                indexEmpresa = 0;
                return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }

        }
        

        //--------------------------------------------------------------- Métodos - Administradores ----------------------------------------------------------------------------

        public static bool AdicionarAdmin(Admin admin)                  //Método para adicionar uma nova empresa ao banco de dados,
        {                                                               //Retorna verdadeiro se a empresa foi adicionada com sucesso
            if (BuscarID(admin.GetEmail()) != 0) return false;     //Retorna falso se uma empresa com mesmo email já existe
            admin.SetID(GetNextIdAdmin());
            Admins.Add(admin);
            return true;
        }

        public static int BuscarIdAdmin(string email)               //Retorna o ID do aluno com o email inserido,
        {                                                           //Retorna 0 se esse aluno não existir
            try
            {
                for (int i = 0; i <= Admins.IndexOf(Admins.Last()); i++)
                {
                    if (Admins[i].GetEmail().Equals(email)) return Admins[i].GetID();
                }
                return 0;
            }
            catch (System.InvalidOperationException)
            {
                return 0;
            }

        }

        public static Admin BuscarAdmin(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            Admin busc = new Admin();
            busc.ClonarDe(Admins[(id % 100) - 1]);
            return busc;
        }

        public static bool SalvarAdmin(Admin admin) //Salva o aluno na sua posição original
        {
            if (admin.GetID() == 0 || BuscarID(admin.GetEmail()) != 0) return false;
            Admins[(admin.GetID() % 100) - 1].ClonarDe(admin);
            return true;
        }

        public static string ExibirAdmins()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            try
            {
                for (int i = 0; i <= Admins.IndexOf(Admins.Last()); i++)
                {
                    txt += "ID: " + Admins[i].GetID() + ", Admin: " + Admins[i].GetEmail() + ", senha: " + Admins[i].GetSenha() + "?";
                    Console.WriteLine("ID: " + Admins[i].GetID() + "Empresa: " + Admins[i].GetEmail() + ", senha: " + Admins[i].GetSenha());
                }
                return txt;
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Admins");
                return txt;
            }
        }
        public static void ResetarIdsAdmins()
        {
            proxIdAdmin = 0000;
            for (int i = 0; i <= Admins.IndexOf(Admins.Last()); i++) Admins[i].SetID(GetNextIdAdmin());
        }

        public static int GetNextIdAdmin()
        {
            proxIdAdmin++;
            return proxIdAdmin;
        }
        //-------------------------------------------------------------------------------------------------------------------------



        public static bool CriarAdmin(string email, string senha)
        {
            Admin novo = new Admin(email, senha);
            if (AdminExiste(novo)) return false;
            Admins.Add(novo);
            indexAdmin = Admins.IndexOf(novo);
            return true;
        }
        public static void ExcluirAdmin(Admin admin)
        {
            Admins.Remove(admin);
        }

        public static Admin BuscarAdmin(string email)
        {
            Admin chk = new Admin(email);
            if (AdminExiste(chk))
            {
                chk.ClonarDe(Admins[indexAdmin]);
                return chk;
            }
            return null;
        }
       

        public static bool AdminExiste(Admin admin)
        {
            try
            {
                if (Admins.Exists(obj => obj.GetEmail().Equals(admin.GetEmail())))
                {
                    indexAdmin = Admins.FindIndex(obj => obj.GetEmail().Equals(admin.GetEmail()));
                    return true;
                }
                indexAdmin = 0;
                return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
            
        }

        //---------------------------------------------------------------  Métodos - Coordenadores --------------------------------------------------------------------

        public static bool AdicionarCoordenador(Coordenador coordenador)                  //Método para adicionar uma nova empresa ao banco de dados,
        {                                                               //Retorna verdadeiro se a empresa foi adicionada com sucesso
            if (BuscarIdCoordenador(coordenador.GetEmail()) != 0) return false;     //Retorna falso se uma empresa com mesmo email já existe
            coordenador.SetID(GetNextIdCoordenador());
            Coordenadores.Add(coordenador);
            return true;
        }

        public static int BuscarIdCoordenador(string email)               //Retorna o ID do aluno com o email inserido,
        {                                                           //Retorna 0 se esse aluno não existir
            try
            {
                for (int i = 0; i <= Coordenadores.IndexOf(Coordenadores.Last()); i++)
                {
                    if (Coordenadores[i].GetEmail().Equals(email)) return Coordenadores[i].GetID();
                }
                return 0;
            }
            catch (System.InvalidOperationException)
            {
                return 0;
            }

        }

        public static Coordenador BuscarCoordenador(int id)         //Retorna o objeto aluno com o ID indicado,
        {
            Coordenador busc = new Coordenador();
            busc.ClonarDe(Coordenadores[(id % 100) - 1]);
            return busc;
        }

        public static bool SalvaCoordenador(Coordenador coordenador) //Salva o aluno na sua posição original
        {
            if (coordenador.GetID() == 0 || BuscarID(coordenador.GetEmail()) != 0) return false;
            Coordenadores[(coordenador.GetID() % 100) - 1].ClonarDe(coordenador);
            return true;
        }
        

        public static string ExibirCoordenadores()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            try
            {
                for (int i = 0; i <= Coordenadores.IndexOf(Coordenadores.Last()); i++)
                {
                    txt += "ID: " + Coordenadores[i].GetID() + ", Coordenador: " + Coordenadores[i].GetEmail() + ", senha: " + Coordenadores[i].GetSenha() + "?";
                    Console.WriteLine("ID: " + Coordenadores[i].GetID() + "Coordenador: " + Coordenadores[i].GetEmail() + ", senha: " + Coordenadores[i].GetSenha());
                }
                return txt;
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Coordenadores");
                return txt;
            }
        }

        public static void ResetarIdsCoordenadores()
        {
            proxIdCoordenador = 100;
            for (int i = 0; i <= Coordenadores.IndexOf(Coordenadores.Last()); i++) Coordenadores[i].SetID(GetNextIdCoordenador());
        }

        public static int GetNextIdCoordenador()
        {
            proxIdCoordenador++;
            return proxIdCoordenador;
        }

        //------------------------------------------------------------------------------------------------------------------------

        public static bool CriarCoordenador(string email, string senha)
        {
            Coordenador novo = new Coordenador(email, senha);
            if (CoordenadorExiste(novo)) return false;
            Coordenadores.Add(novo);
            indexCoordenador = Coordenadores.IndexOf(novo);
            return true;
        }

        public static void ExcluirCoordenador(Coordenador coordenador)
        {
            Coordenadores.Remove(coordenador);
        }


        public static Coordenador BuscarCoordenador(string email)
        {
            Coordenador chk = new Coordenador(email);
            if (CoordenadorExiste(chk))
            {
                chk.ClonarDe(Coordenadores[indexCoordenador]);
                return chk;
            }
            return null;
        }

        public static void SalvarCoordenador(Coordenador coordenador)
        {
            Coordenadores[indexCoordenador].ClonarDe(coordenador);
        }

        public static bool CoordenadorExiste(Coordenador coordenador)
        {
            try
            {
                if (Coordenadores.Exists(obj => obj.GetEmail().Equals(coordenador.GetEmail())))
                {
                    indexCoordenador = Coordenadores.FindIndex(obj => obj.GetEmail().Equals(coordenador.GetEmail()));
                    return true;
                }
                indexCoordenador = 0;
                return false;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }           
        }

       

        public static int Login(string email)
        {
            if (BuscarAluno(email) != null) return 1;
            if (BuscarEmpresa(email) != null) return 2;
            if (BuscarAdmin(email) != null) return 3;
            if (BuscarCoordenador(email) != null) return 4;
            return 0;
          
        }

        public static bool Login(int id, string senha)
        {
            if ((id / 1000 > 5) && (Empresas[(id % 1000) - 1].GetSenha().Equals(senha))) return true;
            else if ((id / 1000 > 0) && (id / 1000 < 5) && (Alunos[(id % 1000) - 1].GetSenha().Equals(senha))) return true;
            else if ((id / 1000 == 0) && (id / 100 == 1) && (Coordenadores[(id % 100) - 1].GetSenha().Equals(senha))) return true;
            else if ((id / 1000 == 0) && (id / 100 == 0) && (Admins[id - 1].GetSenha().Equals(senha))) return true;
            return false;
        }

        public static int BuscarID(string email)    //Procura no banco de dados o email inserido e retorna o id desse usuario,
        {                                           //Retorna 0 se nao existir usuario com essa senha    
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

        public static object BuscarUsuario(int id)
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

        public static bool SalvarUsuario(Object obj)
        {
            switch (obj.GetType().ToString())
            {
                case "JobStack.Aluno":
                    SalvarAluno((Aluno)obj);
                    break;
                case "JobStack.Empresa":
                    SalvarEmpresa((Empresa)obj);
                    break;
                case "JobStack.Admin":
                    SalvarAdmin((Admin)obj);
                    break;
                case "JobStack.Coordenador":
                    SalvarCoordenador((Coordenador)obj);
                    break;
            }
            return false;
        }

        public static void ExcluirUsuario(int id)    //Remove o aluno indicado
        {
            if(id/1000>5)
            {
                //Empresas[(id % 1000) - 1].Limpar();
                Empresas.Remove(Empresas[(id % 1000) - 1]);
                ResetarIdsEmpresas();
            }
            else if(id/1000>0)
            {
                //Alunos[(id % 1000) - 1].Limpar();
                Alunos.Remove(Alunos[(id % 1000) - 1]);
               ResetarIdsAlunos();
            }
            else if(id/100==1)
            {
                //Coordenadores[(id % 100) - 1].Limpar();
               Coordenadores.Remove(Coordenadores[(id % 100) - 1]);
                ResetarIdsCoordenadores();
            }
            else
            {
                //Admins[id - 1].Limpar();
                Admins.Remove(Admins[id - 1]);
                ResetarIdsAdmins();
            }
        }
        public static string ExibirDB()
        {
            return ExibirAlunos() + ExibirEmpresas() + ExibirAdmins() + ExibirCoordenadores();
        }

        public static int GetIdUser()
        {
            return IdUser;
        }

    }
}
