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
    /// Interação lógica para TPerfilEmpresa.xam
    /// </summary>
    public partial class TPerfilEmpresa : UserControl
    {
        private Empresa empresa;
        public TPerfilEmpresa()
        {
            InitializeComponent();
            empresa = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser());
            AttDados();
        }

        public void AttDados()
        {
            Img.ImageSource = BancodeDados.BuscarImg(empresa.GetIdImg());
            if (!empresa.GetNome().Equals("")) NomeEmpresa.Text = empresa.GetNome();
            if (empresa.GetCNPJ() != 0) cnpj.Text = empresa.GetCNPJ().ToString();
            if (!empresa.GetSobre().Equals("")) InfoEmpresa.Text = empresa.GetSobre();

        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            TFormInfoEmpresa ie = new TFormInfoEmpresa(this);
            BancodeDados.MenuEmpresa.CarregarJanela(ie);
        }
    }
}
