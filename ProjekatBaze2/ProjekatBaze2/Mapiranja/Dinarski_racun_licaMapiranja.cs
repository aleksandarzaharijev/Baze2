using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ProjekatBaze2.Mapiranja
{
    public class Dinarski_racun_licaMapiranja:ClassMap<ProjekatBaze2.Entiteti.Dinarski_racun_lica>
    {
        public Dinarski_racun_licaMapiranja()
        {

            Id(x => x.Id, "IDDROL").GeneratedBy.TriggerIdentity();

            Map(x => x.Imena_Lica, "IMENA_LICA");
        }
    }
}
