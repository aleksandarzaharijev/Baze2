using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Dinarski_racun
    {
        public virtual long Id { get; set; }

        public virtual DateTime DatumOtvaranja { get; set; }

        public virtual int Saldo { get; set; }

        public virtual IList<Dinarski_racun_lica> Dinarski_Racun_Lica { get; set; }

        public virtual IList<Debitna_kartica> Debitne_kartice { get; set; }

        public virtual IList<Kreditna_kartica> Kreditne_kartice { get; set; }

        public virtual Banka RacunBanka { get; set; }

        public virtual Klijent RacunKlijent { get; set; }

        //public virtual IList>

        public Dinarski_racun()
        {
            Dinarski_Racun_Lica = new List<Dinarski_racun_lica>();
            Debitne_kartice = new List<Debitna_kartica>();
            Kreditne_kartice = new List<Kreditna_kartica>();
        }
    }
}
