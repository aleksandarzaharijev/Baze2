using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Devizni_racun_lica
    {
        public virtual int Id { get; set; }
        public virtual string Imena_Lica { get; set; }
        public virtual Devizni_racun Devizni_Racun { get; set; }
    }
}
