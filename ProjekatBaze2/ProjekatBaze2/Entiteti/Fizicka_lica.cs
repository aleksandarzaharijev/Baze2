using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Fizicka_lica : Klijent
    {   
       // public virtual Klijent Veza { get;  set; }

        public virtual string Ime { get;  set; }

        public virtual string Prezime { get; set; }

        public virtual string Ime_roditelja { get; set; }

        public virtual int Broj_Licne_Karte { get;  set; }

        public virtual string Mesto_Izdavanja { get; set; }

        public virtual DateTime Datum_Rodjenja { get;  set; }

        public virtual int JMBG { get;  set; }

    }

}
