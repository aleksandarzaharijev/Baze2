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
    public partial class FizickaLicaForm : Form
    {
        BankaBasic banka;
        public FizickaLicaForm()
        {
            InitializeComponent();
        }

        public FizickaLicaForm(BankaBasic b)
        {
            InitializeComponent();
            banka = b;
        }
    }
}
