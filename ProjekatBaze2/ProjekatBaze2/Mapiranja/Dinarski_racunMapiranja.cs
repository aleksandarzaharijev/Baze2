using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ProjekatBaze2.Mapiranja
{
    public class Dinarski_racunMapiranja : ClassMap<ProjekatBaze2.Entiteti.Dinarski_racun>
    {
        public Dinarski_racunMapiranja()
        {
            Table("DINARSKI_RACUN");
            

            UseUnionSubclassForInheritanceMapping();

            Id(x => x.Id, "BROJRACUNA").GeneratedBy.SequenceIdentity("DINARSKI_SEQ");

            Map(x => x.DatumOtvaranja, "DATUMOTVARANJA");
            Map(x => x.Saldo, "SALDO");
            HasMany(x => x.Dinarski_Racun_Lica).KeyColumn("BROJRACUNA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Debitne_kartice).KeyColumn("DINARSKI_BR_RAC").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Kreditne_kartice).KeyColumn("DINARSKI_BR_RAC").LazyLoad().Cascade.All().Inverse();

            References(x => x.RacunBanka).Column("JEDBRBANKE").LazyLoad();
        }
    }
}
