using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Trojuhelnik : Objekt2D
    {
        private double stranaA;
        private double stranaB;
        private double stranaC;

        public Trojuhelnik(double a, double b, double c)
        {
            stranaA = a;
            stranaB = b;
            stranaC = c;
        }

        public override double SpoctiPlochu()
        {
            double s = (stranaA + stranaB + stranaC) / 2;
            return Math.Sqrt(s*(s-stranaA)*(s-stranaB)*(s-stranaC));
        }

        public override void Kresli()
        {
            Console.WriteLine("Trojuhelnik:\na = {0}, b = {1}, c = {2}              S = {3:0.00}", stranaA, stranaB, stranaC, SpoctiPlochu());
        }
    }
}
