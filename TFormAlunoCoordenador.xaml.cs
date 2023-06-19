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
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.MenuCoordenador.CarregarJanela(parent);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            bool clear = true;

            if (NomeAluno.Text.Equals(""))
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("O usuário precisa ter um nome.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }

            if (CBCursos.SelectedIndex == -1)
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("O usuário deve participar de um curso.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }

            if (CBPeriodo.SelectedIndex == -1)
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuEmpresa.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("Selecione o período cursado.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }

            try
            {
                long x = long.Parse(RAAluno.Text);
            }
            catch (FormatException)
            {
                NotificacaoErro notificationWindow = new NotificacaoErro();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemErro("O RA inserido é inválido.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                RAAluno.Text = "";
                clear = false;
            }

            if (EmailAluno.Text.Equals(""))
            {

                clear = false;
            }
            else if (BancodeDados.BuscarID(EmailAluno.Text) != 0)
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("Esse e-mail já existe.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
                clear = false;
            }

            if(SenhaAluno.Password.Equals(""))
            {
                NotificacaoAtencao notificationWindow = new NotificacaoAtencao();
                notificationWindow.Owner = TMenuCoordenador.GetWindow(this); //sempre precisa determinar a janela que a notificação vai se sobrepor
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemAtencao("Crie uma senha inicial para o usuário.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
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
