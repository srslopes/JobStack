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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Interação lógica para DesignVaga.xam
    /// </summary>
    public partial class DesignVaga : UserControl
    {
        private Vaga vaga;
        private Aluno aluno;
        private TPesquisarAluno parent;

        public DesignVaga(int id, TPesquisarAluno janela)
        {
            parent = janela;
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa()).GetNome();

            NomeVaga.Text = vaga.GetNome();
            TipoVaga.Text = vaga.GetTipo();
            DescricaoVaga.Text = vaga.GetDescricao();
            var converter = new BrushConverter();
            switch (vaga.GetStatus())
            {
                case 0:
                    StatusVaga.Text = "Aguardando";
                    StatusVaga.Foreground = (Brush)converter.ConvertFromString("Orange");
                    break;
                case 1:
                    StatusVaga.Text = "Rejeitada";
                    StatusVaga.Foreground = (Brush)converter.ConvertFromString("Red");
                    break;
                case 2:
                    StatusVaga.Text = "Aberta";
                    StatusVaga.Foreground = (Brush)converter.ConvertFromString("Green");
                    break;
                case 3:
                    StatusVaga.Text = "Encerrada";
                    StatusVaga.Foreground = (Brush)converter.ConvertFromString("Red");
                    break;
            }

            Img.ImageSource = BancodeDados.BuscarImg((BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa())).GetIdImg());
        }

        private void BtnInscreverse_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Vaga Inscrita com sucesso!");
            aluno.AdicionarVaga(vaga.GetID());
            vaga.Inscrever(aluno.GetID());
            AttVagas();

            //chamando a notificação de inscrição bem sucedida
            NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
            notificationWindow.Owner = TMenuAluno.GetWindow(this);
            notificationWindow.Topmost = true;
            //aqui atualiza o texto da notificação
            notificationWindow.AtualizarMensagemSucesso("Você se inscreveu nessa vaga.");
            notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            notificationWindow.ShowDialog();
        }

        public void AttVagas()
        {
            parent.AttVagas();
        }

        private void BtnVerMais_Click(object sender, RoutedEventArgs e)
        {
            TVagaCompletaAluno vg = new TVagaCompletaAluno(vaga.GetID(), this);
            BancodeDados.MenuAluno.CarregarJanela(vg);
        }
    }
}
