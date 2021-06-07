using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba5
{
    public class Tim
    {
        public string ImeTima;
        public List<string> ImenaIgraca = new List<string>();

        public static List<Tim> PopisTimova = new List<Tim>();

        public Tim(string ime, List<string> igraci)
        {
            this.ImeTima = ime;
            this.ImenaIgraca = igraci;
        }
    }
}
