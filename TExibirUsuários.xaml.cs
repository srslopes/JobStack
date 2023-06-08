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
    /// Interação lógica para TExibirUsuários.xam
    /// </summary>
    public partial class TExibirUsuários : UserControl
    {
        public TExibirUsuários()
        {
            InitializeComponent();
            SPUsers.Children.Clear();
        }

        public void AttLista(int tipo)
        {
            SPUsers.Children.Clear();
            SPUsers.Height = 0;
            int i;
            switch(tipo)
            {
                case 0:
                    i = 1001;
                    while(BancodeDados.BuscarAluno(i)!=null)
                    {
                        DesignExibiçãoUsuario us = new DesignExibiçãoUsuario(i);
                        SPUsers.Children.Add(us);
                        SPUsers.Height += 210;
                        i++;
                    }
                    break;
                case 1:
                    i = 6001;
                    while (BancodeDados.BuscarEmpresa(i) != null)
                    {
                        DesignExibiçãoUsuario us = new DesignExibiçãoUsuario(i);
                        SPUsers.Children.Add(us);
                        SPUsers.Height += 210;
                        i++;
                    }
                    break;
                case 2:
                    i = 101;
                    while (BancodeDados.BuscarCoordenador(i) != null)
                    {
                        DesignExibiçãoUsuario us = new DesignExibiçãoUsuario(i);
                        SPUsers.Children.Add(us);
                        SPUsers.Height += 210;
                        i++;
                    }
                    break;
            }
            SVUsuarios.ScrollToTop();
        }

        private void BtnAlunos_Click(object sender, RoutedEventArgs e)
        {
            AttLista(0);            
        }

        private void BtnEmpresas_Click(object sender, RoutedEventArgs e)
        {
            AttLista(1);
        }

        private void BtnCoordenadores_Click(object sender, RoutedEventArgs e)
        {
            AttLista(2);
        }
    }
}
