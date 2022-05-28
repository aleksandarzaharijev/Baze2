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
    public partial class BankaTelefoniForm : Form
    {
        BankaBasic banka;

        public BankaTelefoniForm()
        {
            InitializeComponent();
        }

        public BankaTelefoniForm(BankaBasic b)
        {
            InitializeComponent();
            banka = b;
        }

        private void btnDodajBrojBanke_Click(object sender, EventArgs e)
        {
            //Forme.DodajBankaTelefonForm forma = new Forme.DodajBankaTelefonForm(banka.Id);
            //forma.ShowDialog();
            popuniTabelu();
        }

        public void popuniTabelu()
        {
            listaBrojBanke.Items.Clear();
            List<Banka_telefoniPregled> podaci = DTOManager.vratiSveBrojeveTelefona();

            foreach (Banka_telefoniPregled b in podaci)
            {
                ListViewItem item = new ListViewItem(new String[] { b.id.ToString(), b.Broj_Telefona });
                listaBrojBanke.Items.Add(item);
            }
            listaBrojBanke.Refresh();
        }

        private void BankaTelefoniForm_Load(object sender, EventArgs e)
        {
            this.Text = "BANKA " + banka.Ime.ToUpper();
            popuniTabelu();
        }
    }
}
