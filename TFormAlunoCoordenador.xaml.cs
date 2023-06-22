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
    /// Interação lógica para TFormAlunoCoordenador.xam
    /// </summary>
    public partial class TFormAlunoCoordenador : UserControl
    {
        private TAlunosCoordenador parent;

        public TFormAlunoCoordenador(TAlunosCoordenador janela)
        {
            parent = janela;
            InitializeComponent();
            EsconderErros();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.MenuCoordenador.CarregarJanela(parent);
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


            if (NomeAluno.Text.Equals(""))
            {
                ErroNome.Visibility = Visibility.Visible;
                clear = false;
            }

            if (CBCursos.SelectedIndex == -1)
            {
                ErroCurso.Visibility = Visibility.Visible;
                clear = false;
            }

            if (CBPeriodo.SelectedIndex == -1)
            {
                ErroPeriodo.Visibility = Visibility.Visible;
                clear = false;
            }
            if (RAAluno.Text.Equals(""))
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
            else if (BancodeDados.BuscarID(EmailAluno.Text) != 0)
            {
                ErroEmailExiste.Visibility = Visibility.Visible;
                clear = false;
            }

            if (SenhaAluno.Password.Equals(""))
            {
                ErroSenha.Visibility = Visibility.Visible;
                clear = false;
            }

            if (clear)
            {
                Aluno aluno = new Aluno();
                aluno.SetNome(NomeAluno.Text);
                aluno.SetCurso(CBCursos.SelectedIndex);
                aluno.SetSemestre(CBPeriodo.SelectedIndex + 1);
                aluno.SetRa(long.Parse(RAAluno.Text));
                aluno.SetEmail(EmailAluno.Text);
                aluno.SetSenha(SenhaAluno.Password);
                aluno.salvar();
                parent.AttLista();
                BancodeDados.MenuCoordenador.CarregarJanela(parent);

                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this);
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemSucesso("O aluno foi cadastrado.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
            }
        }
    }
}
