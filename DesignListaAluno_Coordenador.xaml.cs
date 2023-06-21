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
    /// Interação lógica para DesignListaAluno_Coordenador.xam
    /// </summary>
    public partial class DesignListaAluno_Coordenador : UserControl
    {
        private Vaga vaga;
        private Aluno aluno;

        public DesignListaAluno_Coordenador(int idAluno, int idVaga)
        {
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(idVaga);
            aluno = BancodeDados.BuscarAluno(idAluno);
            AttDados();
        }

        public void AttDados()
        {
            Img.ImageSource = BancodeDados.BuscarImg(aluno.GetIdImg());
            NomeAluno.Text = aluno.GetNome();
            if (!vaga.IsAlunoAprovado(aluno.GetID())) Aprovacao.Visibility = Visibility.Hidden;
        }

        private void BtnVerPerfil_Click(object sender, RoutedEventArgs e)
        {
            ExibirPerfilAluno_Coordenador2 ep = new ExibirPerfilAluno_Coordenador2(aluno.GetID(), vaga.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(ep);
        }
    }
}
