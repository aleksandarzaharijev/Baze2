            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ProjekatBaze2.Mapiranja
{
    public class BankaMapiranja: ClassMap<ProjekatBaze2.Entiteti.Banka>
    {
        public BankaMapiranja()
        {
            //Mapiranje
            Table("BANKA");

            Id(x => x.Id, "JEDIDENTFBANKE").GeneratedBy.TriggerIdentity();

            Map(x => x.AdresaCentrale, "ADRESACENTRALE");
            Map(x => x.WebAdresa, "WEBADRESA");
            Map(x => x.Ime, "IME");
            Map(x => x.Email, "EMAIL");

            HasMany(x => x.Devizni_Racuni).KeyColumn("JEDBRBANKE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Dinarski_Racuni).KeyColumn("JEDBRBANKE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Lista_Filijala).KeyColumn("JEDBRBANKE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Banka_Telefoni).KeyColumn("BROJBANKE").LazyLoad().Cascade.All().Inverse();
        }

    }
}
