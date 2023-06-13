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
    /// Interação lógica para TFormCurriculoAluno.xam
    /// </summary>
    public partial class TFormCurriculoAluno : UserControl
    {
        private TPerfilAluno parent;
        private Aluno aluno;
        private BitmapImage bitmap;

        public TFormCurriculoAluno(TPerfilAluno Janela)
        {
            parent = Janela;
            bitmap = null;
            InitializeComponent();
            aluno = BancodeDados.BuscarAluno(BancodeDados.GetIdUser());
            NomeAluno.Text = aluno.GetNome();
            RAAluno.Text = aluno.GetRa().ToString();
            CBCursos.SelectedIndex = aluno.GetCurso();
            CBPeriodo.SelectedIndex = aluno.GetSemestre()-1;
            CampoFormacao.Text = aluno.GetFormacao();
            CampoExperiencia.Text = aluno.GetExperiencia();
            Img.ImageSource = BancodeDados.BuscarImg(aluno.GetIdImg());
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            aluno.SetNome(NomeAluno.Text);
            aluno.SetRa(long.Parse(RAAluno.Text));
            aluno.SetCurso(CBCursos.SelectedIndex);
            aluno.SetSemestre(CBPeriodo.SelectedIndex +1);
            aluno.SetFormacao(CampoFormacao.Text);
            aluno.SetExperiencia(CampoExperiencia.Text);
            if(bitmap!=null) aluno.SetIdImg(BancodeDados.SalvarImg(bitmap));
            parent.AttDados();
            BancodeDados.MenuAluno.CarregarJanela(parent);
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            parent.AttDados();
            BancodeDados.MenuAluno.CarregarJanela(parent);
        }

        private void AlterarImagem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFileDialog.Title = "Selecione a foto de perfil";

            if (openFileDialog.ShowDialog() == true)
            {
                // Carrega a imagem selecionada em um objeto BitmapImage
                bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();

                // Busca a imagem pelo ID e carrega no Image
                Img.ImageSource = bitmap;
            }
        }
    }
}
