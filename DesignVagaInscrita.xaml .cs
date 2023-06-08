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
    public partial class DesignVagaInscrita : UserControl
    {
        private Vaga vaga;
        private Aluno aluno;
        private TMinhasInscricoesAluno parent;

        public DesignVagaInscrita(int id, TMinhasInscricoesAluno janela)
        {
            parent = janela;
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa()).GetNome();
            NomeVaga.Text = vaga.GetNome();
            TipoVaga.Text = vaga.GetTipo();
            DescricaoVaga.Text = vaga.GetDescricao();
            Img.ImageSource = BancodeDados.BuscarImg((BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa())).GetIdImg());
        }
       

        private void BtnVerMais_Click(object sender, RoutedEventArgs e)
        {
            TVagaCompletaAluno vg = new TVagaCompletaAluno(vaga.GetID(), this);
            vg.Topmost = true;
            vg.Show();

        }
        private void BtnDesinscrever_Click(object sender, RoutedEventArgs e)
        {
            vaga.Desinscrever(aluno.GetID());
            aluno.RemoverVaga(vaga.GetID());
            AttVagas();
        }
        public void AttVagas()
        {
            parent.AttVagas();
        }
    }
}
