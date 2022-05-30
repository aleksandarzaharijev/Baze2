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
    
    public partial class FilijalaForm : Form
    {
        BankaBasic banka;
        public FilijalaForm()
        {
            InitializeComponent();
        }
        public FilijalaForm(BankaBasic b)
        {
            InitializeComponent();
            banka = b;
        }

        public void popuniTabelu()
        {

            listaFilijala.Items.Clear();
            List<FilijalaPregled> podaci = DTOManager.vratiFilijale(banka.Id);

            foreach (FilijalaPregled b in podaci)
            {
                ListViewItem item = new ListViewItem(new String[] { b.Id.ToString(),b.Adresa ,b.BrojTelefona,b.RadnoVreme });
                this.listaFilijala.Items.Add(item);
            }
            this.listaFilijala.Refresh();
        }

        private void FilijalaForm_Load(object sender, EventArgs e)
        {
            this.Text = "BANKA " + banka.Ime.ToUpper();
            popuniTabelu();

        }

        private void btnDodajFilijalu_Click(object sender, EventArgs e)
        {
            Forme.DodajFilijaluForm forma = new Forme.DodajFilijaluForm(banka);
            forma.ShowDialog();
            this.popuniTabelu();
        }
    }
}
