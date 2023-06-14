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
    /// Interação lógica para TVagasPendentesEmpresa.xam
    /// </summary>
    public partial class TVagasPendentesEmpresa : UserControl
    {
        private Empresa empresa;
        public TVagasPendentesEmpresa()
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
            bool vazia = true;
            for (int i = vagas.Count-1; i>=0; i--)
            {
                Vaga vaga = BancodeDados.BuscarVaga(vagas[i]);
                if(vaga.GetStatus()==0 || vaga.GetStatus() == 1)
                {
                    vazia = false;
                    DesignVaga_Empresa v = new DesignVaga_Empresa(vaga.GetID());
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }                
            }
            if (vazia)
            {
                SemVagas sv = new SemVagas();
                SPVagas.Children.Add(sv);
                SPVagas.Height = 40;
            }
        }
    }
}
