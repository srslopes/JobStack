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
    /// Interação lógica para DesignVagaLista_Coordenador.xam
    /// </summary>
    public partial class DesignVagaLista_Coordenador : UserControl
    {
        private Vaga vaga;
        public DesignVagaLista_Coordenador(int id)
        {
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            AttDados();
        }

        public void AttDados()
        {
            NomeVaga.Text = vaga.GetNome();
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
        }

        private void BtnVerMais_Click(object sender, RoutedEventArgs e)
        {
            VagaCompleta_Coordenador vc = new VagaCompleta_Coordenador(vaga.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(vc);
        }
    }
}
