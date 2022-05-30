using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using ProjekatBaze2.Entiteti;
using NHibernate;
namespace ProjekatBaze2
{
    public class DTOManager
    {
        #region Banka
        public static List<BankaPregled> vratiSveBanke()
        {
            List<BankaPregled> banke = new List<BankaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Banka> sveBanke = from o in s.Query<Banka>() select o;
                foreach (Banka b in sveBanke)
                {
                    banke.Add(new BankaPregled(b.Id, b.AdresaCentrale, b.WebAdresa, b.Ime, b.Email));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec);
            }
            return banke;
        }
        public static void dodajBanku(BankaBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka banka = new Banka();
                banka.Ime = b.Ime;
                banka.WebAdresa = b.WebAdresa;
                banka.Email = b.Email;
                banka.AdresaCentrale = b.AdresaCentrale;

                s.SaveOrUpdate(banka);
                s.Flush();
                s.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static BankaBasic izmeniBanku(BankaBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka banka = s.Load<Banka>(b.Id);
                banka.Ime = b.Ime;
                banka.WebAdresa = b.WebAdresa;
                banka.Email = b.Email;
                banka.AdresaCentrale = b.AdresaCentrale;

                s.Update(banka);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return b;
        }
     
        public static BankaBasic vratiBanku(int id)
        {
            BankaBasic b = new BankaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Banka banka = s.Load<Banka>(id);
                b = new BankaBasic(banka.Id, banka.AdresaCentrale, banka.WebAdresa, banka.Ime, banka.Email);
                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return b;
        }
        #endregion

        #region Banka_Telefoni
        public static List<Banka_telefoniPregled> vratiSveBrojeveTelefona() //zar ova funckija nije ista kao i u 181. liniji 
        {
            List<Banka_telefoniPregled> bankaTelefoni = new List<Banka_telefoniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Banka_telefoni> svebankeTelefoni = from o in s.Query<Banka_telefoni>() select o;
                foreach (Banka_telefoni b in svebankeTelefoni)
                {
                    bankaTelefoni.Add(new Banka_telefoniPregled(b.Id,b.Broj_Telefona));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec);
            }
            return bankaTelefoni;
        }
        public static void dodajBrojTelefona(Banka_telefoniBasic b,int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka_telefoni bankaTelefon = new Banka_telefoni();
                bankaTelefon.Broj_Telefona = b.Broj_Telefona;
                Banka bank = s.Load<Banka>(id);
                bankaTelefon.BrojBanke = bank;

                s.SaveOrUpdate(bankaTelefon);
                s.Flush();
                s.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static Banka_telefoniBasic izmeniBrojTelefona(Banka_telefoniBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Banka_telefoni bankaTelefon = s.Load<Banka_telefoni>(b.id);
                bankaTelefon.Broj_Telefona = b.Broj_Telefona;
               

                s.SaveOrUpdate(bankaTelefon);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return b;
        }

        public static Banka_telefoniBasic vratiBrojTelefona(int id)
        {
            Banka_telefoniBasic tel = new Banka_telefoniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Banka_telefoni t = s.Load<Banka_telefoni>(id);
                tel.Broj_Telefona = t.Broj_Telefona;
                tel.id = t.Id;

                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return tel;
        }
        public static List<Banka_telefoniPregled> vratiBrojeveTelefona(int id)
        {
            List<Banka_telefoniPregled> brojevi = new List<Banka_telefoniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Banka_telefoni> telefoni = from o in s.Query<Banka_telefoni>()
                                                       where o.BrojBanke.Id == id
                                                       select o;
                foreach (Banka_telefoni r in telefoni)
                {
                    brojevi.Add(new Banka_telefoniPregled(r.Id,r.Broj_Telefona));
                }
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return brojevi;
        }
        public static void obrisiBroj (int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Banka_telefoni tel = s.Load<Banka_telefoni>(id);
                s.Delete(tel);
                s.Flush();
                s.Close();
            }
            catch (Exception e)

            {
                Console.WriteLine(e);
            }
        }
        #endregion

<<<<<<< HEAD
        #region Filijale

        public static void dodajFilijalu(FilijalaBasic f , int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Filijala filijala = new Filijala();
                filijala.Adresa = f.Adresa;
                filijala.BrojTelefona = f.BrojTelefona;
                filijala.RadnoVreme = f.BrojTelefona;
                Banka bank = s.Load<Banka>(id);
                filijala.BankaId = bank;

                s.SaveOrUpdate(filijala);
                s.Flush();
                s.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static FilijalaBasic izmeniFilijalu(FilijalaBasic f)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Filijala filijala = s.Load<Filijala>(f.Id);
                filijala.Adresa = f.Adresa;
                filijala.BrojTelefona = f.BrojTelefona;
                filijala.RadnoVreme = f.BrojTelefona;

                s.SaveOrUpdate(filijala);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return f;
        }
        public static List<FilijalaPregled> vratiFilijale(int id)
        {
            List<FilijalaPregled> filijale = new List<FilijalaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Filijala> filijala = from o in s.Query<Filijala>()
                                                       where o.BankaId.Id == id
                                                       select o;
                foreach (Filijala r in filijala)
                {
                    filijale.Add(new FilijalaPregled(r.Id,r.Adresa, r.BrojTelefona,r.RadnoVreme));
                }
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return filijale;
        }
        


        #endregion


        #region
        #endregion
=======
        #region Dinarski_Racuni
        public static List<Dinarski_racunPregled> vratiSveDinarskeRacune(int id)
        {
            List<Dinarski_racunPregled> dinarskiRacuni = new List<Dinarski_racunPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Dinarski_racun> sviDinarskiRacuni = from o in s.Query<Dinarski_racun>() 
                                                                where o.RacunBanka.Id==id select o;
                foreach(Dinarski_racun d in sviDinarskiRacuni)
                {
                    dinarskiRacuni.Add(new Dinarski_racunPregled(d.Id, d.DatumOtvaranja, d.Saldo));
                }
                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return dinarskiRacuni;
        }

        #endregion
>>>>>>> 99a96c349ae4d26b7065742c05059c62abe438ad
    }

}
