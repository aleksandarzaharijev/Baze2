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
        public DodajBankaTelefonForm()
        {
            InitializeComponent();
        }

        private void DodajBankaTelefonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajBroj_Click(object sender, EventArgs e)
        {
            Banka_telefoniBasic b = new Banka_telefoniBasic();
        }
    }
}
