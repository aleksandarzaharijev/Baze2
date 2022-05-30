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
    public partial class DinarskiRacuniForm : Form
    {
        public DinarskiRacuniForm()
        {
            InitializeComponent();
        }

        private void DinarskiRacuniForm_Load(object sender, EventArgs e)
        {
            popuniTabelu();
        }

        public void popuniTabelu()
        {
            listaDinarskiRacuni.Items.Clear();
            List<Dinarski_racunPregled> podaci = DTOManager.vratiSveDinarskeRacune();

            foreach(Dinarski_racunPregled d in podaci)
            {
                ListViewItem item = new ListViewItem(new String[] {d.Id.ToString(),d.DatumOtvaranja.ToString(),d.Saldo.ToString()});
                listaDinarskiRacuni.Items.Add(item);
            }
            listaDinarskiRacuni.Refresh();
        }
    }
}
