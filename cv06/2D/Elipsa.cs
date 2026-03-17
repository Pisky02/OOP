using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Elipsa : Objekt2D
    {
        private double osaA;
        private double osaB;

        public Elipsa(double a, double b)
        {
            osaA = a;
            osaB = b;
        }

        public override double SpoctiPlochu()
        {
            return Math.PI * osaA * osaB;
        }

        public override void Kresli()
        {
            Console.WriteLine("Ellipsa:\nhlavni poloosa = {0}, vedlejsi poloosa = {1}              S = {2:0.00}", osaA, osaB, SpoctiPlochu());
        }
    }
}
