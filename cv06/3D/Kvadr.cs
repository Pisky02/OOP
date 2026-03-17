using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Kvadr : Objekt3D
    {
        private double strana;
        private double vyska;   
        private double hloubka;

        public Kvadr(double a, double b, double c)
        {
            strana = a;
            vyska = b;
            hloubka = c;
        }

        public override double SpoctiObjem()
        {
            return strana * vyska * hloubka;
        }

        public override double SpoctiPovrch()
        {
            return 2 * (strana * vyska + strana * hloubka + vyska * hloubka);
        }

        public override void Kresli()
        {
            Console.WriteLine("Kvadr:\na = {0}, b = {1}, c = {2}              S = {3:0.00}, V = {4:0.00}", strana, vyska, hloubka, SpoctiPovrch(), SpoctiObjem());
        }
    }
}
