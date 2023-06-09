using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica interna para TesteImagem.xaml
    /// </summary>
    public partial class TesteImagem : Window
    {
        public TesteImagem()
        {
            InitializeComponent();
           
        }

        private void ProcurarImagem_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFileDialog.Title = "Selecione a foto de perfil";

            if (openFileDialog.ShowDialog() == true)
            {
                // Carrega a imagem selecionada em um objeto BitmapImage
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();

                // Adiciona a imagem à lista de imagens e obtém o ID associado
                int id = BancodeDados.SalvarImg(bitmap);

                // Busca a imagem pelo ID e carrega no Image
                Imagem.Source = BancodeDados.BuscarImg(id);
            }

        }

        private void CarregarImagem_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(textID.Text, out id))
            {
                // Busca a imagem pelo ID
                BitmapImage imagem = BancodeDados.BuscarImg(id);

                if (imagem != null)
                {
                    Imagem.Source = imagem;
                }
            }
            else
            {
                // Lidar com entrada inválida do ID (por exemplo, exibir uma mensagem de erro)
            }
        }
    }







    
}
