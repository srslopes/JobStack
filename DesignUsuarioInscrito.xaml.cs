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
    /// Interação lógica para DesignUsuarioInscrito.xam
    /// </summary>
    public partial class DesignUsuarioInscrito : UserControl
    {
        private Aluno aluno;
        private Vaga vaga;

        public DesignUsuarioInscrito(int id_aluno, int id_vaga)
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(id_aluno);
            vaga = BancodeDados.BuscarVaga(id_vaga);
            Img.ImageSource = BancodeDados.BuscarImg(aluno.GetIdImg());
            NomeUsuario.Text = aluno.GetNome();
            if (vaga.IsAlunoAprovado(aluno.GetID())) Status.Visibility = Visibility.Visible;
            else Status.Visibility = Visibility.Hidden;
        }

        private void BtnVerPerfil_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilAluno pa = new TExibirPerfilAluno(aluno.GetID(), vaga.GetID());
            BancodeDados.MenuEmpresa.CarregarJanela(pa);
        }
    }
}
