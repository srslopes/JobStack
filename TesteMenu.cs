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
    public partial class TesteMenu : Form
    {
        private TesteDB db;
        private TesteVagas vg;
        public TesteMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            db = new TesteDB();
            db.MdiParent = this;
            db.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            db.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            vg = new TesteVagas();
            vg.MdiParent = this;
            vg.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;            
            vg.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void ButtonDB_Click(object sender, EventArgs e)
        {
            vg.Hide();
            db.AttLista();
            db.Show();
            
        }

        private void ButtonVagas_Click(object sender, EventArgs e)
        {
            db.Hide();
            vg.AttLista();
            vg.Show();
        }

        private void TesteMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
