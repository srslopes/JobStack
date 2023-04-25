using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Exibe um OpenFileDialog para permitir que o usuário selecione um arquivo de imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carrega a imagem selecionada pelo usuário na PictureBox
                picImagem.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
