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
    /// Interação lógica para DesignVaga.xam
    /// </summary>
    public partial class DesignVaga : UserControl
    {
        private Vaga vaga;
        private Aluno aluno;
        private TPesquisarAluno parent;

        public DesignVaga(int id, TPesquisarAluno janela)
        {
            parent = janela;
            InitializeComponent();
            vaga = BancodeDados.BuscarVaga(id);
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa()).GetEmail();
            TipoVaga.Text = vaga.GetTipo();
            DescricaoVaga.Text = vaga.getDescricao();      
        }

        private void BtnInscreverse_Click(object sender, RoutedEventArgs e)
        {
            aluno.AdicionarVaga(vaga.GetID());
            vaga.Inscrever(aluno.GetID());
            parent.AttVagas();
        }
    }
}
