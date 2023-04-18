using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStack.Testes
{
    public partial class TesteChat : Form
    {
        public TesteChat()
        {
            InitializeComponent();
        }

        private void PanelConversas_Paint(object sender, PaintEventArgs e)
        {
            List<int> lista;
            switch(BancodeDados.BuscarUsuario().GetType().ToString())
            {
                default:
                    lista = BancodeDados.BuscarAluno(BancodeDados.GetIdUser()).GetChats();
                    break;
                case "JobStack.Empresa":
                    lista = BancodeDados.BuscarEmpresa(BancodeDados.GetIdUser()).GetChats();
                    break;
                case "JobStack.Admin":
                    lista = BancodeDados.BuscarAdmin(BancodeDados.GetIdUser()).GetChats();
                    break;
                case "JobStack.Coordenador":
                    lista = BancodeDados.BuscarCoordenador(BancodeDados.GetIdUser()).GetChats();
                    break;
            }
            for(int i=0; i< lista.Count; i++)
            {
                ListaConv n = new ListaConv(i);
                n.MdiParent = this;
                n.FormBorderStyle = FormBorderStyle.None;
                n.StartPosition = FormStartPosition.CenterParent;
            }
        }
    }
}
