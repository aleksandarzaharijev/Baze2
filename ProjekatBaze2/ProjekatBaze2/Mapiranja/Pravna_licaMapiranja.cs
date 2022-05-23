using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class Pravna_licaMapiranja : SubclassMap<ProjekatBaze2.Entiteti.Pravna_lica>
    {
        public Pravna_licaMapiranja()
        {
            //Mapiranja
            Table("PRAVNA_LICA");

            KeyColumn("JEDIDENTFBROJ");

            Map(x => x.PoreskiBroj, "PORESKIIDENTIFIKACIONIBROJ");
        }
    }
}