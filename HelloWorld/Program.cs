using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        /*
         * A Console.WriteLine idézőjeleibe a program futtatása során az automatikusan megjelenítendő szöveget írjuk bele.
         * A ( és ) a FÜGGVÉNYEK zárójele.
         * A string típusú VÁLTOZÓ képes egy karakterláncot eltárolni (pl. egy betűt, több szót, mondatokat akár, stb.).
         * A Console.ReadLine a konzolról kapott adatokat olvassa az ENTER lenyomásáig. Ha nem tároljuk változóban, akkor az adatok elvésznek.
         */

        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
            Console.WriteLine("Szia, add meg a vezetéknevedet!");
            string vezetekNev = Console.ReadLine();
            Console.WriteLine("Most add meg a keresztnevedet!");
            string keresztNev = Console.ReadLine();
            Console.WriteLine("Végül add meg az utónevedet, ha van! Amennyiben nincs, úgy, kérlek, hagyd üresen a területet!");
            string utoNev = Console.ReadLine();
            Console.WriteLine("A neved: " + vezetekNev + " " + keresztNev + " " + utoNev);
            Console.ReadLine();
            Console.WriteLine("Szia, " + vezetekNev + " " + keresztNev + " " + utoNev);
            Console.ReadLine();
            #endregion
        }
    }
}
