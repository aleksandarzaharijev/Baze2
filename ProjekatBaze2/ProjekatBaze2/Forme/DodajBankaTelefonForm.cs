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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string poruka = "Da li zelite da izvrsite dodavanje broja?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                if (result == DialogResult.OK)
                {
                    bankaTel.Broj_Telefona = txtDodajBankaBroj.Text;


                    /*int idBanke = Int32.Parse(listaBanke.SelectedItems[0].SubItems[0].Text);
                    BankaBasic banka = DTOManager.vratiBanku(idBanke);
                    banka.Banka_Telefoni.Add(bankaTel);
                    DTOManager.dodajBrojTelefona(bankaTel);*/

                }
                else
                {

                }
            }
        }
    }
}
