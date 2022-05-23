using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class KlijentMapiranja : ClassMap<ProjekatBaze2.Entiteti.Klijent>
    {
        public KlijentMapiranja()
        {
            Table("KLIJENT");

            Id(x => x.Id, "JEDIDENTFBROJ").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Broj_Telefona, "BROJTELEFONA");
            Map(x => x.Email, "EMAIL");

            HasMany(x => x.Devizni_Racuni).KeyColumn("BROJRACUNA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Dinarski_Racuni).KeyColumn("BROJRACUNA").LazyLoad().Cascade.All().Inverse();
           // HasMany(x => x.Fizicka_Lica).KeyColumn("JEDIDENTFBROJ").LazyLoad().Cascade.All().Inverse();
           // HasMany(x => x.Pravna_Lica).KeyColumn("JEDIDENTFBROJ").LazyLoad().Cascade.All().Inverse();
        
            HasMany(x => x.Klijent_Komentari).KeyColumn("IDKLIJENTKOMENTARI").LazyLoad().Cascade.All().Inverse();
        }
    }
   

  
}