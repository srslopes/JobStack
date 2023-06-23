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
    /// Interação lógica para TExibirPerfilEmpresa_Coordenador.xam
    /// </summary>
    public partial class TExibirPerfilEmpresa_Coordenador : UserControl
    {
        private Empresa empresa;

        public TExibirPerfilEmpresa_Coordenador(int id)
        {
            InitializeComponent();
            empresa = BancodeDados.BuscarEmpresa(id);
            AttDados();
            AttLista();
        }
        public void AttDados()
        {
            Img.ImageSource = BancodeDados.BuscarImg(empresa.GetIdImg());
            NomeEmpresa.Text = empresa.GetNome();
            cnpj.Text = empresa.GetCNPJ().ToString();
            InfoEmpresa.Text = empresa.GetSobre();
        }

        public void AttLista()
        {
            SPVagas.Children.Clear();
            SPVagas.Height = 0;
            for(int i=0; i<empresa.GetVagas().Count; i++)
            {
                if(BancodeDados.BuscarVaga(empresa.GetVagas()[i]).GetStatus()==3)
                {
                    DesignVagaLista_Coordenador vaga = new DesignVagaLista_Coordenador(empresa.GetVagas()[i]);
                    SPVagas.Children.Add(vaga);
                    SPVagas.Height += 110;
                }
                
            }
            for (int i = 0; i < empresa.GetVagas().Count; i++)
            {
                if (BancodeDados.BuscarVaga(empresa.GetVagas()[i]).GetStatus() == 2)
                {
                    DesignVagaLista_Coordenador vaga = new DesignVagaLista_Coordenador(empresa.GetVagas()[i]);
                    SPVagas.Children.Add(vaga);
                    SPVagas.Height += 110;
                }
            }
            for (int i = 0; i < empresa.GetVagas().Count; i++)
            {
                if (BancodeDados.BuscarVaga(empresa.GetVagas()[i]).GetStatus() == 0)
                {
                    DesignVagaLista_Coordenador vaga = new DesignVagaLista_Coordenador(empresa.GetVagas()[i]);
                    SPVagas.Children.Add(vaga);
                    SPVagas.Height += 110;
                }
            }
            for (int i = 0; i < empresa.GetVagas().Count; i++)
            {
                if (BancodeDados.BuscarVaga(empresa.GetVagas()[i]).GetStatus() == 1)
                {
                    DesignVagaLista_Coordenador vaga = new DesignVagaLista_Coordenador(empresa.GetVagas()[i]);
                    SPVagas.Children.Add(vaga);
                    SPVagas.Height += 110;
                }
            }
            if (empresa.GetVagas().Count==0)
            {
                SemVagas sv = new SemVagas();
                SPVagas.Children.Add(sv);
                SPVagas.Height = 40;
            }
        }

        private void BtnChat_Click(object sender, RoutedEventArgs e)
        {
            TBatePapo bp = new TBatePapo(BancodeDados.BuscarCoordenador(BancodeDados.GetIdUser()).ChatExiste(empresa.GetID()));
            BancodeDados.MenuCoordenador.CarregarJanela(bp);
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            TEditarPerfilEmpresa_Coordenador te = new TEditarPerfilEmpresa_Coordenador(empresa.GetID());
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }

        private void BtnVoltar_Copy_Click(object sender, RoutedEventArgs e)
        {
            TEmpresasCoordenador te = new TEmpresasCoordenador();
            BancodeDados.MenuCoordenador.CarregarJanela(te);
        }

    }
}
