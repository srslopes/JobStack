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
    /// Interação lógica para TMinhasInscricoesAluno.xam
    /// </summary>
    public partial class TMinhasInscricoesAluno : UserControl
    {
        private Aluno aluno;
        public TMinhasInscricoesAluno()
        {
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            InitializeComponent();
            attFull();
            NtVagas();
            BancodeDados.MenuAluno.NtVagas();
        }

        public void AttVagas()
        {
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            List<Vaga> Vagas = BancodeDados.GetListaVagas();
            for (int i = Vagas.Count-1; i >=0 ; i--)
            {
                if (aluno.VagaInscrita(i) && Vagas[i].GetStatus() == 2)
                {
                    DesignVagaInscrita v = new DesignVagaInscrita(i, this);
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210; 
                }
            }
            if (SPVagas.Children.Count == 0)
            {
                SPVagas.Height = 35;
                SemVagas sv = new SemVagas();
                SPVagas.Children.Add(sv);
            }
        }
        public void NtVagas()
        {
            int n = 0;
            n = aluno.GetAprov();
            Notif.Text = n.ToString();
            if (n == 0) Notificacao.Visibility = Visibility.Hidden;
            else Notificacao.Visibility = Visibility.Visible;
        }
        private void attFull()
        {
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            List<Vaga> Vagas = BancodeDados.GetListaVagas();
            for (int i = Vagas.Count - 1; i >= 0; i--)
            {
                if (aluno.VagaInscrita(i) && Vagas[i].GetStatus() == 2)
                {
                    DesignVagaInscrita v = new DesignVagaInscrita(i, this);
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
            }
            for (int i = Vagas.Count - 1; i >= 0; i--)
            {
                if (aluno.VagaInscrita(i) && Vagas[i].GetStatus() == 3 && Vagas[i].IsAlunoAprovado(BancodeDados.GetIdUser()))
                {
                    DesignVagaInscrita v = new DesignVagaInscrita(i, this);
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
            }
            for (int i = Vagas.Count - 1; i >= 0; i--)
            {
                if (aluno.VagaInscrita(i) && Vagas[i].GetStatus() == 3 && !Vagas[i].IsAlunoAprovado(BancodeDados.GetIdUser()))
                {
                    DesignVagaInscrita v = new DesignVagaInscrita(i, this);
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
            }
            if (SPVagas.Children.Count == 0)
            {
                SPVagas.Height = 35;
                SemVagas sv = new SemVagas();
                SPVagas.Children.Add(sv);
            }
        }

        private void BtnEmAberto_Click(object sender, RoutedEventArgs e)
        {            
            AttVagas();
        }

        private void BtnFinalizadas_Click(object sender, RoutedEventArgs e)
        {
            aluno.ResetAprov();
            NtVagas();
            BancodeDados.MenuAluno.NtVagas();
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            List<Vaga> Vagas = BancodeDados.GetListaVagas();
            for (int i = Vagas.Count - 1; i >= 0; i--)
            {
                if (aluno.VagaInscrita(i) && Vagas[i].GetStatus() == 3 && Vagas[i].IsAlunoAprovado(BancodeDados.GetIdUser()))
                {
                    DesignVagaInscrita v = new DesignVagaInscrita(i, this);
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
            }
            for (int i = Vagas.Count - 1; i >= 0; i--)
            {
                if (aluno.VagaInscrita(i) && Vagas[i].GetStatus() == 3 && !Vagas[i].IsAlunoAprovado(BancodeDados.GetIdUser()))
                {
                    DesignVagaInscrita v = new DesignVagaInscrita(i, this);
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
            }
            if (SPVagas.Children.Count == 0)
            {
                SPVagas.Height = 35;
                SemVagas sv = new SemVagas();
                SPVagas.Children.Add(sv);
            }
        }
    }
}
