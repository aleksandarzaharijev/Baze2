using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
   public class BankomatMapiranja: ClassMap<ProjekatBaze2.Entiteti.Bankomat>
    {
        public BankomatMapiranja()
        {
            Table("BANKOMATI");

            Id(x => x.Id, "JEDBROJ").GeneratedBy.Assigned();

            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Status, "STATUS");
            Map(x => x.NazivProizvodjaca , "NAZIVPROIZVODJACA");
            Map(x => x.DatumPoslednjegServisa, "DATPOSLSERVISA");
            References(x => x.FilijalaId).Column("RBRFILIJALA").LazyLoad();
            HasMany(x => x.Transakcije).KeyColumn("JEDBRBANKOMATA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
