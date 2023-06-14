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
    /// Interação lógica para TSolicitacoesVagasCoordenador.xam
    /// </summary>
    public partial class TSolicitacoesVagasCoordenador : UserControl
    {
        public TSolicitacoesVagasCoordenador()
        {
            InitializeComponent();
            AttLista();
        }
        public void AttLista()
        {
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            List<Vaga> vagas = BancodeDados.GetListaVagas();
            bool vazia = true;
            for(int i= vagas.Count-1; i>=0; i--)
            {
                if(vagas[i].GetStatus()==0)
                {
                    vazia = false;
                    DesignVagaCoordenador v = new DesignVagaCoordenador(vagas[i].GetID());
                    SPVagas.Children.Add(v);
                    SPVagas.Height += 210;
                }
            }
            if(vazia)
            {
                SemVagas sv = new SemVagas();
                SPVagas.Children.Add(sv);
                SPVagas.Height = 40;
            }
        }
    }
}
