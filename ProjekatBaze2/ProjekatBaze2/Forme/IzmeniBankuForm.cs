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
    public partial class IzmeniBankuForm : Form
    {
        public BankaBasic banka;
        public IzmeniBankuForm()
        {
            InitializeComponent();
        }

        public IzmeniBankuForm(BankaBasic b)
        {
            InitializeComponent();
            this.banka = b;
        }
        private void ProdavnicaUpdateForm_Load(object sender, EventArgs e)
        {
            popuni();
            this.Text = $"AZURIRANJE PRODAVNICE {banka.Ime.ToUpper()}";
        }

        public void popuni()
        {
            txtImeBankeIzmeni.Text = this.banka.Ime;
            txtEmailBankeIzmeni.Text = this.banka.Email;
            txtAdresaBankeIzmeni.Text = this.banka.AdresaCentrale;
            txtWebBankeIzmeni.Text = this.banka.WebAdresa;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAzurirajBanku_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene banke?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if(result == DialogResult.OK)
            {
               this.banka.Ime = txtImeBankeIzmeni.Text ;
               this.banka.Email = txtEmailBankeIzmeni.Text;
               this.banka.AdresaCentrale = txtAdresaBankeIzmeni.Text;
               this.banka.WebAdresa = txtWebBankeIzmeni.Text;
                DTOManager.izmeniBanku(this.banka);
                MessageBox.Show("Izmena je uspesno izvrsena!");
                this.Close();
                    
            }
            else
            {

            }
        }
    }
}
