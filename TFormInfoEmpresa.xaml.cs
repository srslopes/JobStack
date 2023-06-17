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
    /// Interação lógica para TFormInfoEmpresa.xam
    /// </summary>
    public partial class TFormInfoEmpresa : UserControl
    {
        private Empresa empresa;
        private TPerfilEmpresa parent;
        private BitmapImage bitmap;

        public TFormInfoEmpresa(TPerfilEmpresa Janela)
        {
            InitializeComponent();
            empresa = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser());
            parent = Janela;
            bitmap = null;
            CampoInfoEmpresa.Text = empresa.GetSobre();
           
            Img.ImageSource = BancodeDados.BuscarImg(empresa.GetIdImg());
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

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            
            empresa.SetSobre(CampoInfoEmpresa.Text);
            if (bitmap != null) empresa.SetIdImg(BancodeDados.SalvarImg(bitmap));
            parent.AttDados();
            BancodeDados.MenuEmpresa.CarregarJanela(parent);

            //chamando a notificação de inscrição bem sucedida
            NotificacaoSucesso notificationWindow = new NotificacaoSucesso();
            notificationWindow.Owner = TMenuEmpresa.GetWindow(this);
            notificationWindow.Topmost = true;
            //aqui atualiza o texto da notificação
            notificationWindow.AtualizarMensagemSucesso("Seu perfil foi atualizado.");
            notificationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            notificationWindow.ShowDialog();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            parent.AttDados();
            BancodeDados.MenuEmpresa.CarregarJanela(parent);
        }

        private void AlterarSenha_Click(object sender, RoutedEventArgs e)
        {
            TAlterarSenha esenha = new TAlterarSenha(this);
            esenha.Owner = TMenuEmpresa.GetWindow(this);
            esenha.ShowDialog();

        }
    }
}
