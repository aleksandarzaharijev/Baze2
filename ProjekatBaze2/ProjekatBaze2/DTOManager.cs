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
    }

}
