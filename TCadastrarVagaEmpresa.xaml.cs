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
    /// Interação lógica para TCadastrarVagaEmpresa.xam
    /// </summary>
    public partial class TCadastrarVagaEmpresa : UserControl
    {
        public TCadastrarVagaEmpresa()
        {
            InitializeComponent();
        }

        private void BtnMais_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(BtnNumero.Content);
            if(i < 99)
            {
                BtnNumero.Content = i + 1;
            }
        }

        private void BtnMenos_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(BtnNumero.Content);
            if(i > 0)
            {
                BtnNumero.Content = i - 1;
            }
        }
    }
}