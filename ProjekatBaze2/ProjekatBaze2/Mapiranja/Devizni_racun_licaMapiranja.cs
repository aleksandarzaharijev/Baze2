using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class Devizni_racun_licaMapiranja : ClassMap<ProjekatBaze2.Entiteti.Devizni_racun_lica>
    {
        public Devizni_racun_licaMapiranja()
        {
            Table("DEVIZNI_RACUN_OVLASCENA_LICA");

            Id(x => x.Id, "IDDROL").GeneratedBy.TriggerIdentity();

            Map(x => x.Imena_Lica, "IME_LICA");

            References(x => x.Devizni_Racun).Column("BROJRACUNA").LazyLoad();
        }
    }
}