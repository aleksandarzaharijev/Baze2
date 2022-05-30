using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatBaze2.Forme
{
    public partial class DodajBankaTelefonForm : Form
    {
        public BankaBasic banka;
        public Banka_telefoniBasic bankaTel;
        public DodajBankaTelefonForm()
        {
            InitializeComponent();
        }

        public DodajBankaTelefonForm(BankaBasic banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void DodajBankaTelefonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
