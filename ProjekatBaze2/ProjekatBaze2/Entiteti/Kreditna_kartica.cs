using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Kreditna_kartica
    {

        public virtual int Id { get; set; }
        public virtual DateTime Datum_izdavanja { get; set; }
        public virtual DateTime Datum_isteka_vazenja { get; set; }
        public virtual DateTime Rok_vracanja_duga { get; set; }
        public virtual int DnevniLimit { get; set; }
        public virtual int MesecnoZaduzenje { get; set; }
        public virtual IList<Dinarski_racun> Dinarski_Racuni { get; set; }
        public virtual IList<Devizni_racun> Devizni_Racuni { get; set; }

        public Kreditna_kartica()
        {
            Dinarski_Racuni = new List<Dinarski_racun>();

            Devizni_Racuni = new List<Devizni_racun>();
        }
    }
}