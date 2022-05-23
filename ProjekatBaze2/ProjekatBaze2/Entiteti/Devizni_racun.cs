using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Devizni_racun
    {
        public virtual int Id { get; set; }

        public virtual DateTime DatumOtvaranja { get; set; }

        public virtual int Saldo { get; set; }

        public virtual string Valuta { get;   set; }

        public virtual IList<Devizni_racun_lica> Devizni_Racun_Lica { get;   set; }

        public virtual IList<Debitna_kartica> Debitne_kartice { get; set; }

        public virtual IList<Kreditna_kartica> Kreditne_kartice { get; set; }

        public Devizni_racun()
        {
            Devizni_Racun_Lica = new List<Devizni_racun_lica>();
            Debitne_kartice = new List<Debitna_kartica>();
            Kreditne_kartice = new List<Kreditna_kartica>();
        }
    }
}
