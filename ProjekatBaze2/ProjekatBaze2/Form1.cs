using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjekatBaze2.Entiteti;
using NHibernate;
using FluentNHibernate.Cfg;

namespace ProjekatBaze2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // CreateSessionFactory();
        }

        private void cmdUcitaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatBaze2.Entiteti.Banka b = s.Load<ProjekatBaze2.Entiteti.Banka>(100000354);
                MessageBox.Show(b.Ime);
            
                s.Close();
               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajBanku_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Banka b = new Entiteti.Banka();
                
                b.AdresaCentrale = "8.septembar2";
                b.Ime = "Prob banka";
                b.WebAdresa = "www.pobna.rs";
                b.Email = "probn@gmail.rs";
                


                s.Save(b);
                //s.SaveOrUpdate(b);
                s.Flush();
                MessageBox.Show("Uspesno ste dodali banku");
                s.Close();

            }
            catch (Exception ec)
                {
                MessageBox.Show(ec.Message);
                 }
        }
    } 
}
