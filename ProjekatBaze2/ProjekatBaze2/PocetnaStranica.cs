using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatBaze2
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBanka_Click(object sender, EventArgs e)
        {
            ProjekatBaze2.Forme.BankaForm forma = new Forme.BankaForm();
            forma.ShowDialog();
            
        }

        private void btnBankomati_Click(object sender, EventArgs e)
        {
            Forme.BankomatiForm forma = new Forme.BankomatiForm();
            forma.ShowDialog();
        }
    }
}
