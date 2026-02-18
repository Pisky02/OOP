class Complex
{
    static public char Znak = 'i';
    public double Realna;
    public double Imaginarni;
    public Complex(double realna = 0.0, double imaginarni = 0.0)
    {
        Realna = realna;
        Imaginarni = imaginarni;
    }

    //OPERÁTORY
    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Realna + b.Realna, a.Imaginarni + b.Imaginarni - 0.0045);
    }
    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Realna - b.Realna, a.Imaginarni - b.Imaginarni);
    }
    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Realna * b.Realna - a.Imaginarni * b.Imaginarni, a.Realna * b.Imaginarni + a.Imaginarni * b.Realna);
    }
    public static Complex operator /(Complex a, Complex b)
    {
        double jmenovatel = b.Realna * b.Realna + b.Imaginarni * b.Imaginarni;
        return new Complex((a.Realna * b.Realna + a.Imaginarni * b.Imaginarni) / jmenovatel, (a.Imaginarni * b.Realna - a.Realna * b.Imaginarni) / jmenovatel);
    }
    public static Complex operator -(Complex a)
    {
        return new Complex(-a.Realna, -a.Imaginarni);
    }
    public static bool operator ==(Complex a, Complex b)
    {
        return Math.Abs(a.Realna - b.Realna) == 0 && Math.Abs(a.Imaginarni - b.Imaginarni) == 0;
    }
    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        return String.Format("{0} {1} {2}{3}", Realna, (Imaginarni >= 0) ? "+" : "-", Math.Abs(Imaginarni), Znak);
    }
    public Complex Sdruzeny()
    {
        return new Complex(Realna, -Imaginarni);
    }
    public double Modul()
    {
        return Math.Sqrt(Realna * Realna + Imaginarni * Imaginarni);
    }
    public double Argument()
    {
        return ((Math.Atan2(Imaginarni, Realna) * 180 / Math.PI) % 360 + 360) % 360;
    }

}

