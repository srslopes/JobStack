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
    /// Interação lógica para TAlunosCoordenador.xam
    /// </summary>
    public partial class TAlunosCoordenador : UserControl
    {
        
        public TAlunosCoordenador()
        {
            InitializeComponent();
        }

        private void BtnNovoAluno_Click(object sender, RoutedEventArgs e)
        {
            TFormAlunoCoordenador t = new TFormAlunoCoordenador(this);
            BancodeDados.MenuCoordenador.CarregarJanela(t);
        }
    }
}