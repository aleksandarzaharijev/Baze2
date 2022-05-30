using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Bankomat
    {
        public virtual int Id { get; set; } 
        public virtual string Lokacija { get; set; }  
        public virtual string NazivProizvodjaca { get; set; }

        public virtual bool Status { get; set; }   
        public virtual DateTime DatumPoslednjegServisa { get; set; }

        public virtual Filijala FilijalaId { get; set; }
        public virtual IList<Bankomat_komentari> Komentari { get; set; }
        public virtual IList<Transakcija> Transakcije { get;  set; }
       // public virtual int BrojFilijala { get; set; }

        public Bankomat()
        {
            Komentari = new List<Bankomat_komentari>();
            Transakcije = new List<Transakcija>();
        }
    }
}
