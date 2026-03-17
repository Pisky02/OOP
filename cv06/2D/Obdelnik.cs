using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Obdelnik : Objekt2D
    {
        private double sirka;
        private double vyska;

        public Obdelnik(double a, double b)
        {
            sirka = a;
            vyska = b;
        }

        public override double SpoctiPlochu()
        {
            return sirka * vyska;
        }

        public override void Kresli()
        {
            Console.WriteLine("Obdelnik:\nsirka = {0}, vyska = {1}              S = {2:0.00}", sirka, vyska, SpoctiPlochu());
        }
    }
}
