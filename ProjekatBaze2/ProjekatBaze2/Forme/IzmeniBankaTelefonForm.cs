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
        public BankaBasic banka;
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
            popuni();
        }

        private void btnIzmeniBrojBanke_Click(object sender, EventArgs e)
        {
            telefon.Broj_Telefona = txtIzmenaTelefona.Text;
            string brojevi = telefon.Broj_Telefona;
            int element = telefon.Broj_Telefona.Count();
            if (element == 11 || element == 12)
            {
                if (brojevi[0] != '0' || brojevi[0] == ' ')
                {
                    MessageBox.Show("Morate uneti broj koji pocinje nulom");
                }
                else
                {
                    int i = 1;
                    int flag = 0;
                    while (flag == 0 && i < 3)
                    {
                        if (brojevi[i] == ' ')
                            flag = 1;
                        i++;
                    }
                    if (flag == 0)
                    {
                        DTOManager.izmeniBrojTelefona(telefon);
                        MessageBox.Show("Uspešna izmena broja telefona");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nepravilan format");
                    }
                }

            }
            else
            {
                MessageBox.Show("Unesite ispravan broj telefona u zadatim formatima:\n xxxx xxx xxx\n xxx xxx xxx\n xxx xxxx xxx  ");
                popuni();
            }
        }
    }
}
