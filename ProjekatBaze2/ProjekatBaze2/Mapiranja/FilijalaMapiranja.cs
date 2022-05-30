using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class FilijalaMapiranja : ClassMap<ProjekatBaze2.Entiteti.Filijala>
    {
        public FilijalaMapiranja()
        {
            Table("FILIJALA");

            Id(x => x.Id, "REDNIBROJ").GeneratedBy.TriggerIdentity();

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrojTelefona, "BROJTELEFONA");
            Map(x => x.RadnoVreme, "RADNOVREME");
            References(x => x.BankaId).Column("JEDBRBANKE").LazyLoad();

            HasMany(x => x.Bankomati).KeyColumn("RBRFILIJALA").LazyLoad().Cascade.All().Inverse();

          


        }
    }
}