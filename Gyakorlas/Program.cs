﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Teglalap
    {
        int a;
        int b;

        public Teglalap(int oldal1, int oldal2)
        {
            a = oldal1;
            b = oldal2;
        }


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
        private int r;

        public Kor(int sugar)//konstruktor
        {
            r = sugar;
        }

        public double KeruletK()
        {
            return 2 * r * Math.PI;
        }

        public double TeruletK()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Irja be a téglalap a oldalát: ");
            int oldal1 = int.Parse(Console.ReadLine());
            Console.Write("Írja be a téglalap b oldalát: ");
            int oldal2 = int.Parse(Console.ReadLine());
            Teglalap t = new Teglalap(oldal1, oldal2);

            Console.WriteLine("Kerülete: {0}", t.Kerulet());
            Console.WriteLine("Területe: {0}", t.Terulet());


            Console.Write("\nÍrja be a kör sugarát: ");
            int sugar = int.Parse(Console.ReadLine());
            Kor k = new Kor(sugar);

            Console.WriteLine("Kerülete: {0}", k.KeruletK());
            Console.WriteLine("Területe: {0}", k.TeruletK());

            Console.ReadKey();

        }
    }
}
