using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Filijala
    {
        public virtual int Id { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string BrojTelefona { get; set; }

        public virtual string RadnoVreme { get; set; }


        public virtual IList<Bankomat> Bankomati { get; set; }
        public Filijala()
        {
            Bankomati = new List<Bankomat>();
            
        }
    }
}
