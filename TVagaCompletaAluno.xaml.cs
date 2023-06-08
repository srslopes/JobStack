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
    /// Lógica interna para TVagaCompletaAluno.xaml
    /// </summary>
    public partial class TVagaCompletaAluno : Window
    {
        private Vaga vaga;
        private Aluno aluno;
        private bool st;
        private DesignVaga parent;
        private DesignVagaInscrita parent2;

        public TVagaCompletaAluno(int id, DesignVaga dv)
        {
            InitializeComponent();
            Init(id);
            parent = dv;
            parent2 = null;
            
        }
        public TVagaCompletaAluno(int id, DesignVagaInscrita dv)
        {
            InitializeComponent();
            Init(id);
            parent = null;
            parent2 = dv;

        }

        private void Init(int id)
        {
            vaga = BancodeDados.BuscarVaga(id);
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            TituloVaga.Text = vaga.GetNome();
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(vaga.GetIdEmpresa()).GetNome();
            DescricaoVaga.Text = vaga.GetDescricao();
            TipoVaga.Text = vaga.GetTipo();
            Curso.Text = vaga.GetCurso();
            Jornada.Text = vaga.GetJornada();
            QtdeVaga.Text = vaga.GetNVagas().ToString();

            if (BancodeDados.BuscarAluno(BancodeDados.GetIdUser()).VagaInscrita(vaga.GetID()))
            {
                BtDes();
                st = false;
            }
            else
            {
                BtInsc();
                st = true;
            }
        }

        public void BtInsc()
        {
            BtnInscreverse.Content = "Inscrever-se";
            var converter = new BrushConverter();
            BtnInscreverse.Background = (Brush)converter.ConvertFromString("#FF27597E");
            
        }
        public void BtDes()
        {
            BtnInscreverse.Content = "Desinscrever";
            var converter = new BrushConverter();
            BtnInscreverse.Background = (Brush)converter.ConvertFromString("Red");
            
        }
        public void AttVagas()
        {
            if (parent == null) parent2.AttVagas();
            else parent.AttVagas();
        }

        private void BtnInscreverse_Click(object sender, RoutedEventArgs e)
        {
            if(st)
            {
                aluno.AdicionarVaga(vaga.GetID());
                vaga.Inscrever(aluno.GetID());
                BtDes();
                st = false;
            }
            else
            {
                vaga.Desinscrever(aluno.GetID());
                aluno.RemoverVaga(vaga.GetID());
                BtInsc();
                st = true;
            }
            AttVagas();
        }

        private void BtnMsg_Click(object sender, RoutedEventArgs e)
        {
            int id;
            id = aluno.ChatExiste(vaga.GetIdEmpresa());
            if (id < 0)
            {
                Chat ch = new Chat(vaga.GetIdEmpresa());
                id = ch.GetID();
            }
            BancodeDados.MenuAluno.AbrirChat(id);
            this.Hide();
        }
    }
}
