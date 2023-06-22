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
    /// Interação lógica para TEditarVaga.xam
    /// </summary>
    public partial class TEditarVaga : UserControl
    {

        private Vaga vaga;
        private int status;
        private TVagaCompletaEmpresa parent;

        public TEditarVaga(int id, TVagaCompletaEmpresa janela)
        {            
            InitializeComponent();
            parent = janela;
            vaga = BancodeDados.BuscarVaga(id);
            status = vaga.GetStatus();
            BtnNumero.Content = 0;
            AttDados();
            EsconderErros();
        }

        public void AttDados()
        {
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser()).GetNome();
            TituloVaga.Text = vaga.GetNome();
            Tipo.Text = vaga.GetTipo();
            Turno.Text = vaga.GetTurno();
            Jornada.Text = vaga.GetJornada();
            SalarioVaga.Text = vaga.GetSalario();
            DescricaoVaga.Text = vaga.GetDescricao();
            BtnNumero.Content = vaga.GetNVagas();
            CBCursos.SelectedIndex = vaga.GetCurso();
        }

        private void BtnMais_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(BtnNumero.Content);
            if (i < 99)
            {
                BtnNumero.Content = i + 1;
            }
        }

        private void BtnMenos_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(BtnNumero.Content);
            if (i > 0)
            {
                BtnNumero.Content = i - 1;
            }
        }
        public void EsconderErros()
        {
            ErroTitulo.Visibility = Visibility.Hidden;
            ErroTurno.Visibility = Visibility.Hidden;
            ErroTipo.Visibility = Visibility.Hidden;
            ErroJornada.Visibility = Visibility.Hidden;
            ErroCurso.Visibility = Visibility.Hidden;
            ErroSalario.Visibility = Visibility.Hidden;
            ErroDescricao.Visibility = Visibility.Hidden;
            ErroQtd.Visibility = Visibility.Hidden;
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            EsconderErros();
            bool clear = true;
            if (TituloVaga.Text.Equals(""))//usuario deve inserir um titulo para a vaga
            {
                ErroTitulo.Visibility = Visibility.Visible;

                clear = false;
            }
            if (Tipo.Text.Equals(""))//usuario deve inserir um tipo para a vaga
            {
                ErroTipo.Visibility = Visibility.Visible;

                clear = false;
            }
            if (Turno.Text.Equals(""))//usuario deve inserir um turno para a vaga
            {
                ErroTurno.Visibility = Visibility.Visible;

                clear = false;
            }
            if (Jornada.Text.Equals(""))//usuario deve inserir uma jornada para a vaga
            {

                ErroJornada.Visibility = Visibility.Visible;

                clear = false;
            }
            if (SalarioVaga.Text.Equals(""))//usuario deve inserir um salario para a vaga
            {
                ErroSalario.Visibility = Visibility.Visible;

                clear = false;
            }
            if (DescricaoVaga.Text.Equals(""))//usuario deve inserir uma descrição para a vaga
            {
                ErroDescricao.Visibility = Visibility.Visible;

                clear = false;
            }
            if (CBCursos.SelectedIndex == -1)//usuario deve selecionar um curso para a vaga
            {
                ErroCurso.Visibility = Visibility.Visible;

                clear = false;
            }
            if (int.Parse(BtnNumero.Content.ToString()) <= 0)//numero de vaga disponiveis não pode ser 0
            {
                ErroQtd.Visibility = Visibility.Visible;

                clear = false;
            }
            if (clear)
            {
                vaga.SetNome(TituloVaga.Text);
                vaga.SetTurno(Turno.Text);
                vaga.SetTipo(Tipo.Text);
                vaga.SetJornada(Jornada.Text);
                vaga.SetCurso(CBCursos.SelectedIndex);
                vaga.SetSalario(SalarioVaga.Text);
                vaga.SetDescricao(DescricaoVaga.Text);
                vaga.SetNVagas(int.Parse(BtnNumero.Content.ToString()));
                TituloVaga.Text = "";
                Tipo.Text = "";
                Jornada.Text = "";
                SalarioVaga.Text = "";
                DescricaoVaga.Text = "";
                BtnNumero.Content = 0;
                vaga.Reavaliar();
                parent.AttDados();
                BancodeDados.MenuEmpresa.CarregarJanela(parent);

                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Owner = TMenuEmpresa.GetWindow(this);
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemSucesso("Sua vaga foi atualizada.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();

            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.MenuEmpresa.CarregarJanela(parent);            
        }
    }
}


