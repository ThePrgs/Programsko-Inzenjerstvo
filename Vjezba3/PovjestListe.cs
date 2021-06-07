using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba3
{
    public class PovjestListe
    {
        public decimal kune;
        public decimal euri;
        public static List<PovjestListe> povjest = new List<PovjestListe>();
        
        public PovjestListe(decimal kune, decimal euri)
        {
            this.kune = kune;
            this.euri = euri;
        }
    }
}
