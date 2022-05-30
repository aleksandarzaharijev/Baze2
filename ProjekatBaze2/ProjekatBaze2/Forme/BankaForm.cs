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
    public partial class BankaForm : Form
    {
        public BankaForm()
        {
            InitializeComponent();
        }

        private void BankaForm_Load(object sender, EventArgs e)
        {
            popuniTabelu();
        }

        public void popuniTabelu()
        {
            listaBanke.Items.Clear();
            List<BankaPregled> podaci = DTOManager.vratiSveBanke();

            foreach (BankaPregled b in podaci)
            {
                ListViewItem item = new ListViewItem(new String[] { b.Id.ToString(), b.AdresaCentrale, b.WebAdresa, b.Ime, b.Email });
                listaBanke.Items.Add(item);
            }
            listaBanke.Refresh();
        }

        private void btnDodajBanku_Click(object sender, EventArgs e)
        {
            Forme.DodajBankuForm forma = new Forme.DodajBankuForm();
            forma.ShowDialog();
            this.popuniTabelu();
        }

        private void btnIzmeniBanku_Click(object sender, EventArgs e)
        {
            if (listaBanke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite banku cije podatke zelite da promenite!");
                return;
            }

            int idBanke = Int32.Parse(listaBanke.SelectedItems[0].SubItems[0].Text);
            BankaBasic banka = DTOManager.vratiBanku(idBanke);
            IzmeniBankuForm forma = new IzmeniBankuForm(banka);
            forma.ShowDialog();
            this.popuniTabelu();
        }

        private void btnBankaTelefoni_Click(object sender, EventArgs e)
        {
            if(listaBanke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite banku cije podatke zelite da promenite!");
                return;
            }
            int idBanke = Int32.Parse(listaBanke.SelectedItems[0].SubItems[0].Text);
            BankaBasic banka = DTOManager.vratiBanku(idBanke);
            BankaTelefoniForm forma = new BankaTelefoniForm(banka);
            forma.ShowDialog();
        }

        private void btnFilijale_Click(object sender, EventArgs e)
        {
            Forme.FilijalaForm forma = new Forme.FilijalaForm();
            forma.ShowDialog();
        }

        private void btnDinarskiRacuni_Click(object sender, EventArgs e)
        {
            Forme.DinarskiRacuniForm forma = new Forme.DinarskiRacuniForm();
            forma.ShowDialog();
        }
    }
}
