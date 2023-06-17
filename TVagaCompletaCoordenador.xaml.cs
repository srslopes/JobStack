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
    /// Interação lógica para TVagaCompletaCoordenador.xam
    /// </summary>
    public partial class TVagaCompletaCoordenador : UserControl
    {
        private Vaga vaga;
        public TVagaCompletaCoordenador(int id)
        {
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            AttDados();
        }
        public void AttDados()
        {
            TituloVaga.Text = vaga.GetNome();
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa()).GetNome();
            DescricaoVaga.Text = vaga.GetDescricao();
            TipoVaga.Text = vaga.GetTipo();
            Turno.Text = vaga.GetTurno();
            switch (vaga.GetCurso())
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
            Turno_Copy.Text = vaga.GetTurno();
            QtdeVaga.Text = vaga.GetNVagas().ToString();
            FaixaSalarial.Text = vaga.GetSalario();

        }

        private void BtnAceitar_Click(object sender, RoutedEventArgs e)
        {
            vaga.Aprovar();
            TSolicitacoesVagasCoordenador analisar = new TSolicitacoesVagasCoordenador();
            BancodeDados.MenuCoordenador.CarregarJanela(analisar);
        }

        private void BtnRejeitar_Click(object sender, RoutedEventArgs e)
        {
            vaga.Rejeitar();
            TSolicitacoesVagasCoordenador analisar = new TSolicitacoesVagasCoordenador();
            BancodeDados.MenuCoordenador.CarregarJanela(analisar);
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            TSolicitacoesVagasCoordenador analisar = new TSolicitacoesVagasCoordenador();
            BancodeDados.MenuCoordenador.CarregarJanela(analisar);
        }
    }
}
