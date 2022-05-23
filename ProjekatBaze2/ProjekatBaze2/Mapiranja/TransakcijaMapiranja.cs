using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class TransakcijaMapiranja : ClassMap<ProjekatBaze2.Entiteti.Transakcija>
    { 
        public TransakcijaMapiranja()
        {
            Table("TRANSAKCIJA");

            Id(x => x.Id, "JEDBROJTRANSAKCIJE").GeneratedBy.TriggerIdentity();

            Map(x => x.DatuVremePodizanjaNovca, "DATUMVREMEPODIZANJANOVCA");
            Map(x => x.Iznos, "IZNOS");
        }
    }
}
