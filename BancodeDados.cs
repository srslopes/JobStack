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

        private static List<Empresa> Empresas;              //Banco de dados das empresas (Lista de objetos da classe Empresa)                           
        private static int indexEmpresa;                    //Index da posição da empresa pesquisada

        private static List<Admin> Admins;                  //Banco de dados dos administradores (Lista de objetos da classe Admin)
        private static int indexAdmin;                      //Index da posição do administrador pesquisado

        private static List<Coordenador> Coordenadores;     //Banco de dados dos coordenadores (Lista de objetos da classe Coordenador)
        private static int indexCoordenador;                //Index da posição do coordenador pesquisado


        private string[] emails = {"a", "b", "c", "d", "e", "f", "g", "h"};                     //emails e senhas de usuários para popular os bancos de dados
        private string[] senhas = {"123", "234", "345", "456", "567", "678", "789", "890"};

        public BancodeDados()
        {
            Alunos = new List<Aluno>();
            Empresas = new List<Empresa>();
            Admins = new List<Admin>();
            Coordenadores = new List<Coordenador>();

            for (int i = 0; i < 2; i++) //Popula o banco de dados com os usuarios
            {
                CriarAluno(emails[i], senhas[i]);
                
                CriarEmpresa(emails[i + 2], senhas[i + 2]);

                CriarAdmin(emails[i+4], senhas[i+4]);

                CriarCoordenador(emails[i+6], senhas[i+6]);
            }
        }


        public static bool CriarAluno(string email, string senha) //Método para criar um novo aluno e adicionalo ao banco de dados, retorna falso se o aluno ja existe
        {
            Aluno novo = new Aluno(email, senha);
            if (AlunoExiste(novo)) return false;            
            Alunos.Add(novo);
            indexAluno = Alunos.IndexOf(novo);
            return true;
        }
        public static void ExcluirAluno(Aluno aluno)    //Remove o aluno indicado
        {
            Alunos.Remove(Alunos[indexAluno]);
        }

        public static Aluno BuscarAluno(string email)   //Retorna uma cópia do objeto aluno de mesmo email, retorna nulo se não existir
        {
            Aluno chk = new Aluno(email);
            if (AlunoExiste(chk))
            {
                chk.ClonarDe(Alunos[indexAluno]);
                return chk;
            }
            return null;            
        }


        public static void SalvarAluno(Aluno aluno) //Salva as alterações feitas
        {
            Alunos[indexAluno].ClonarDe(aluno);
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

        public static string ExibirAlunos()   //Exibe, no prompt, os dados dos alunos cadastrados
        {
            string txt = "";
            try
            {
                for (int i = 0; i <= Alunos.IndexOf(Alunos.Last()); i++)
                {
                    txt += "Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha() +" \n";
                    Console.WriteLine("Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha());
                }
                return txt;
            }
            catch(System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Alunos");
                return txt;
            }
        }



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

        public static void SalvarEmpresa(Empresa empresa)
        {
            Empresas[indexEmpresa].ClonarDe(empresa);
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
        public static void ExibirEmpresas()
        {
            try
            {
                for (int i = 0; i <= Empresas.IndexOf(Empresas.Last()); i++) Console.WriteLine("Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha());
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Empresas");
            }
            
        }


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

        public static void SalvarAdmin(Admin admin)
        {
            Admins[indexAdmin].ClonarDe(admin);
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
        public static void ExibirAdmins()
        {
            try
            {
                for (int i = 0; i <= Admins.IndexOf(Admins.Last()); i++) Console.WriteLine("Admin: " + Admins[i].GetEmail() + ", senha: " + Admins[i].GetSenha());
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Admins");
            }
            
        }


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

        public static void SalvarCoordenadora(Coordenador coordenador)
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

        public static void ExibirCoordenadores()
        {
            try
            {
                for (int i = 0; i <= Coordenadores.IndexOf(Coordenadores.Last()); i++) Console.WriteLine("Coordenador: " + Coordenadores[i].GetEmail() + ", senha: " + Coordenadores[i].GetSenha());
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Coordenadores");
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
       
    }
}
