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
    /// Interação lógica para TEditarPerfilEmpresa_Coordenador.xam
    /// </summary>
    public partial class TEditarPerfilEmpresa_Coordenador : UserControl
    {
        private Empresa empresa;
        public TEditarPerfilEmpresa_Coordenador(int id)
        {
            InitializeComponent();
            empresa = BancodeDados.BuscarEmpresa(id);
            AttDados();
        }

        public void AttDados()
        {
            NomeEmpresa.Text = empresa.GetNome();
            CnpjEmpresa.Text = empresa.GetCNPJ().ToString();
            EmailEmpresa.Text = empresa.GetEmail();

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            bool clear = true;
            if(NomeEmpresa.Text.Equals(""))
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
                CnpjEmpresa.Text = "Formato invalido";
                clear = false;
            }

            if(EmailEmpresa.Text.Equals(""))
            {
                //email vazio
                clear = false;
            }
            else if(BancodeDados.BuscarID(EmailEmpresa.Text)!=0 && BancodeDados.BuscarID(EmailEmpresa.Text) != empresa.GetID())
            {
                //email ja existe
                clear = false;
            }

            if (clear)
            {
                empresa.SetNome(NomeEmpresa.Text);
                empresa.SetCNPJ(long.Parse(CnpjEmpresa.Text));
                empresa.SetEmail(EmailEmpresa.Text);
                TExibirPerfilEmpresa_Coordenador te = new TExibirPerfilEmpresa_Coordenador(empresa.GetID());
                BancodeDados.MenuCoordenador.CarregarJanela(te);
            }
            
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            TExibirPerfilEmpresa_Coordenador te = new TExibirPerfilEmpresa_Coordenador(empresa.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }
    }
}
