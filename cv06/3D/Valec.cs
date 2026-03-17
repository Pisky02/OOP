using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Valec : Objekt3D
    {
        private double polomer;
        private double vyska;

        public Valec(double r, double v)
        {
            polomer = r;
            vyska = v;
        }

        public override double SpoctiObjem()
        {
            return Math.PI * polomer * polomer * vyska;
        }

        public override double SpoctiPovrch()
        {
            return 2 * Math.PI * polomer * (polomer + vyska);
        }

        public override void Kresli()
        {
            Console.WriteLine("Valec:\nr = {0}, v = {1}              S = {2:0.00}, V = {3:0.00}", polomer, vyska, SpoctiPovrch(), SpoctiObjem());
        }
    }
}
