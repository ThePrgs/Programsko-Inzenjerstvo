using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba6
{
    public class Enumeracija
    {
        public enum StatusProjekta
        {
            NemaRijeci,
            ImaRijeci,
            ImaRijeciZaPrijevod,
            ImaViseRijeciZaPrijevod,
            RijecNijePrevedena,
            RijecPrevedena
        }

        public enum Dogadjaj
        {
            RijecUnesena,
            RijecUpisanaZaPrijevod,
            PrijevodManjeOdJedneRijeci,
            RijecNePostoji,
            PrijevodRijeci
        }
    }
}
