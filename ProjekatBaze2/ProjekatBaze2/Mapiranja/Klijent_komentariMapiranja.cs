using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class Klijent_komentariMapiranja : ClassMap<ProjekatBaze2.Entiteti.Klijent_komentari>
    {
        public Klijent_komentariMapiranja()
        {
            Table("KLIJENT_KOMENTARI");

            Id(x => x.Id, "IDKLIJENTKOMENTARI").GeneratedBy.TriggerIdentity();

            Map(x => x.Dodatni_komentar, "DODATNIKOMENTARI");
        }
    }
}
