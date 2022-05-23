using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class Kreditna_karticaMapiranja : ClassMap<ProjekatBaze2.Entiteti.Kreditna_kartica>
    {
        public Kreditna_karticaMapiranja()
        {
            Table("KREDITNA_KARTICA");

            Id(x => x.Id, "KARTICA_ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Datum_isteka_vazenja, "DATUM_ISTEKA_VAZENJA");
            Map(x => x.Datum_izdavanja, "DATUM_IZDAVANJA");
            Map(x => x.DnevniLimit, "DNEVNI_LIMIT");
            Map(x => x.Rok_vracanja_duga, "ROK_VRACANJA_DUGA");
            Map(x => x.MesecnoZaduzenje, "MESECNO_ZADUZENJE");

            //HasMany(x => x.Devizni_Racuni).KeyColumn("BROJRACUNA").LazyLoad().Cascade.All().Inverse();
            //HasMany(x => x.Dinarski_Racuni).KeyColumn("BROJRACUNA").LazyLoad().Cascade.All().Inverse();
        }
    }
}