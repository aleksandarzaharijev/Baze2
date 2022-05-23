using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public  class Klijent
    {
        public virtual int Id { get; set; }

        public virtual string Naziv{ get; set; }

        public virtual string Adresa{ get; set; }

        public virtual string Email { get; set; }

        public virtual string Broj_Telefona { get; set; }

        public virtual IList<Klijent_komentari> Klijent_Komentari { get; set; }

        public virtual IList<Pravna_lica> Pravna_Lica { get; set; }

        public virtual IList<Fizicka_lica> Fizicka_Lica { get; set; }

        public virtual IList<Devizni_racun> Devizni_Racuni { get; set; }

        public virtual IList<Dinarski_racun> Dinarski_Racuni { get; set; }

        public Klijent()
        {
            Klijent_Komentari = new List<Klijent_komentari>();

            Pravna_Lica = new List<Pravna_lica>();

            Fizicka_Lica = new List<Fizicka_lica>();

            Devizni_Racuni = new List<Devizni_racun>();

            Dinarski_Racuni = new List<Dinarski_racun>();
        }
    }
}
