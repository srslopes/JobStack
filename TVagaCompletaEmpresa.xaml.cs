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
    /// Interação lógica para TVagaCompletaEmpresa.xam
    /// </summary>
    public partial class TVagaCompletaEmpresa : UserControl
    {
        private Vaga vaga;
        private int status;
        public TVagaCompletaEmpresa(int id)
        {
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            status = vaga.GetStatus(); 
            if(status==3)
            {
                BtnEditar.Visibility = Visibility.Hidden;
                BtnFinalizar.Visibility = Visibility.Hidden;
            }
            AttDados();
            AttLista();
        }
        public void AttDados()
        {
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser()).GetNome();
            TituloVaga.Text = vaga.GetNome();
            TipoVaga.Text = vaga.GetTipo();            
            Turno.Text = vaga.GetTurno();
            Jornada.Text = vaga.GetJornada();
            FaixaSalarial.Text = vaga.GetSalario();
            DescricaoVaga.Text = vaga.GetDescricao();
            QtdeVaga.Text = vaga.GetNVagas().ToString();
            switch(vaga.GetCurso())
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
        }
        public void AttLista()
        {
            SPInscritos.Children.Clear();
            SPInscritos.Height = 0;
            bool vazia = true;
            List<int> lista = vaga.GetLista();
            for(int i = 0; i<lista.Count; i++)
            {
                if(vaga.IsAlunoAprovado(lista[i]))
                {
                    DesignUsuarioInscrito d = new DesignUsuarioInscrito(lista[i], vaga.GetID());
                    SPInscritos.Children.Add(d);
                    SPInscritos.Height += 110;
                    vazia = false;
                }
                
            }
            for (int i = 0; i < lista.Count; i++)
            {
                if (!vaga.IsAlunoAprovado(lista[i]))
                {
                    DesignUsuarioInscrito d = new DesignUsuarioInscrito(lista[i], vaga.GetID());
                    SPInscritos.Children.Add(d);
                    SPInscritos.Height += 110;
                    vazia = false;
                }
            }
            if(vazia)
            {
                SemAlunos s = new SemAlunos();
                SPInscritos.Children.Add(s);
                SPInscritos.Height = 40;
            }
        }
        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            TEditarVaga cad = new TEditarVaga(vaga.GetID(), this);
            BancodeDados.MenuEmpresa.CarregarJanela(cad);


        }

        private void BtnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            vaga.Encerrar();
            for (int i = 0; i < vaga.GetAprovados().Count; i++)
            {
                BancodeDados.BuscarAluno(vaga.GetAprovados()[i]).Aprovar();
            }
            BancodeDados.MenuEmpresa.CarregarSubJanela(2);
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            switch(status)
            {
                case 0:
                    BancodeDados.MenuEmpresa.CarregarSubJanela(0);
                    break;
                case 1:
                    BancodeDados.MenuEmpresa.CarregarSubJanela(0);
                    break;
                case 2:
                    BancodeDados.MenuEmpresa.CarregarSubJanela(1);
                    break;
                case 3:
                    BancodeDados.MenuEmpresa.CarregarSubJanela(2);
                    break;

            }
        }
    }
}
