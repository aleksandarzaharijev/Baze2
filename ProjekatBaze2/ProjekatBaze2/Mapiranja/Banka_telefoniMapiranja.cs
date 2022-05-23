using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class Banka_telefoniMapiranja : ClassMap<ProjekatBaze2.Entiteti.Banka_telefoni>
    {
        public Banka_telefoniMapiranja()
        {
            //Mapiranja
            Table("BANKA_TELEFONI");

            Id(x => x.Id, "IDBANKATELEFONI").GeneratedBy.TriggerIdentity();

            Map(x => x.Broj_Telefona, "BROJTELEFONA");
            //dodat je neki komentar


        }

    }
}
