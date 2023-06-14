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
using System.Windows.Shapes;

namespace JobStack
{
    /// <summary>
    /// Lógica interna para TVagaCompletaEmpresa.xaml
    /// </summary>
    public partial class TVagaCompletaEmpresa : Window
    {
        private Vaga vaga;

        public TVagaCompletaEmpresa(int id)
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
            QtdeVaga.Text = vaga.GetNVagas().ToString();
        }

        private void BtnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
