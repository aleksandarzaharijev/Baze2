using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Banka
    {
        public virtual int Id { get; set; }
        public virtual string AdresaCentrale { get; set; }
        public virtual string WebAdresa { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Email { get; set; }   
        public virtual IList<Devizni_racun> Devizni_Racuni { get; set; }
        public virtual IList<Dinarski_racun> Dinarski_Racuni { get; set; }
        public virtual IList<Banka_telefoni> Banka_Telefoni { get; set; }
        public virtual IList<Filijala> Lista_Filijala { get; set; }

        

        public Banka ()
        {
            Devizni_Racuni = new List<Devizni_racun>();
            Dinarski_Racuni = new List<Dinarski_racun>();
            Banka_Telefoni = new List<Banka_telefoni>();
            Lista_Filijala = new List<Filijala>();
        }
    }
}
