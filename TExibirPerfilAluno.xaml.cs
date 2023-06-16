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
    /// Interação lógica para TExibirPerfilAluno.xam
    /// </summary>
    public partial class TExibirPerfilAluno : UserControl
    {
        private Aluno aluno;
        private Vaga vaga;
        private bool status;
        public TExibirPerfilAluno(int id_aluno, int id_vaga)
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(id_aluno);
            vaga = BancodeDados.BuscarVaga(id_vaga);
            AttDados();
        }
        public void AttDados()
        {
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
            var converter = new BrushConverter();
            if (vaga.IsAlunoAprovado(aluno.GetID()))
            {
                BtnSelecionar.Content = "Desaprovar para vaga";
                BtnSelecionar.Background = (Brush)converter.ConvertFromString("Red");
                status = true;
            }
            else
            {
                BtnSelecionar.Content = "Aprovar para vaga";
                BtnSelecionar.Background = (Brush)converter.ConvertFromString("#003964");
                status = false;
            }
        }

        public TExibirPerfilAluno()
        {
            InitializeComponent();
        }

        private void BtnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            if (status) vaga.DesaprovarAluno(aluno.GetID());
            else vaga.AprovarAluno(aluno.GetID());
            AttDados();
        }

        private void BtnChat_Click(object sender, RoutedEventArgs e)
        {
            int id = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser()).ChatExiste(aluno.GetID());
            if (id < 0)
            {
                Chat n = new Chat(aluno.GetID());
                id = n.GetID();
            }
            TBatePapo bp = new TBatePapo(id);
            BancodeDados.MenuEmpresa.CarregarJanela(bp);
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            TVagaCompletaEmpresa tv = new TVagaCompletaEmpresa(vaga.GetID());
            BancodeDados.MenuEmpresa.CarregarJanela(tv);
        }
    }
}
