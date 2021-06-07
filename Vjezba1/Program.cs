using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite x: ");
            float x =float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite y: ");
            float y =float.Parse(Console.ReadLine());
            float rezultat = 1;
            float razlomak = 1 / x;

            if (y >= 0)
            {
                for (int i = 0; i < y; i++)
                {
                    if (i == (y - 1))
                    {
                        rezultat = rezultat * x;
                        Console.Write(x);
                        break;
                    }
                    rezultat = rezultat * x;
                    Console.Write(x + " * ");
                }
            }
            else{
                for (int i = 0; i < (y*(-1)); i++)
                {
                    if (i == (((-1)*y) - 1))
                    {
                        rezultat = razlomak * rezultat;
                        Console.Write(razlomak);
                        break;
                    }
                    rezultat = razlomak * rezultat;
                    Console.Write(razlomak + " * ");
                }
            }
            Console.WriteLine(" = " + rezultat);
            Console.Read();
        }
    }
}
