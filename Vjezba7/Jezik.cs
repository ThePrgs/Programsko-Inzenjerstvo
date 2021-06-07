using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba6
{
    class Jezik
    {
        public string NazivJezika;
        public List<string> Rijeci = new List<string>();

        public static List<Jezik> PopisJezika = new List<Jezik>();

        public static StanjeProjekta Stanje;
        public Jezik(string naziv)
        {
            this.NazivJezika = naziv;
            this.Rijeci = new List<string>();
            Stanje = new StanjeProjekta();
        }

     

        public static string Prijevod(string jezik1, string jezik2, string rijec)
        {
            string returnMe = "";
            string nadjenaRijec="";
            int i = -1;
            foreach (Jezik item in PopisJezika)
            {

                if (item.NazivJezika == jezik1)
                {
                    foreach (string item1 in item.Rijeci)
                    {
                        i++;
                        if (rijec == item1)
                        {
                            nadjenaRijec = rijec;           
                            break;
                        }
                        else
                        {
                            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.RijecNePostoji);
                            nadjenaRijec = rijec;
                           
                        }
                        

                    }
                
                }
               
            }
            
            foreach (Jezik item in Jezik.PopisJezika)
            {
                if (item.NazivJezika == jezik2)
                {
                    if (nadjenaRijec != "")
                    {
                        returnMe += " ";
                        Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.PrijevodRijeci);
                        returnMe += item.Rijeci[i];
                    }
                }

            }
            return returnMe;
        }


    }
}
