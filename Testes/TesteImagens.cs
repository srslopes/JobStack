using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace JobStack.Testes
{

    public partial class TesteImagens : Form
    {


        public TesteImagens()
        {
            InitializeComponent();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotãoProcurarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFileDialog.Title = "Selecione a foto de perfil";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Adiciona a imagem à lista de imagens e obtém o ID associado
                int id = BancodeDados.AdicionarImagem(openFileDialog.FileName);

                // Busca a imagem pelo ID e carrega no PictureBox


                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Exibe o OpenFileDialog para o usuário selecionar a imagem a ser carregada
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFileDialog.Title = "Selecione a imagem a ser carregada";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carrega a imagem selecionada no PictureBox

            }

        }
    }
}

