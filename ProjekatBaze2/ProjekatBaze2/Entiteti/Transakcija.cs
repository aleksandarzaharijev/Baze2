using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Transakcija
    {
        public virtual int Id { get; set; }
        public virtual int Iznos { get; set; }
        public virtual DateTime DatuVremePodizanjaNovca { get; set; }
    }
}
