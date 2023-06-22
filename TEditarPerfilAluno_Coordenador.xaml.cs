using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Interação lógica para TEditarPerfilAluno_Coordenador.xam
    /// </summary>
    public partial class TEditarPerfilAluno_Coordenador : UserControl
    {
        private Aluno aluno;
        private bool bt;
        public TEditarPerfilAluno_Coordenador(int id)
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(id);
            AttDados();
            bt = false;
            EsconderErros();
        }
        public void AttDados()
        {
            NomeAluno.Text = aluno.GetNome();
            CBCursos.SelectedIndex = aluno.GetCurso();
            CBPeriodo.SelectedIndex = aluno.GetSemestre() - 1;
            RAAluno.Text = aluno.GetRa().ToString();
            EmailAluno.Text = aluno.GetEmail();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilAluno_Coordenador te = new TExibirPerfilAluno_Coordenador(aluno.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }

        public void EsconderErros()
        {
            ErroNome.Visibility = Visibility.Hidden;
            ErroRAvazio.Visibility = Visibility.Hidden;
            ErroRAinvalido.Visibility = Visibility.Hidden;
            ErroEmailExiste.Visibility = Visibility.Hidden;
            ErroEmailVazio.Visibility = Visibility.Hidden;
            ErroSenha.Visibility = Visibility.Hidden;
            ErroCurso.Visibility = Visibility.Hidden;
            ErroPeriodo.Visibility = Visibility.Hidden;
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            EsconderErros();
            bool clear = true;
            

            if(NomeAluno.Text.Equals(""))
            {
                ErroNome.Visibility = Visibility.Visible;
                clear = false;
            }

            if(CBCursos.SelectedIndex == -1)
            {
                ErroCurso.Visibility = Visibility.Visible;
                clear = false;
            }

            if(CBPeriodo.SelectedIndex == -1)
            {
                ErroPeriodo.Visibility = Visibility.Visible;
                clear = false;
            }
            if(RAAluno.Text.Equals(""))
            {
                ErroRAvazio.Visibility = Visibility.Visible;
            }
            else
            {
                try
                {
                    long x = long.Parse(RAAluno.Text);
                }
                catch (FormatException)
                {
                    ErroRAinvalido.Visibility = Visibility.Visible;
                    RAAluno.Text = "";
                    clear = false;
                }
            }
            

            if (EmailAluno.Text.Equals(""))
            {
                ErroEmailVazio.Visibility = Visibility.Visible;
                clear = false;
            }
            else if (BancodeDados.BuscarID(EmailAluno.Text) != 0 && BancodeDados.BuscarID(EmailAluno.Text) != aluno.GetID())
            {
                ErroEmailExiste.Visibility = Visibility.Visible;
                clear = false;
            }

            if(bt && SenhaAluno.Password.Equals(""))
            {
                ErroSenha.Visibility = Visibility.Visible;
                clear = false;
            }

            if (clear)
            {
                aluno.SetNome(NomeAluno.Text);
                aluno.SetCurso(CBCursos.SelectedIndex);
                aluno.SetSemestre(CBPeriodo.SelectedIndex +1);
                aluno.SetRa(long.Parse(RAAluno.Text));
                aluno.SetEmail(EmailAluno.Text);
                if(bt) aluno.SetSenha(SenhaAluno.Password);

                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this);
                notificationWindow.Topmost = true;
                notificationWindow.AtualizarMensagemSucesso("Os dados do usuário foram atualizados.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                TExibirPerfilAluno_Coordenador te = new TExibirPerfilAluno_Coordenador(aluno.GetID());
                BancodeDados.MenuCoordenador.CarregarJanela(te);
            }
            
        }
        private void BtnSenha_Click(object sender, RoutedEventArgs e)
        {
            if(bt)
            {
                SenhaAluno.Password = "";
                SenhaAluno.IsEnabled = false;
                BtnSenha.Content = "Nova Senha";
                bt = false;
            }
            else
            {
                SenhaAluno.Password = "";
                SenhaAluno.IsEnabled = true;
                BtnSenha.Content = "Cancelar";
                bt = true;
            }
        }
    }
}
