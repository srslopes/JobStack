using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStack
{
    public partial class TesteVagas : Form
    {
        public TesteVagas()
        {
            InitializeComponent();
        }

        private void ButtonCriar_Click(object sender, EventArgs e)
        {
            Vaga n = new Vaga(int.Parse(textBoxIdEmpresa.Text));
            BancodeDados.BuscarEmpresa(int.Parse(textBoxIdEmpresa.Text)).AdicionarVaga(n.GetID());
            AttLista();
        }

        private void ButtonAtt_Click(object sender, EventArgs e)
        {
            AttLista();
        }

        public void AttLista()
        {
            listBoxVagas.Items.Clear();
            string[] lista = BancodeDados.ExibirVagas().Split('?');
            for (int i = 0; i < lista.Length; i++)
            {
                listBoxVagas.Items.Add(lista[i]);
            }
        }

        private void ButtonInscrever_Click(object sender, EventArgs e)
        {
            BancodeDados.BuscarVaga(int.Parse(textBoxIdVaga.Text)).Inscrever(int.Parse(textBoxIdAluno.Text));
            BancodeDados.BuscarAluno(int.Parse(textBoxIdAluno.Text)).AdicionarVaga(int.Parse(textBoxIdVaga.Text));
            AttLista();
        }

        private void ButtonDesinscrever_Click(object sender, EventArgs e)
        {
            BancodeDados.BuscarVaga(int.Parse(textBoxIdVaga.Text)).Desinscrever(int.Parse(textBoxIdAluno.Text));
            BancodeDados.BuscarAluno(int.Parse(textBoxIdAluno.Text)).RemoverVaga(int.Parse(textBoxIdVaga.Text));
            AttLista();
        }
    }
}
