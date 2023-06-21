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
    /// Interação lógica para TVagasEmpresa.xam
    /// </summary>
    public partial class TVagasEmpresa : UserControl
    {
        private TVagasPendentesEmpresa pendentes;
        private TVagasEmAberto aberto;
        private TVagasFinalizadasEmpresa finalizadas;
        private Empresa empresa;
        public TVagasEmpresa()
        {
            InitializeComponent();
            pendentes = null;
            aberto = new TVagasEmAberto();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(aberto);
            finalizadas = null;
            empresa = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser());
            NtVagas();
        }

        private void BtnCriar_Click(object sender, RoutedEventArgs e)
        {
            TCadastrarVagaEmpresa cadv = new TCadastrarVagaEmpresa();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(cadv);
            
        }

        private void BtnPendentes_Click(object sender, RoutedEventArgs e)
        {
            empresa.ResetNtRejeicoes();
            BancodeDados.MenuEmpresa.NtVagas();
            NtVagas();
            pendentes = new TVagasPendentesEmpresa();            
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(pendentes);
        }

        private void BtnEmAberto_Click(object sender, RoutedEventArgs e)
        {
            empresa.ResetNtAprovacoes();
            BancodeDados.MenuEmpresa.NtVagas();
            NtVagas();
            aberto = new TVagasEmAberto();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(aberto);
        }

        private void BtnFinalizadas_Click(object sender, RoutedEventArgs e)
        {
            finalizadas = new TVagasFinalizadasEmpresa();
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(finalizadas);
        }
        public void CarregarJanela(UserControl Janela)
        {
            GridConteudo.Children.Clear();
            GridConteudo.Children.Add(Janela);
        }
        public void CarregarJanela(int i)
        {
            AttListas();
            switch(i)
            {
                case 0:
                    pendentes = new TVagasPendentesEmpresa();
                    GridConteudo.Children.Clear();
                    GridConteudo.Children.Add(pendentes);
                    break;
                case 1:
                    aberto = new TVagasEmAberto();
                    GridConteudo.Children.Clear();
                    GridConteudo.Children.Add(aberto);
                    break;
                case 2:
                    finalizadas = new TVagasFinalizadasEmpresa();
                    GridConteudo.Children.Clear();
                    GridConteudo.Children.Add(finalizadas);
                    break;

            }
        }
        public void AttListas()
        {
            if (pendentes != null) pendentes.AttLista();
            else Console.WriteLine("Etapa 2 Falhou");
            if (aberto != null) aberto.AttLista();
            else Console.WriteLine("Etapa 2 Falhou");
            if (finalizadas != null) finalizadas.AttLista();
            else Console.WriteLine("Etapa 2 Falhou");
        }
        public void NtVagas()
        {
            NotifA.Text = empresa.GetNtAprovacoes().ToString();
            NotifP.Text = empresa.GetNtRejeicoes().ToString();
            if (empresa.GetNtAprovacoes() == 0) NotificacaoA.Visibility = Visibility.Hidden;
            else NotificacaoA.Visibility = Visibility.Visible;
            if (empresa.GetNtRejeicoes() == 0) NotificacaoP.Visibility = Visibility.Hidden;
            else NotificacaoP.Visibility = Visibility.Visible;
        }
    }
}
