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
using System.Security.Cryptography;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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

        private static List<Chat> Chats;                    //Lista de Conversas


        private static List<BitmapImage> Imgs;

        private static List<int> ChatsAdm;

        private static List<int> ChatsCoord;

        public static TMenuAluno MenuAluno;
        public static TMenuEmpresa MenuEmpresa;
        public static TMenuCoordenador MenuCoordenador;
        public static TMenuAdministrador MenuAdministrador;


        //O sistema utiliza um sistema de ID onde cada usuário possui um ID de 4 dígitos que identificam não só o usúario individualmente como também o tipo de usuário
        // 00XX - Administradores do sistema
        // 01XX - Coordenadores
        // 1xxx ~ 5XXX - Alunos
        // 6XXX ~ 9XXX - Empresas


        private string[] emails = { "a", "b", "c", "d", "e", "f", "g", "h" };                     //emails e senhas de usuários para popular os bancos de dados
        private string[] senhas = { "123", "234", "345", "456", "567", "678", "789", "890" };

        public BancodeDados()
        {
            
            Alunos = new List<Aluno>();
            Empresas = new List<Empresa>();
            Admins = new List<Admin>();
            Coordenadores = new List<Coordenador>();
            Imgs = new List<BitmapImage>();
            ChatsAdm = new List<int>();
            ChatsCoord = new List<int>();
            AdicionarImagens();
            Vagas = new List<Vaga>();
            Chats = new List<Chat>();
            proxIdAluno = 1000;
            proxIdEmpresa = 6000;
            proxIdAdmin = 0;
            proxIdCoordenador = 100;
            proxIdVaga = 0;
            IdUser = 0;
            
            PopularUsuarios();
            PopularChat();
            PopularVagas();
        }


        //------------------------------------------ Métodos - Alunos -----------------------------------------------------


        public static bool AdicionarAluno(Aluno aluno)                  //Método para adicionar um novo aluno ao banco de dados,
        {                                                               //Retorna verdadeiro se o aluno foi adicionado com sucesso
            if (BuscarID(aluno.GetEmail()) != 0) return false;     //Retorna falso se um aluno com mesmo email já existe
            aluno.SetID(GetNextIdAluno());
            aluno.SetStatus(true);
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
            if (id / 1000 < 1 || id / 1000 > 5) return null;
            if ((id % 1000) - 1 >= Alunos.Count) return null;
            return Alunos[(id % 1000) - 1];
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
                txt += "ID: " + Alunos[i].GetID() + ", Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha();
                Console.Write("ID: " + Alunos[i].GetID() + "Aluno: " + Alunos[i].GetEmail() + ", senha: " + Alunos[i].GetSenha());
                if (Alunos[i].GetVagas().Count > 0) txt += " Vagas:";
                for (int j = 0; j < Alunos[i].GetVagas().Count; j++)
                {
                    txt += " ID: " + Alunos[i].GetVagas()[j] + ",";
                    Console.Write(", ID: " + Alunos[i].GetVagas()[j]);
                }
                txt += "?";
                Console.WriteLine();
            }
            return txt;
        }


        //-------------------------------------------------------- Métodos - Empresas --------------------------------------------------------------------------

        public static bool AdicionarEmpresa(Empresa empresa)                  //Método para adicionar uma nova empresa ao banco de dados,
        {                                                               //Retorna verdadeiro se a empresa foi adicionada com sucesso
            if (BuscarID(empresa.GetEmail()) != 0) return false;     //Retorna falso se uma empresa com mesmo email já existe
            empresa.SetID(GetNextIdEmpresa());
            empresa.SetStatus(true);
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
            if (id / 1000 < 6 || id / 1000 > 9) return null;
            if ((id % 1000) - 1 >= Empresas.Count) return null;
            return Empresas[(id % 1000) - 1];
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
                txt += "ID: " + Empresas[i].GetID() + ", Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha();
                Console.Write("ID: " + Empresas[i].GetID() + "Empresa: " + Empresas[i].GetEmail() + ", senha: " + Empresas[i].GetSenha());
                if (Empresas[i].GetVagas().Count > 0) txt += " Vagas:";
                for (int j = 0; j < Empresas[i].GetVagas().Count; j++)
                {
                    txt += " ID: " + Empresas[i].GetVagas()[j] + ",";
                    Console.Write(", ID: " + Empresas[i].GetVagas()[j]);
                }
                txt += "?";
                Console.WriteLine();
            }
            return txt;
        }

        //-------------------------------------------------- Métodos - Administradores ----------------------------------------------------------------------------

        public static bool AdicionarAdmin(Admin admin)                  //Método para adicionar uma nova empresa ao banco de dados,
        {                                                               //Retorna verdadeiro se a empresa foi adicionada com sucesso
            if (BuscarID(admin.GetEmail()) != 0) return false;     //Retorna falso se uma empresa com mesmo email já existe
            admin.SetID(GetNextIdAdmin());
            admin.SetStatus(true);
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
            if (id / 1000 != 0 || id / 100 !=0) return null;
            if ((id % 100) - 1 >= Admins.Count) return null;
            return Admins[(id % 100) - 1];
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
            coordenador.SetStatus(true);
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
            if (id / 1000 != 0 || id / 100 != 1) return null;
            if ((id % 100) - 1 >= Coordenadores.Count) return null;
            return Coordenadores[(id % 100) - 1];
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
            return ((Usuario)BuscarUsuario(GetIdUser())).GetSenha().Equals(CriptografarSenha(senha));
        }
        public static string CriptografarSenha(string senha)
        {
            // Cria o objeto de hash SHA256
            SHA256 sha256 = new SHA256Managed();

            // Calcula o hash da senha em bytes
            byte[] hashSenha = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));

            // Converte o hash em uma string em formato hexadecimal
            string senhaCriptografada = BitConverter.ToString(hashSenha).Replace("-", string.Empty);

            // Trunca a senha criptografada para 8 caracteres
            senhaCriptografada = senhaCriptografada.Substring(0, senha.Length);
            return senhaCriptografada;

        }




        public static int BuscarID(string email)    //Procura no banco de dados o usuário com o  email inserido e retorna o id dele,
        {            //Retorna 0 se nao existir usuario com esse email
            int id = BuscarIdAluno(email);
            if (id != 0) return id;
            id = BuscarIdEmpresa(email);
            if (id != 0) return id;
            id = BuscarIdAdmin(email);
            if (id != 0) return id;
            id = BuscarIdCoordenador(email);
            if (id != 0) return id;
            return 0;
        }

        public static object BuscarUsuario(int id)      //Retorna o usuario que possui o ID inserido
        {
            if (id / 1000 > 5) return Empresas[(id % 1000) - 1];
            else if (id / 1000 > 0) return Alunos[(id % 1000) - 1];
            else if (id / 100 == 1) return Coordenadores[(id % 100) - 1];
            else return Admins[id - 1];
        }

        public static object BuscarUsuario()      //Retorna o usuario que possui o ID inserido
        {
            int id = IdUser;
            if (id / 1000 > 5) return Empresas[(id % 1000) - 1];
            else if (id / 1000 > 0) return Alunos[(id % 1000) - 1];
            else if (id / 100 == 1) return Coordenadores[(id % 100) - 1];
            else return Admins[id - 1];
        }

        public static bool GetStatusUsuario(int id)
        {
            if (id / 1000 > 5) return Empresas[(id % 1000) - 1].GetStatus();
            else if (id / 1000 > 0) return Alunos[(id % 1000) - 1].GetStatus();
            else if (id / 100 == 1) return Coordenadores[(id % 100) - 1].GetStatus();
            else return Admins[id - 1].GetStatus();
        }

        public static bool AdicionarUsuario(Object obj)
        {
            switch (obj.GetType().ToString())
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

        public static void SetIdUser(int id)
        {
            IdUser = id;
        }

        private void PopularUsuarios()
        {
            Admin n1 = new Admin("admin1", "123");
            
            Admin n2 = new Admin("admin2", "234");

            Coordenador n3 = new Coordenador("coord1", "123");
            Coordenador n4 = new Coordenador("coord2", "234");

            IdUser = 101;
            Chat c = new Chat(1);
            IdUser = 0;

            Aluno n5 = new Aluno("e", "efg");
            n5.SetNome("Estevan Ferreira Rodrigues");
            n5.SetRa(966049137);
            n5.SetIdImg(3);
            n5.SetCurso(0);
            n5.SetSemestre(3);
            n5.SetFormacao("Ensino Médio completo");
            n5.SetExperiencia("nenhuma");
            Aluno n6 = new Aluno("b", "bcd");
            n6.SetNome("Beatrice Azevedo Santos");
            n6.SetRa(537388102);
            n6.SetIdImg(4);
            Aluno n7 = new Aluno("f", "fgh");
            n7.SetNome("Felipe Araujo Fernandes");
            n7.SetRa(872998654);
            n7.SetIdImg(5);
            Aluno n8 = new Aluno("i", "ijk");
            n8.SetNome("Isabelle Oliveira Goncalves");
            n8.SetRa(275375787);
            n8.SetIdImg(12);
            Aluno n9 = new Aluno("j", "jkl");
            n9.SetNome("Júlio Pinto Pereira");
            n9.SetRa(555101220);
            n9.SetIdImg(6);

            Empresa n10 = new Empresa("n", "nop");
            n10.SetNome("Nestlé SA");
            n10.SetIdImg(9);
            Empresa n11 = new Empresa("a", "abc");
            n11.SetNome("Ambev");
            n11.SetIdImg(10);
            Empresa n12 = new Empresa("p", "pqr");
            n12.SetNome("Pastelaria Mixaria");
            n12.SetIdImg(8);
            Empresa n13 = new Empresa("r", "rst");            
            n13.SetNome("Rosalina Supermercados");
            n13.SetIdImg(11);
            Empresa n14 = new Empresa("m", "mno");
            n14.SetNome("Maxion");
            n14.SetIdImg(7);
        }
        //----------------------------------- Métodos - Vagas ---------------------------------------------------------

        public static void AdicionarVaga(Vaga vaga)                  //Método para adicionar um novo aluno ao banco de dados,
        {
            Vagas.Add(vaga);
            vaga.SetID(Vagas.IndexOf(vaga));
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

        public static List<Vaga> GetListaVagas()
        {
            return Vagas;
        }

        public static string ExibirVagas()   //Exibe, no prompt, os dados dos alunos cadastrados
        {                                     //Retorna uma string com os dados dos alunos, separados pelo char '?' 
            string txt = "";
            for (int i = 0; i < Vagas.Count; i++)
            {
                txt += "ID: " + Vagas[i].GetID() + ", Empresa: " + BuscarEmpresa(Vagas[i].GetIdEmpresa()).GetEmail() + ", Status: " + Vagas[i].GetStatus();
                Console.Write("ID: " + Vagas[i].GetID() + "Empresa: " + BuscarEmpresa(Vagas[i].GetIdEmpresa()).GetEmail() + ", Status: " + Vagas[i].GetStatus());
                for (int j = 0; j < Vagas[i].GetLista().Count; j++)
                {
                    txt += ", ID " + (j + 1) + ": " + Vagas[i].GetLista()[j];
                    Console.Write(", ID " + (j + 1) + ": " + Vagas[i].GetLista()[j]);
                }
                txt += "?";
                Console.WriteLine();
            }
            return txt;

        }

        public static void PopularVagas()
        {
            IdUser = 6001;
            Vaga n1 = new Vaga(6001);
            n1.SetNome("Suporte Técnico");
            n1.SetTipo("Estágio");
            n1.SetCurso(0);
            n1.SetTurno("Tarde");
            n1.SetJornada("40h");
            n1.SetNVagas(5);
            n1.SetSalario("1000,00");
            n1.SetDescricao("Auxilie na resolução de problemas técnicos, suporte remoto e presencial aos usuários, garantindo o bom funcionamento dos sistemas e equipamentos, em uma das maiores empresas de alimentos do mundo.");
            n1.Aprovar();
            Vaga n2 = new Vaga(6001);
            n2.SetNome("Desenvolvimento");
            n2.SetTipo("Estágio");
            n2.SetCurso(0);
            n2.SetTurno("Tarde");
            n2.SetJornada("40h");
            n2.SetNVagas(5);
            n2.SetSalario("1000,00");
            n2.SetDescricao("Faça parte da equipe responsável por criar soluções tecnológicas inovadoras, desenvolvendo e aprimorando sistemas para impulsionar o crescimento e a eficiência em uma das líderes globais da indústria alimentícia.");
            Vaga n3 = new Vaga(6001);
            n3.SetNome("Analista de Processos");
            n3.SetTipo("Junior");
            n3.SetCurso(0);
            n3.SetTurno("Tarde");
            n3.SetJornada("40h");
            n3.SetNVagas(5);
            n3.SetSalario("1000,00");
            n3.SetDescricao("Contribua para otimizar os processos internos, identificando oportunidades de melhoria e implementando soluções eficientes, garantindo a qualidade e eficácia das operações em uma renomada empresa de alimentos e bebidas.");
            n3.Aprovar();
            Vaga n4 = new Vaga(6001);
            n4.SetNome("Gerente de TI");
            n4.SetTipo("Junior");
            n4.SetCurso(0);
            n4.SetTurno("Tarde");
            n4.SetJornada("40h");
            n4.SetNVagas(5);
            n4.SetSalario("1000,00");
            n4.SetDescricao("Suporte à equipe de TI, supervisionando projetos e processos, garantindo a entrega de soluções tecnológicas alinhadas aos objetivos estratégicos da empresa, em uma das principais empresas globais do setor alimentício.");
            n4.Encerrar();
            IdUser = 6002;
            Vaga n5 = new Vaga(6002);
            n5.SetNome("Jovem Aprendiz");
            n5.SetTipo("Estágio");
            n5.SetCurso(0);
            n5.SetTurno("Tarde");
            n5.SetJornada("40h");
            n5.SetNVagas(5);
            n5.SetSalario("1000,00");
            n5.SetDescricao("Oportunidade de aprendizado prático no setor de bebidas, adquirindo conhecimentos em diferentes áreas, auxiliando nas rotinas administrativas e contribuindo para o crescimento de uma das maiores empresas do ramo.");
            n5.Aprovar();
            Vaga n6 = new Vaga(6002);
            n6.SetNome("Ajudante de Logística");
            n6.SetTipo("Estágio");
            n6.SetCurso(0);
            n6.SetTurno("Tarde");
            n6.SetJornada("40h");
            n6.SetNVagas(5);
            n6.SetSalario("1000,00");
            n6.SetDescricao("Apoie as atividades de recebimento, armazenagem e distribuição de produtos, auxiliando na organização do estoque e no cumprimento de prazos, em uma das principais empresas do segmento de bebidas.");
            n6.Aprovar();
            Vaga n7 = new Vaga(6002);
            n7.SetNome("Técnico em TI");
            n7.SetTipo("Junior");
            n7.SetCurso(0);
            n7.SetTurno("Tarde");
            n7.SetJornada("40h");
            n7.SetNVagas(5);
            n7.SetSalario("1000,00");
            n7.SetDescricao("Suporte técnico aos usuários, manutenção de equipamentos, instalação e configuração de softwares, garantindo o funcionamento eficiente da infraestrutura tecnológica em uma empresa líder no mercado de bebidas.");
            Vaga n8 = new Vaga(6002);
            n8.SetNome("Desenvolvimento");
            n8.SetTipo("Junior");
            n8.SetCurso(0);
            n8.SetTurno("Tarde");
            n8.SetJornada("40h");
            n8.SetNVagas(5);
            n8.SetSalario("1000,00");
            n8.SetDescricao("Participe da criação e manutenção de sistemas, desenvolvendo soluções inovadoras para impulsionar a eficiência dos processos, em uma das maiores empresas do setor de bebidas.");
            n8.Aprovar();
        }
        //--------------------------------------- Métodos - Chats --------------------------------------------------------
        public static int AdicionarChat(Chat chat)
        {
            Chats.Add(chat);
            return Chats.IndexOf(chat);
        }

        public static Chat BuscarChat(int id)
        {
            return Chats[id];
        }

        public static int BuscarOutroParticipante(int id)
        {
            if (BuscarChat(id).GetParticipante1() == GetIdUser()) return BuscarChat(id).GetParticipante2();
            else return BuscarChat(id).GetParticipante1();
        }

        public static List<int> GetChatsAdm()
        {
            return ChatsAdm;
        }

        public static void SetChatsAdm(List<int> lista)
        {
            ChatsAdm = lista;
        }
        public static List<int> GetChatsCoord()
        {
            return ChatsCoord;
        }

        public static void SetChatsCoord(List<int> lista)
        {
            ChatsCoord = lista;
        }
         private static void PopularChat()
        {
            
            BancodeDados.SetIdUser(1001);
            Chat n2 = new Chat(6001);
            Chat n3 = new Chat(6002);            
            BancodeDados.SetIdUser(1002);
            Chat n4 = new Chat(6001);
            Chat n5 = new Chat(6002);            
            BancodeDados.SetIdUser(0);
           
        }

        //--------------------------------------- Métodos - Imagens --------------------------------------------------------


        // Método que converte uma imagem em um array de bytes
       /* private static byte[] ConverterImagemParaBytes(BitmapImage imagem)
        {
            // Cria um MemoryStream para armazenar a imagem
            using (MemoryStream ms = new MemoryStream())
            {
                // Salva a imagem no MemoryStream no formato PNG
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(imagem));
                encoder.Save(ms);

                // Retorna o array de bytes da imagem armazenada no MemoryStream
                return ms.ToArray();
            }
        }*/
        // Método que converte um array de bytes em uma imagem

    

        public static  int SalvarImg(BitmapImage imagem)
        {
            Imgs.Add(imagem);
            return Imgs.IndexOf(imagem);
        }
        public static void AdicionarImagens()
        {
            Imgs.Add(new BitmapImage(new Uri("Imagens/73027003-bd4d-4c64-8d94-2fcf04792ed6.png", UriKind.Relative)));//0
            Imgs.Add(new BitmapImage(new Uri("Imagens/dd839fb9-4ecd-4e6a-a424-1f07c4c32811.png", UriKind.Relative)));//1
            Imgs.Add(new BitmapImage(new Uri("Imagens/f7b6822a-38f7-4974-bb0f-acda7e4b1916.png", UriKind.Relative)));//2
            Imgs.Add(new BitmapImage(new Uri("Imagens/estevan.png", UriKind.Relative)));//3
            Imgs.Add(new BitmapImage(new Uri("Imagens/beatrice.png", UriKind.Relative)));//4
            Imgs.Add(new BitmapImage(new Uri("Imagens/felipe.png", UriKind.Relative)));//5
            Imgs.Add(new BitmapImage(new Uri("Imagens/julio.png", UriKind.Relative)));//6
            Imgs.Add(new BitmapImage(new Uri("Imagens/maxion.png", UriKind.Relative)));//7
            Imgs.Add(new BitmapImage(new Uri("Imagens/mixaria.png", UriKind.Relative)));//8
            Imgs.Add(new BitmapImage(new Uri("Imagens/nestle.png", UriKind.Relative)));//9
            Imgs.Add(new BitmapImage(new Uri("Imagens/ambev.png", UriKind.Relative)));//10
            Imgs.Add(new BitmapImage(new Uri("Imagens/rosalina.png", UriKind.Relative)));//11
            Imgs.Add(new BitmapImage(new Uri("Imagens/isabelle.png", UriKind.Relative)));//12
        }

        public static BitmapImage BuscarImg(int id)
        {
            if (id >= 0 && id < Imgs.Count)
            {
                return Imgs[id];
            }

            return null;
        }
      
        public static void AttNtChat()
        {
            if (GetIdUser() > 1000 && GetIdUser() < 6000) MenuAluno.NtChat();
            else if (GetIdUser() > 6000 && GetIdUser() < 10000) MenuEmpresa.NtChat();
            else if (GetIdUser() > 100 && GetIdUser() < 1000) MenuCoordenador.NtChat();
            else if (GetIdUser() > 0 && GetIdUser() < 100) MenuAdministrador.NtChat();

        }

    }
}
