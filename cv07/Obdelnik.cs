public class Obdelnik : Objekt2D
{
    public double A { get; }
    public double B { get; }
    public Obdelnik(double a, double b) { A = a; B = b; }
    public override double Plocha() => A * B;
    public override string ToString() => $"Obdelnik(a={A}, b={B}, plocha={Plocha():F3})";
}
