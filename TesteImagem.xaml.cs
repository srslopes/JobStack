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
                // Adiciona a imagem à lista de imagens e obtém o ID associado
                int id = BancodeDados.AdicionarImagem(openFileDialog.FileName);

                // Busca a imagem pelo ID e carrega no Image

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();
                Imagem.Source = bitmap;
            }

        }

        private void CarregarImagem_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(textID.Text);

            // Busca a imagem pelo ID e carrega no Image
            byte[] imagemBytes = BancodeDados.BuscarImagem(id);

            if (imagemBytes != null)
            {
                using (var ms = new MemoryStream(imagemBytes))
                {
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = ms;
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.EndInit();
                    Imagem.Source = bitmap;
                }
            }
        }







    }
}
