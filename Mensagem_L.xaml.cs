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
    /// Interação lógica para Mensagem_L.xam
    /// </summary>
    public partial class Mensagem_L : UserControl
    {

        //altura = 45, largura = 50

        private int limite = 16;

        private int borda = 16;

        private int altura;

        private int largura;

        private int linhas;

        private int comprimento;

        private int tam;

        public Mensagem_L(string mensagem, DateTime data)
        {
            InitializeComponent();
            Mensagem.Text = mensagem;
            Mensagem.HorizontalAlignment = HorizontalAlignment.Center;
            Data.Text = data.ToString();

            tam = mensagem.Length;
            if (tam <= limite)
            {
                comprimento = tam;
                linhas = 1;
            }
            else
            {
                comprimento = limite;
                linhas = tam / limite;
                if (tam % limite > 0) linhas++;
            }
            altura = 2 * borda + linhas * 25 + 8;
            largura = 2 * borda + comprimento * 12 + 6;

            this.Height = altura + 25;
            Borda.Height = altura + 31;
            Borda.Width = largura;
            Msg.Height = altura;
            Msg.Width = largura;
        }
        public double getAltura()
        {
            return altura+25;
        }
    }
}
