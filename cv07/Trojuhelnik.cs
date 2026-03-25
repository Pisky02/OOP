public class Trojuhelnik : Objekt2D
{
    public double Zakladna { get; }
    public double Vyska { get; }
    public Trojuhelnik(double zakladna, double vyska) { Zakladna = zakladna; Vyska = vyska; }
    public override double Plocha() => 0.5 * Zakladna * Vyska;
    public override string ToString() => $"Trojuhelnik(zakl={Zakladna}, vysk={Vyska}, plocha={Plocha():F3})";
}
