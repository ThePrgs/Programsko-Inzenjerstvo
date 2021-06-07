using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba2.Models
{
    public class Odjeca
    {
        public string naziv;
        public static List<Odjeca> odjeca = new List<Odjeca>();
        public static List<Vrste> vrsteo = new List<Vrste>();
        public Odjeca(string naziv)
        {
            this.naziv = naziv;
        }

        public static void DodajVrstu(string naziv)
        {
            foreach (Odjeca item in odjeca)
            {
                if(item.naziv == naziv)
                {
                    Console.WriteLine("Vec postoji");
                    return;
                }

            }
            Odjeca odjeca1 = new Odjeca(naziv);
            odjeca.Add(odjeca1);
            
        }

        public static void DodajKomadOdjece(string naziv, string boja, string velicina, string vrsta)
        {
            foreach (Odjeca item in odjeca)
            {
                if(item.naziv == vrsta)
                {
                
                    Vrste marka1 = new Vrste(naziv, boja, velicina, vrsta);
                    vrsteo.Add(marka1);
                    return;
                }

            }
            Console.WriteLine("Nema te vrste");
            return;

        }

        public static void PrikaziSvuOdjecu()
        {
            foreach (Vrste item in vrsteo)
            {

                Console.WriteLine("Naziv: " + item.naziv + " Boja: " + item.boja + " Velicina: " + item.velicina + " Vrsta: " + item.vrsta);

            }
        }

        public static void PrikaziVelicinaOdjecu(string vrsta ,string velicina)
        {
            foreach (Vrste item in vrsteo)
            {
                if((vrsta == item.vrsta) && (velicina == item.velicina))
                {
                    Console.WriteLine("Naziv: " + item.naziv + " Boja: " + item.boja + " Velicina: " + item.velicina + " Vrsta: " + item.vrsta);
                   
                }
            }
            
        }

        public static void PrikaziBojaOdjecu(string vrsta, string boja)
        {
            foreach (Vrste item in vrsteo)
            {
                if ((vrsta == item.vrsta) && (boja == item.boja))
                {
                    Console.WriteLine("Naziv: " + item.naziv + " Boja: " + item.boja + " Velicina: " + item.velicina + " Vrsta: " + item.vrsta);
                  
                }

            }
         
        }
    }
}
