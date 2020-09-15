using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Teglalap
    {
        public int a;
        public int b;

        public int Kerulet()
        {
            return 2 * (a + b);
        }

        public int Terulet()
        {
            return a * b;
        }
    }

    class Kor
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Teglalap t = new Teglalap();

            t.a = 3;
            t.b = 4;

            Console.WriteLine("Kerület: {0}", t.Kerulet());
            Console.WriteLine("Terület: {0}", t.Terulet());

            Console.ReadKey();

        }
    }
}
