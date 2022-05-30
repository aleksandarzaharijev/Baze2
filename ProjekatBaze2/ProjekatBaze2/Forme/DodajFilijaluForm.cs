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
    public partial class DodajFilijaluForm : Form
    {
        FilijalaBasic filijala;
        BankaBasic banka;
        public DodajFilijaluForm(BankaBasic banka)
        {
            InitializeComponent();
            filijala = new FilijalaBasic();
            this.banka = banka;
        }

        private void DodajFilijaluForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajFilijaluKonacno_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu filijalu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.filijala.Adresa = txtAdresa.Text;
                this.filijala.BrojTelefona = txtBrojTelefona.Text;
                this.filijala.RadnoVreme = txtRadnoVreme.Text;

                DTOManager.dodajFilijalu(filijala, banka.Id);
                MessageBox.Show("Uspesno dodavanje broja");
                this.Close();
            }
            else
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
