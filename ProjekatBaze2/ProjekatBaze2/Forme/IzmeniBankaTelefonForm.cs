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
    public partial class IzmeniBankaTelefonForm : Form
    {
        public Banka_telefoniBasic telefon;
        public IzmeniBankaTelefonForm()
        {
            InitializeComponent();
        }
        public IzmeniBankaTelefonForm(Banka_telefoniBasic t)
        {
            InitializeComponent();
            this.telefon = t;
        }


        public void popuni()
        {
            txtIzmenaTelefona.Text = this.telefon.Broj_Telefona;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IzmeniBankaTelefonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIzmeniBrojBanke_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene banke?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.telefon.Broj_Telefona = txtIzmenaTelefona.Text;
                DTOManager.izmeniBrojTelefona(this.telefon);
                
            }
            else
            {

            }
        }
    }
}
