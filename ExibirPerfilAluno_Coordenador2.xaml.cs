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
    /// Interação lógica para ExibirPerfilAluno_Coordenador2.xam
    /// </summary>
    public partial class ExibirPerfilAluno_Coordenador2 : UserControl
    {
        private Vaga vaga;
        private Aluno aluno;

        public ExibirPerfilAluno_Coordenador2(int idAluno, int idVaga)
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(idAluno);
            vaga = BancodeDados.BuscarVaga(idVaga);
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

        private void BtnVoltar_Copy_Click(object sender, RoutedEventArgs e)
        {
            VagaCompleta_Coordenador vc = new VagaCompleta_Coordenador(vaga.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(vc);
        }

        private void BtnChat_Click(object sender, RoutedEventArgs e)
        {
            TBatePapo bp = new TBatePapo(BancodeDados.BuscarCoordenador(BancodeDados.GetIdUser()).ChatExiste(aluno.GetID()));
            BancodeDados.MenuCoordenador.CarregarJanela(bp);
        }
    }
}
