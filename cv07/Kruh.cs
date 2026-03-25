public class Kruh : Objekt2D
{
    public double Polomer { get; }
    public Kruh(double polomer) => Polomer = polomer;
    public override double Plocha() => Math.PI * Polomer * Polomer;
    public override string ToString() => $"Kruh(r={Polomer}, plocha={Plocha():F3})";
}
