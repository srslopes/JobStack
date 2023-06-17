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
    /// Interação lógica para TFormAlunoCoordenador.xam
    /// </summary>
    public partial class TFormAlunoCoordenador : UserControl
    {
        private TAlunosCoordenador parent;

        public TFormAlunoCoordenador(TAlunosCoordenador janela)
        {
            parent = janela;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.MenuCoordenador.CarregarJanela(parent);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            bool clear = true;

            if (NomeAluno.Text.Equals(""))
            {
                //nome esta vazio
                clear = false;
            }

            if (CBCursos.SelectedIndex == -1)
            {
                //selecionar curso
                clear = false;
            }

            if (CBPeriodo.SelectedIndex == -1)
            {
                //selecionar periodo
                clear = false;
            }

            try
            {
                long x = long.Parse(RAAluno.Text);
            }
            catch (FormatException)
            {
                //Ra inválida
                RAAluno.Text = "";
                clear = false;
            }

            if (EmailAluno.Text.Equals(""))
            {

                clear = false;
            }
            else if (BancodeDados.BuscarID(EmailAluno.Text) != 0)
            {
                //email ja existe
                clear = false;
            }

            if(SenhaAluno.Password.Equals(""))
            {
                //senha vazia
                clear = false;
            }

            if (clear)
            {
                Aluno aluno = new Aluno();
                aluno.SetNome(NomeAluno.Text);
                aluno.SetCurso(CBCursos.SelectedIndex);
                aluno.SetSemestre(CBPeriodo.SelectedIndex + 1);
                aluno.SetRa(long.Parse(RAAluno.Text));
                aluno.SetEmail(EmailAluno.Text);
                aluno.SetSenha(SenhaAluno.Password);
                aluno.salvar();
                parent.AttLista();
                BancodeDados.MenuCoordenador.CarregarJanela(parent);
            }
        }
    }
}
