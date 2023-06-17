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
    /// Interação lógica para TEditarPerfilAluno_Coordenador.xam
    /// </summary>
    public partial class TEditarPerfilAluno_Coordenador : UserControl
    {
        private Aluno aluno;
        public TEditarPerfilAluno_Coordenador(int id)
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(id);
            AttDados();
        }
        public void AttDados()
        {
            NomeAluno.Text = aluno.GetNome();
            CBCursos.SelectedIndex = aluno.GetCurso();
            CBPeriodo.SelectedIndex = aluno.GetSemestre() - 1;
            RAAluno.Text = aluno.GetRa().ToString();
            EmailAluno.Text = aluno.GetEmail();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilAluno_Coordenador te = new TExibirPerfilAluno_Coordenador(aluno.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            bool clear = true;
            

            if(NomeAluno.Text.Equals(""))
            {
                //nome esta vazio
                clear = false;
            }

            if(CBCursos.SelectedIndex == -1)
            {
                //selecionar curso
                clear = false;
            }

            if(CBPeriodo.SelectedIndex == -1)
            {
                //selecionar periodo
                clear = false;
            }

            try
            {
                long x = long.Parse(RAAluno.Text);
            }
            catch(FormatException)
            {
                //Ra inválida
                RAAluno.Text = "";
                clear = false;
            }

            if (EmailAluno.Text.Equals(""))
            {

                clear = false;
            }
            else if (BancodeDados.BuscarID(EmailAluno.Text) != 0 && BancodeDados.BuscarID(EmailAluno.Text) != aluno.GetID())
            {
                //email ja existe
                clear = false;
            }

            if (clear)
            {
                aluno.SetNome(NomeAluno.Text);
                aluno.SetCurso(CBCursos.SelectedIndex);
                aluno.SetSemestre(CBPeriodo.SelectedIndex +1);
                aluno.SetRa(long.Parse(RAAluno.Text));
                aluno.SetEmail(EmailAluno.Text);
                TExibirPerfilAluno_Coordenador te = new TExibirPerfilAluno_Coordenador(aluno.GetID());
                BancodeDados.MenuCoordenador.CarregarJanela(te);
            }
            
        }
    }
}
