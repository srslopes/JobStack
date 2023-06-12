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
    /// Interação lógica para TPerfilAluno.xam
    /// </summary>
    public partial class TPerfilAluno : UserControl
    {
        private Aluno aluno;
        public TPerfilAluno()
        {
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            AttDados();
        }
        public void AttDados()
        {
            Img.ImageSource = BancodeDados.BuscarImg(aluno.GetIdImg());
            if (!aluno.GetNome().Equals(""))
            {
                NomeAluno.Text = aluno.GetNome();                
            }
            if(aluno.GetCurso()!=-1)
            {
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
            }            
            if(aluno.GetSemestre()>0) Periodo.Text = aluno.GetSemestre() + "º Semestre";
            if (!aluno.GetFormacao().Equals("")) FormAluno.Text = aluno.GetFormacao();
            if (!aluno.GetExperiencia().Equals("")) ExpAluno.Text = aluno.GetExperiencia();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            TFormCurriculoAluno ca = new TFormCurriculoAluno(this);
            BancodeDados.MenuAluno.CarregarJanela(ca);
        }
    }
}
