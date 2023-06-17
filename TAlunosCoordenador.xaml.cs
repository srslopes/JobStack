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
    /// Interação lógica para TAlunosCoordenador.xam
    /// </summary>
    public partial class TAlunosCoordenador : UserControl
    {
        
        public TAlunosCoordenador()
        {
            InitializeComponent();
            AttLista();
        }

        public void AttLista()
        {
            SPAlunos.Children.Clear();
            SPAlunos.Height = 0;
            int i;
            i = 1001;
            while (BancodeDados.BuscarAluno(i) != null)
            {
                DesignUsuarioAluno_Coordenador us = new DesignUsuarioAluno_Coordenador(i);
                SPAlunos.Children.Insert(0,us);
                SPAlunos.Height += 110;
                i++;
            }
        }

        private void BtnNovoAluno_Click(object sender, RoutedEventArgs e)
        {
            TFormAlunoCoordenador t = new TFormAlunoCoordenador(this);
            BancodeDados.MenuCoordenador.CarregarJanela(t);
        }
    }
}
