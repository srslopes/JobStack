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
    /// Interação lógica para DesignUsuarioAluno_Coordenador.xam
    /// </summary>
    public partial class DesignUsuarioAluno_Coordenador : UserControl
    {
        private Aluno aluno;
        public DesignUsuarioAluno_Coordenador(int id)
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(id);
            Img.ImageSource = BancodeDados.BuscarImg(aluno.GetIdImg());
            NomeAluno.Text = aluno.GetNome();
        }

        private void BtnVerPerfil_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilAluno_Coordenador te = new TExibirPerfilAluno_Coordenador(aluno.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }
    }
}
