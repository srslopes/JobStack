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
    /// Interação lógica para TCadastrarVagaEmpresa.xam
    /// </summary>
    public partial class TCadastrarVagaEmpresa : UserControl
    {
        public TCadastrarVagaEmpresa()
        {
            InitializeComponent();
            NomeEmpresa.Text = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser()).GetNome();
        }

        private void BtnMais_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(BtnNumero.Content);
            if(i < 99)
            {
                BtnNumero.Content = i + 1;
            }
        }

        private void BtnMenos_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(BtnNumero.Content);
            if(i > 0)
            {
                BtnNumero.Content = i - 1;
            }
        }

        private void BtnCriar_Click(object sender, RoutedEventArgs e)
        {
            bool clear = true;
            if(TituloVaga.Text.Equals(""))//usuario deve inserir um titulo para a vaga
            {
                //Inserir Avisos
                clear = false;
            }
            if (Tipo.Text.Equals(""))//usuario deve inserir um tipo para a vaga
            {
                //Inserir Avisos
                clear = false;
            }
            if (Turno.Text.Equals(""))//usuario deve inserir um turno para a vaga
            {
                //Inserir Avisos
                clear = false;
            }
            if (Jornada.Text.Equals(""))//usuario deve inserir uma jornada para a vaga
            {
                //Inserir Avisos
                clear = false;
            }
            if (SalarioVaga.Text.Equals(""))//usuario deve inserir um salario para a vaga
            {
                //Inserir Avisos
                clear = false;
            }
            if (DescricaoVaga.Text.Equals(""))//usuario deve inserir uma descrição para a vaga
            {
                //Inserir Avisos
                clear = false;
            }
            if(CBCursos.SelectedIndex == -1)//usuario deve selecionar um curso para a vaga
            {
                //Inserir Avisos
                clear = false;
            }
            if (int.Parse(BtnNumero.Content.ToString()) <=0)//numero de vaga disponiveis não pode ser 0
            {
                //Inserir Aviso
                clear = false;
            }
            if (clear)
            {
                Vaga nova = new Vaga(BancodeDados.GetIdUser());
                nova.SetNome(TituloVaga.Text);
                nova.SetTurno(Turno.Text);
                nova.SetTipo(Tipo.Text);
                nova.SetJornada(Jornada.Text);
                nova.SetCurso(CBCursos.SelectedIndex);
                nova.SetSalario(SalarioVaga.Text);
                nova.SetDescricao(DescricaoVaga.Text);
                nova.SetNVagas(int.Parse(BtnNumero.Content.ToString()));
                TituloVaga.Text = "";
                Tipo.Text = "";
                Jornada.Text = "";
                SalarioVaga.Text = "";
                DescricaoVaga.Text = "";
                BtnNumero.Content = 0;
                TVagasPendentesEmpresa p = new TVagasPendentesEmpresa();
                BancodeDados.MenuEmpresa.CarregarSubJanela(p);
            }
        }
    }
}
