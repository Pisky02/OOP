public class Elipsa : Objekt2D
{
    public double A { get; }
    public double B { get; }
    public Elipsa(double a, double b) { A = a; B = b; }
    public override double Plocha() => Math.PI * A * B;
    public override string ToString() => $"Elipsa(a={A}, b={B}, plocha={Plocha():F3})";
}
