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
    public partial class DodajBankaTelefoni : Form
    {
        Banka_telefoniBasic telefoni;
        BankaBasic banka;
        public DodajBankaTelefoni()
        {
            InitializeComponent();
           
        }
        public DodajBankaTelefoni(BankaBasic b)
        {
            InitializeComponent();
            banka = b;
            telefoni = new Banka_telefoniBasic();
        }

        private void DodajBankaTelefoni_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi broj banke u sistem?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.telefoni.Broj_Telefona = txtBrojTelefona.Text;
                string brojevi = telefoni.Broj_Telefona;
                int element = telefoni.Broj_Telefona.Count();
                if (element == 11 || element == 12)
                {
                    
                    if (brojevi[0] != '0' || brojevi[0]==' ')
                    {
                        MessageBox.Show("Morate uneti broj koji pocinje nulom");
                    }
                    else
                    {
                        int i = 1;
                        int flag = 0;
                        while(flag ==0 && i<3)
                        {
                            if (brojevi[i] == ' ')
                                flag = 1;
                            i++;
                        }
                        if (flag == 0)
                        {
                            DTOManager.dodajBrojTelefona(telefoni, banka.Id);
                            MessageBox.Show("Uspesno dodavanje broja");
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
                }
            }
            else
            {

            }
        }
    }
}
