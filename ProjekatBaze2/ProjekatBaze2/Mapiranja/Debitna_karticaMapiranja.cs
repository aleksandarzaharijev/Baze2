using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class Debitna_karticaMapiranja : ClassMap<ProjekatBaze2.Entiteti.Debitna_kartica>
    {
        public Debitna_karticaMapiranja()
        {
            Table("DEBITNA_KARTICA");

            Id(x => x.Id, "KARTICA_ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Datum_izdavanja , "DATUM_IZDAVANJA");
            Map(x => x.Datum_isteka_vazenja, "DATUM_ISTEKA_VAZENJA");
            Map(x => x.DnevniLimit, "DNEVNI_LIMIT");

           // HasMany(x => x.Devizni_Racuni).KeyColumn("DEVIZNI_BR_RAC").LazyLoad().Cascade.All().Inverse();

           // HasMany(x => x.Dinarski_Racuni).KeyColumn("DINARSKI_BR_RAC").LazyLoad().Cascade.All().Inverse();
        }
    }
}