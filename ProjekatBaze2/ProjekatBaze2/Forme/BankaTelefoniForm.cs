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
            Forme.DodajBankaTelefoni forma = new Forme.DodajBankaTelefoni(banka);
            forma.ShowDialog();
            this.popuniTabelu();
        }

        public void popuniTabelu()
        {   
    
            listaBrojBanke.Items.Clear();
            List<Banka_telefoniPregled> podaci = DTOManager.vratiBrojeveTelefona(banka.Id);

            foreach (Banka_telefoniPregled b in podaci)
            {
                ListViewItem item = new ListViewItem(new String[] { b.id.ToString(), b.Broj_Telefona });
                this.listaBrojBanke.Items.Add(item);
            }
            this.listaBrojBanke.Refresh();
        }

        private void BankaTelefoniForm_Load(object sender, EventArgs e)
        {
            this.Text = "BANKA " + banka.Ime.ToUpper();
            popuniTabelu();
        }

        private void listaBrojBanke_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxKontaktTelefoni_Enter(object sender, EventArgs e)
        {

        }

        private void btnIzmeniBrojBanke_Click(object sender, EventArgs e)
        {
            if (listaBrojBanke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite broj koji zelite da zamenite!");
                return;
            }

            int idBroj = Int32.Parse(listaBrojBanke.SelectedItems[0].SubItems[0].Text);
            Banka_telefoniBasic telefon = DTOManager.vratiBrojTelefona(idBroj);
            IzmeniBankaTelefonForm forma = new IzmeniBankaTelefonForm(telefon);
            forma.ShowDialog();
            this.popuniTabelu();
        }

        private void btnObrisiBrojBanke_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da obrisete izabrani telefon?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            int idBroj = Int32.Parse(listaBrojBanke.SelectedItems[0].SubItems[0].Text);
            if (idBroj == 0)
            {
                MessageBox.Show("Morate selektovati broj");
                return;
            }    
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiBroj(idBroj);
                MessageBox.Show("Uspesno obrisan broj");
                this.popuniTabelu();

            }
        }
    }
}
