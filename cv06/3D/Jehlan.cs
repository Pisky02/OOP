using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Jehlan : Objekt3D
    {
        private double strana;
        private double vyska;

        public Jehlan(double a, double v)
        {
            strana = a;
            vyska = v;
        }

        public override double SpoctiObjem()
        {
            return (1.0 / 3.0) * strana * strana * vyska;
        }   

        public override double SpoctiPovrch()
        {
            double stranaS = Math.Sqrt(Math.Pow(strana / 2, 2) + Math.Pow(vyska, 2));
            return strana * strana + 2 * strana * stranaS;
        }

        public override void Kresli()
        {
            Console.WriteLine("Jehlan:\na = {0}, v = {1}              S = {2:0.00}, V = {3:0.00}", strana, vyska, SpoctiPovrch(), SpoctiObjem());
        }
    }
}
