using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Kruh : Objekt2D
    {
        private double polomer;
        public Kruh(double r)
        {
            polomer = r;
        }

        public override double SpoctiPlochu()
        {
            return Math.PI * polomer * polomer;
        }

        public override void Kresli()
        {
            Console.WriteLine("Kruh:\nr = {0}              S = {1:0.00}", polomer, SpoctiPlochu());
        }
    }
}
