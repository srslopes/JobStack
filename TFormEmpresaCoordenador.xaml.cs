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
    /// Interação lógica para TFormEmpresaCoordenador.xam
    /// </summary>
    public partial class TFormEmpresaCoordenador : UserControl
    {
        private TEmpresasCoordenador parent;
        public TFormEmpresaCoordenador(TEmpresasCoordenador janela)
        {
            InitializeComponent();
            parent = janela;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BancodeDados.MenuCoordenador.CarregarJanela(parent);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            bool clear = true;
            if (NomeEmpresa.Text.Equals(""))
            {
                //nome vazio
                clear = false;
            }

            try
            {
                long x = long.Parse(CnpjEmpresa.Text);
            }
            catch (FormatException)
            {
                //Ra inválida
                CnpjEmpresa.Text = "";
                clear = false;
            }

            if (EmailEmpresa.Text.Equals(""))
            {
                //email vazio
                clear = false;
            }
            else if (BancodeDados.BuscarID(EmailEmpresa.Text) != 0)
            {
                //email ja existe
                clear = false;
            }

            if(SenhaEmpresa.Password.Equals(""))
            {
                //senha vazia
                clear = false;
            }

            if (clear)
            {
                Empresa empresa = new Empresa();
                empresa.SetNome(NomeEmpresa.Text);
                empresa.SetCNPJ(long.Parse(CnpjEmpresa.Text));
                empresa.SetEmail(EmailEmpresa.Text);
                empresa.SetSenha(SenhaEmpresa.Password);
                empresa.salvar();
                parent.AttLista();
                BancodeDados.MenuCoordenador.CarregarJanela(parent);
            }
        }
    }
}
