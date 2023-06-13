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
        private TVagasEmpresa parent;
        public TVagasPendentesEmpresa()
        {
            InitializeComponent();
            AttLista();
        }

        public void AttLista()
        {
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            List<Vaga> vagas = BancodeDados.GetListaVagas();
            for (int i = 0; i < vagas.Count; i++)
            {
                if(vagas[i].GetIdEmpresa()==BancodeDados.GetIdUser() && (vagas[i].GetStatus()==0 || vagas[i].GetStatus() == 1))
                {
                    DesignVaga_Empresa v = new DesignVaga_Empresa(vagas[i].GetID());
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
                
            }
        }
    }
}
