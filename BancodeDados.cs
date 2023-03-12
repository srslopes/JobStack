using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStack
{
    class BancodeDados
    {
        public static List<Aluno> Alunos;
        public static int indexAluno;
        public static List<Empresa> Empresas;
        public static int indexEmpresa;
        public static List<Admin> Admins;
        public static int indexAdmin;
        public static List<Coordenador> Coordenadores;
        public static int indexCoordenador;
        private string[] emails = {"a", "b", "c", "d", "e", "f", "g", "h"};
        private string[] senhas = {"123", "234", "345", "456", "567", "678", "789", "890"};

        public BancodeDados()
        {
            Alunos = new List<Aluno>();
            Empresas = new List<Empresa>();
            Admins = new List<Admin>();
            Coordenadores = new List<Coordenador>();

            for (int i = 0; i < 2; i++)
            {
                CriarAluno(emails[i], senhas[i]);
                
                CriarEmpresa(emails[i + 2], senhas[i + 2]);

                CriarAdmin(emails[i+4], senhas[i+4]);

                CriarCoordenador(emails[i+6], senhas[i+6]);
            }
        }

        public static bool CriarAluno(string email, string senha)
        {
            Aluno novo = new Aluno(email, senha);
            if (AlunoExiste(novo)) return false;            
            Alunos.Add(novo);
            return true;
        }
        public static void ExcluirAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }

        public static Aluno BuscarAluno(string email)
        {
            Aluno chk = new Aluno(email);
            if (AlunoExiste(chk)) return Alunos[indexAluno];
            return null;            
        }

        public static void SalvarAluno(Aluno aluno)
        {
            Alunos[indexAluno] = aluno;
        }

        public static bool AlunoExiste(Aluno aluno)
        {
            try
            {
                if (Alunos.Exists(obj => obj.GetEmail().Equals(aluno.GetEmail())))
                {
                    indexAluno = Alunos.FindIndex(obj => obj.GetEmail().Equals(aluno.GetEmail()));
                    return true;
                }
                indexAluno = 0;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
            
            return false;
        }

        public static void ExibirAlunos()
        {
            try
            {
                for (int i = 0; i <= Alunos.IndexOf(Alunos.Last()); i++)
                    Console.WriteLine("Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha());
            }
            catch(System.ArgumentNullException)
            {
                Console.WriteLine("Falha ao exibir Alunos");
            }
        }



        public static bool CriarEmpresa(string email, string senha)
        {
            Empresa novo = new Empresa(email, senha);
            if (EmpresaExiste(novo)) return false;
            Empresas.Add(novo);
            return true;
        }

        public static void ExcluirEmpresa(Empresa empresa)
        {
            Empresas.Remove(empresa);
        }

        public static Empresa BuscarEmpresa(string email)
        {
            Empresa chk = new Empresa(email);
            if (EmpresaExiste(chk)) return Empresas[indexEmpresa];
            return null;
        }

        public static void SalvarEmpresa(Empresa empresa)
        {
            Empresas[indexEmpresa] = empresa;
        }

        public static bool EmpresaExiste(Empresa empresa)
        {
            if (Empresas.Exists(obj => obj.GetEmail().Equals(empresa.GetEmail())))
            {
                indexEmpresa = Empresas.FindIndex(obj => obj.GetEmail().Equals(empresa.GetEmail()));
                return true;
            }
            indexEmpresa = 0;
            return false;
        }
        public static void ExibirEmpresas()
        {
            for (int i = 0; i <= Empresas.IndexOf(Empresas.Last()); i++)
                Console.WriteLine("Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha());
        }


        public static bool CriarAdmin(string email, string senha)
        {
            Admin novo = new Admin(email, senha);
            if (AdminExiste(novo)) return false;
            Admins.Add(novo);
            return true;
        }
        public static void ExcluirAdmin(Admin admin)
        {
            Admins.Remove(admin);
        }

        public static Admin BuscarAdmin(string email)
        {
            Admin chk = new Admin(email);
            if (AdminExiste(chk)) return Admins[indexAdmin];
            return null;
        }

        public static void SalvarAdmin(Admin admin)
        {
            Admins[indexAdmin] = admin;
        }

        public static bool AdminExiste(Admin admin)
        {
            if (Admins.Exists(obj => obj.GetEmail().Equals(admin.GetEmail())))
            {
                indexAdmin = Alunos.FindIndex(obj => obj.GetEmail().Equals(admin.GetEmail()));
                return true;
            }
            indexAdmin = 0;
            return false;
        }
        public static void ExibirAdmins()
        {
            for (int i = 0; i <= Admins.IndexOf(Admins.Last()); i++)
                Console.WriteLine("Admin: " + Admins[i].GetEmail() + ", senha: " + Admins[i].GetSenha());
        }


        public static bool CriarCoordenador(string email, string senha)
        {
            Coordenador novo = new Coordenador(email, senha);
            if (CoordenadorExiste(novo)) return false;
            Coordenadores.Add(novo);
            return true;
        }

        public static void ExcluirCoordenador(Coordenador coordenador)
        {
            Coordenadores.Remove(coordenador);
        }


        public static Coordenador BuscarCoordenador(string email)
        {
            Coordenador chk = new Coordenador(email);
            if (CoordenadorExiste(chk)) return Coordenadores[indexCoordenador];
            return null;
        }

        public static void SalvarCoordenadora(Coordenador coordenador)
        {
            Coordenadores[indexCoordenador] = coordenador;
        }

        public static bool CoordenadorExiste(Coordenador coordenador)
        {
            if (Coordenadores.Exists(obj => obj.GetEmail().Equals(coordenador.GetEmail())))
            {
                indexCoordenador = Coordenadores.FindIndex(obj => obj.GetEmail().Equals(coordenador.GetEmail()));
                return true;
            }
            indexCoordenador = 0;
            return false;
        }
        public static void ExibirCoordenadores()
        {
            for (int i = 0; i <= Coordenadores.IndexOf(Coordenadores.Last()); i++)
                Console.WriteLine("Coordenador: " + Coordenadores[i].GetEmail() + ", senha: " + Coordenadores[i].GetSenha());
        }

    }
}
