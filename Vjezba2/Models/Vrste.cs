using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba2.Models
{
    public class Vrste
    {
        public string naziv;
        public string boja;
        public string velicina;
        public string vrsta;
        public static List<Vrste> vrste = new List<Vrste>();

        public Vrste(string naziv, string boja, string velicina, string vrsta)
        {
            this.naziv = naziv;
            this.boja = boja;
            this.velicina = velicina;
            this.vrsta = vrsta;
           
        }

        





    }
}
