using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba2.Models;

namespace Vjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Dodaj vrstu odjece");
                Console.WriteLine("2. Dodaj komad odjece");
                Console.WriteLine("3. Prikazi svu odjecu");
                Console.WriteLine("4. Prikazi po velicini i vrsti");
                Console.WriteLine("5. Prikazi po boji i vrsti");
                Console.WriteLine("9. Izlaz");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor) {
                    case 1:
                        Console.WriteLine("Upisi naziv vrste");
                        string naziv = Console.ReadLine();
                        Odjeca.DodajVrstu(naziv);
                        break;

                    case 2:
                        Console.WriteLine("Unesi naziv komada");
                        string nazivk = Console.ReadLine();
                        Console.WriteLine("Unesi boju komada");
                        string boja = Console.ReadLine();
                        Console.WriteLine("Unesi velicinu komada");
                        string velicina = Console.ReadLine();
                        Console.WriteLine("Unesi vrstu");
                        string vrsta = Console.ReadLine();
                        Odjeca.DodajKomadOdjece(nazivk, boja, velicina, vrsta);
                        break;

                    case 3:
                        Odjeca.PrikaziSvuOdjecu();
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Unesi vrstu komada");
                        string vrsta1 = Console.ReadLine();
                        Console.WriteLine("Unesi velicinu komada");
                        string vel = Console.ReadLine();
                        Odjeca.PrikaziVelicinaOdjecu(vrsta1, vel);
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Unesi vrstu komada");
                        string vrsta2 = Console.ReadLine();
                        Console.WriteLine("Unesi boju komada");
                        string boj = Console.ReadLine();
                        Odjeca.PrikaziBojaOdjecu(vrsta2, boj);
                        Console.ReadLine();
                        break;


                }
            } while (izbor != 9);
        }
    }
}
