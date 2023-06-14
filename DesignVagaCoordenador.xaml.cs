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
    /// Interação lógica para DesignVagaCoordenador.xam
    /// </summary>
    public partial class DesignVagaCoordenador : UserControl
    {
        private Vaga vaga;
        public DesignVagaCoordenador(int id)
        {
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            AttDados();
        }
        private void AttDados()
        {
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa()).GetNome();
            NomeVaga.Text = vaga.GetNome();
            TipoVaga.Text = vaga.GetTipo();
            DescricaoVaga.Text = vaga.GetDescricao();
            var converter = new BrushConverter();
            switch (vaga.GetStatus())
            {
                case 0:
                    StatusVaga.Text = "Aguardando";
                    StatusVaga.Foreground = (Brush)converter.ConvertFromString("Yellow");
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

        }
        private void BtnVerMais_Click(object sender, RoutedEventArgs e)
        {
            /*
                TVagaCompletaEmpresa vg = new TVagaCompletaEmpresa(vaga.GetID());            
                vg.Show();
            */
        }

        private void BtnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            vaga.Encerrar();
            AttDados();
            BancodeDados.MenuCoordenador.AttListas();

        }
    }
}
