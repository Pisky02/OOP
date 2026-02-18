class Complex
{
    public double Realna;
    public double Imaginarni;

    public Complex(double realna = 0.0, double imaginarni  = 0.0)
    {
        Realna = realna;
        Imaginarni = imaginarni;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Realna + b.Realna, a.Imaginarni + b.Imaginarni);
    }
    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Realna - b.Realna, a.Imaginarni - b.Imaginarni);
    }
    public static Complex operator -(Complex a)
    {
        return new Complex(-a.Realna, -a.Imaginarni);
    }
    public static bool operator ==(Complex a, Complex b)
    {
        return a.Realna == b.Realna && a.Imaginarni == b.Imaginarni;
    }
    public static bool operator !=(Complex a, Complex b)
    {
        return !(a==b);
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

    public override string ToString()
    {
        if (Imaginarni < 0)
        {
            return String.Format("{0}-{1}j", Realna, -Imaginarni);
        }
        else
        {
            return String.Format("{0}+{1}j", Realna, Imaginarni);
        }
    }

    public Complex Sdruzene()
    {
        return new Complex (Realna, -Imaginarni);
    }
}

