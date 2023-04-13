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
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());    
            Console.WriteLine("Senha : 123");
            Console.WriteLine("Criptografada: " + BancodeDados.CriptografarSenha("123"));           
            Application.Run(new Login());
         

            /*
            string email = "";
            int usuario = BancodeDados.Login(email);
            switch (usuario)
            {
                case 1:

                    if(BancodeDados.BuscarAluno(email).GetSenha().Equals(campo senha))
                    {
                        abre a janela aluno
                    }
                    else
                    {
                        printa senha incorreta
                    }
                    break;
            }
            */

        }
    }
}
