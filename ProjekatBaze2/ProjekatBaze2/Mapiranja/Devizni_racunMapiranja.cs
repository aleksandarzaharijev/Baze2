using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{  /// <summary>
/// alternativa B
/// </summary>
    public class Devizni_racunMapiranja : ClassMap<ProjekatBaze2.Entiteti.Devizni_racun>
    {
        public Devizni_racunMapiranja()
        {
            Table("DEVIZNI_RACUN");
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.Id, "BROJRACUNA").GeneratedBy.SequenceIdentity("DEVIZNI_SEQ");

            Map(x => x.DatumOtvaranja, "DATUMOTVARANJA");
            Map(x => x.Saldo, "SALDO");
            Map(x => x.Valuta, "VALUTA");

            HasMany(x => x.Devizni_Racun_Lica).KeyColumn("BROJRACUNA").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.Debitne_kartice).KeyColumn("DEVIZNI_BR_RAC").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Kreditne_kartice).KeyColumn("DEVIZNI_BR_RAC").LazyLoad().Cascade.All().Inverse();
        }
    }
}