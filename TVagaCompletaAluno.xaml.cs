﻿using System;
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
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Lógica interna para TVagaCompletaAluno.xaml
    /// </summary>
    public partial class TVagaCompletaAluno : UserControl
    {
        private Vaga vaga;
        private Aluno aluno;
        private bool st;
        private DesignVaga parent;
        private DesignVagaInscrita parent2;

        public TVagaCompletaAluno(int id, DesignVaga dv)
        {
            InitializeComponent();
            Init(id);
            parent = dv;
            parent2 = null;
            
        }
        public TVagaCompletaAluno(int id, DesignVagaInscrita dv)
        {
            InitializeComponent();
            Init(id);
            parent = null;
            parent2 = dv;

        }

        private void Init(int id)
        {
            vaga = BancodeDados.BuscarVaga(id);
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            TituloVaga.Text = vaga.GetNome();
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa()).GetNome();
            DescricaoVaga.Text = vaga.GetDescricao();
            TipoVaga.Text = vaga.GetTipo();
            Turno.Text = vaga.GetTurno();
            FaixaSalarial.Text = vaga.GetSalario();
            switch (aluno.GetCurso())
            {
                case 0:
                    Curso.Text = "Análise e Desenvolvimento de Sistemas";
                    break;
                case 1:
                    Curso.Text = "Gestão Empresarial";
                    break;
                case 2:
                    Curso.Text = "Eventos";
                    break;
                case 3:
                    Curso.Text = "Gestão de Produção Industrial";
                    break;
            }
            Jornada.Text = vaga.GetJornada();
            QtdeVaga.Text = vaga.GetNVagas().ToString();
            if (vaga.GetStatus() == 3) BtnInscreverse.Visibility = Visibility.Hidden;

            if (BancodeDados.BuscarAluno(BancodeDados.GetIdUser()).VagaInscrita(vaga.GetID()))
            {
                BtDes();
                st = false;
            }
            else
            {
                BtInsc();
                st = true;
            }
        }

        public void BtInsc()
        {
            BtnInscreverse.Content = "Inscrever-se";
            var converter = new BrushConverter();
            BtnInscreverse.Background = (Brush)converter.ConvertFromString("#FF27597E");
            
        }
        public void BtDes()
        {
            BtnInscreverse.Content = "Desinscrever";
            var converter = new BrushConverter();
            BtnInscreverse.Background = (Brush)converter.ConvertFromString("Red");
        }
        public void AttVagas()
        {
            if (parent == null) parent2.AttVagas();
            else parent.AttVagas();
        }

        private void BtnInscreverse_Click(object sender, RoutedEventArgs e)
        {
            if(st)
            {
                aluno.AdicionarVaga(vaga.GetID());
                vaga.Inscrever(aluno.GetID());
                BtDes();
                st = false;
                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Owner = TMenuAluno.GetWindow(this);
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemSucesso("Você se inscreveu nessa vaga.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();

            }
            else
            {
                vaga.Desinscrever(aluno.GetID());
                aluno.RemoverVaga(vaga.GetID());
                BtInsc();
                st = true;
                NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
                notificationWindow.Owner = TMenuAluno.GetWindow(this);
                notificationWindow.Topmost = true;
                //aqui atualiza o texto da notificação
                notificationWindow.AtualizarMensagemSucesso("Você não está mais inscrito nessa vaga.");
                notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                notificationWindow.ShowDialog();
            }
            AttVagas();
        }

        private void BtnMsg_Click(object sender, RoutedEventArgs e)
        {
            int id;
            id = aluno.ChatExiste(vaga.GetIdEmpresa());
            if (id < 0)
            {
                Chat ch = new Chat(vaga.GetIdEmpresa());
                id = ch.GetID();
            }
            BancodeDados.MenuAluno.AbrirChat(id);
        }

        private void BtnFechar_Click(object sender, RoutedEventArgs e)
        {
            if (parent != null) BancodeDados.MenuAluno.AbrirVagasDisponiveis();
            else BancodeDados.MenuAluno.AbrirVagasInscritas();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
