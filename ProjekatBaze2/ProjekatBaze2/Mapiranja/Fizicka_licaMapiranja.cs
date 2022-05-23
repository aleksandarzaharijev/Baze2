using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
namespace ProjekatBaze2.Mapiranja
{
    public class Fizicka_licaMapiranja : SubclassMap<ProjekatBaze2.Entiteti.Fizicka_lica>
    {
        public Fizicka_licaMapiranja()
        {
            Table("FIZICKA_LICA");

            KeyColumn("JEDIDENTFBROJ");

            Map(x => x.Ime, "IME");
            Map(x => x.Ime_roditelja, "IMEROD");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.Mesto_Izdavanja, "MESTOIZDAV");
            Map(x => x.Broj_Licne_Karte, "BRLICNEKARTE");
            Map(x => x.Datum_Rodjenja, "DATUMRDOJ");
        }
    }
}