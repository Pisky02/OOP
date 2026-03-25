public abstract class Objekt2D : I2D, IComparable
{
    public abstract double Plocha();

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;
        if (obj is not Objekt2D other)
            throw new ArgumentException("Porovnávaný objekt není typu Objekt2D");

        return Plocha().CompareTo(other.Plocha());
    }
}
