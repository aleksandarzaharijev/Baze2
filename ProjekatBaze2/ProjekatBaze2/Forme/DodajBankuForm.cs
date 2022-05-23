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
    public partial class DodajBankuForm : Form
    {
        BankaBasic banka;
        public DodajBankuForm()
        {
            InitializeComponent();
            banka = new BankaBasic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DodajBankuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajBankuKonacno_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu banku u sistem?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.banka.Ime = txtBankaIme.Text;
                this.banka.AdresaCentrale = TxtAdresaCentrale.Text;
                this.banka.WebAdresa = txtAdresa.Text;
                this.banka.Email = txtEmail.Text;

                DTOManager.dodajBanku(this.banka);
                MessageBox.Show("Uspesno dodavanje banke");
                this.Close();
            }
            else
            {

            }
    }
}
}
