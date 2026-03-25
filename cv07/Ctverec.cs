public class Ctverec : Objekt2D
{
    public double Strana { get; }
    public Ctverec(double strana) { Strana = strana; }
    public override double Plocha() => Strana * Strana;
    public override string ToString() => $"Ctverec(s={Strana}, plocha={Plocha():F3})";
}
