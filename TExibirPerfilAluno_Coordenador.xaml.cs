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
    /// Interação lógica para TExibirPerfilAluno_Coordenador.xam
    /// </summary>
    public partial class TExibirPerfilAluno_Coordenador : UserControl
    {
        private Aluno aluno;
        public TExibirPerfilAluno_Coordenador(int id)
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(id);
            AttDados();
        }
        public void AttDados()
        {
            NomeAluno.Text = aluno.GetNome();
            Img.ImageSource = BancodeDados.BuscarImg(aluno.GetIdImg());
            NomeAluno.Text = aluno.GetNome();
            switch (aluno.GetCurso())
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
            Periodo.Text = aluno.GetSemestre() + "º Semestre";
            FormAluno.Text = aluno.GetFormacao();
            ExpAluno.Text = aluno.GetExperiencia();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            TEditarPerfilAluno_Coordenador te = new TEditarPerfilAluno_Coordenador(aluno.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }

        private void BtnChat_Click(object sender, RoutedEventArgs e)
        {
            TBatePapo bp = new TBatePapo(BancodeDados.BuscarCoordenador(BancodeDados.GetIdUser()).ChatExiste(aluno.GetID()));
            BancodeDados.MenuCoordenador.CarregarJanela(bp);
        }

        private void BtnVoltar_Copy_Click(object sender, RoutedEventArgs e)
        {
            TAlunosCoordenador t = new TAlunosCoordenador();
            BancodeDados.MenuCoordenador.CarregarJanela(t);
        }
    }
}
