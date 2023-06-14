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
    /// Interação lógica para TVagasEmAberto.xam
    /// </summary>
    public partial class TVagasEmAberto : UserControl
    {
        private Empresa empresa;

        public TVagasEmAberto()
        {
            InitializeComponent();
            empresa = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser());
            AttLista();
        }

        public void AttLista()
        {
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            List<int> vagas = empresa.GetVagas();
            for (int i = 0; i < vagas.Count; i++)
            {
                Vaga vaga = BancodeDados.BuscarVaga(vagas[i]);
                if (vaga.GetStatus() == 2)
                {
                    DesignVaga_Empresa v = new DesignVaga_Empresa(vaga.GetID());
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }

            }
        }
    }
}
