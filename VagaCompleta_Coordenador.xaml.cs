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
    /// Interação lógica para VagaCompleta_Coordenador.xam
    /// </summary>
    public partial class VagaCompleta_Coordenador : UserControl
    {
        private Vaga vaga;
        public VagaCompleta_Coordenador(int id)
        {
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            AttDados();
            AttLista();
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

        public void AttLista()
        {
            SPInscritos.Children.Clear();
            SPInscritos.Height = 0;
            for(int i=0; i<vaga.GetLista().Count; i++)
            {
                if(vaga.IsAlunoAprovado(vaga.GetLista()[i]))
                {
                    DesignListaAluno_Coordenador dl = new DesignListaAluno_Coordenador(vaga.GetLista()[i], vaga.GetID());
                    SPInscritos.Children.Add(dl);
                    SPInscritos.Height += 110;
                }
            }
            for (int i = 0; i < vaga.GetLista().Count; i++)
            {
                if (!vaga.IsAlunoAprovado(vaga.GetLista()[i]))
                {
                    DesignListaAluno_Coordenador dl = new DesignListaAluno_Coordenador(vaga.GetLista()[i], vaga.GetID());
                    SPInscritos.Children.Add(dl);
                    SPInscritos.Height += 110;
                }
            }
            if(vaga.GetLista().Count==0)
            {
                SemAlunos sa = new SemAlunos();
                SPInscritos.Children.Add(sa);
                SPInscritos.Height = 40;
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilEmpresa_Coordenador te = new TExibirPerfilEmpresa_Coordenador(vaga.GetIdEmpresa());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }
    }
}
