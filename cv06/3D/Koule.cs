using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Koule : Objekt3D
    {
        private double polomer;

        public Koule(double r)
        {
            polomer = r;
        }

        public override double SpoctiObjem()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(polomer, 3);
        }

        public override double SpoctiPovrch()
        {
            return 4 * Math.PI * Math.Pow(polomer, 2);
        }

        public override void Kresli()
        {
            Console.WriteLine("Koule:\nr = {0}              S = {1:0.00}, V = {2:0.00}", polomer, SpoctiPovrch(), SpoctiObjem());
        }
    }
}
