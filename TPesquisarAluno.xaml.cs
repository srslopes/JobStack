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
    /// Interação lógica para TPesquisarAluno.xam
    /// </summary>
    public partial class TPesquisarAluno : UserControl
    {
        private Aluno aluno; 

        public TPesquisarAluno()
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            AttVagas();

        }

        private void CaixaPesquisa_GotFocus(object sender, RoutedEventArgs e)
        {
            //oculta o texto da textbox quando o usuário clica pela primeira vez
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Pesquisar")
            {
                textBox.Text = " ";
                textBox.Foreground = Brushes.Black;
            }
        }

        public void AttVagas()
        {
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            List<Vaga> Vagas = BancodeDados.GetListaVagas();
            for(int i= Vagas.Count-1; i>=0; i--)
            {
                if (!aluno.VagaInscrita(i) && Vagas[i].GetStatus() == 2 && Vagas[i].GetCurso()==aluno.GetCurso())
                {
                    DesignVaga v = new DesignVaga(i, this);
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
            }
            if (SPVagas.Children.Count == 0)
            {
                SPVagas.Height= 35;
                SemVagas sv = new SemVagas();
                SPVagas.Children.Add(sv);
            }
        }
    }
}
