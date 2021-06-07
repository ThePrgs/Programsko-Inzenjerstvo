using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vjezba6.Enumeracija;

namespace Vjezba6
{
    public class Prijelaz
    {
        
        public Dogadjaj Dogadjaj { get; set; }
        
        public StatusProjekta Status { get; set;}

        public Prijelaz(StatusProjekta statusProjekta, Dogadjaj aktivacijskiDogadjaj)
        {
            Status = statusProjekta;
            Dogadjaj = aktivacijskiDogadjaj;

        }


    }
}
