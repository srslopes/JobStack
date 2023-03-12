using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStack
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BancodeDados DB = new BancodeDados();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
            //bool exec = true;
            Console.WriteLine("Teste: Exibir DB");
            //int op=0;
            BancodeDados.ExibirAlunos();

            Console.WriteLine("Teste: Criar Aluno");
            BancodeDados.CriarAluno("fulano", "senha");
            BancodeDados.ExibirAlunos();

            Console.WriteLine("Teste: Excluir Aluno");
            BancodeDados.ExcluirAluno(BancodeDados.BuscarAluno("fulano"));
            BancodeDados.ExibirAlunos();

            
        }
    }
}
