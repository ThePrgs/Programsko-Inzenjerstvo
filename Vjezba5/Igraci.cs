using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba5
{
    public class Igraci
    {
        public string Ime;
        public string Pozicija;

        public static List<Igraci> IgraciPopis = new List<Igraci>();

        public Igraci(string ime, string pozicija)
        {
            this.Ime = ime;
            this.Pozicija = pozicija;
        }
    }
}
