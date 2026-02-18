/*
BPC-OOP – 2. Cvičení (nehodnoceno)
1. Vytvořte nový projekt podle šablony „Console App“ (pozor! Nepoužívejte starší „Console App
    (.NET Framework)“). Target Framework zvolte .NET 8.0.
2. Vytvořte vlastní třídu Complex pro práci s komplexními čísly (nepoužívejte Complex z
    System.Numerics). Konstruktor třídy bude mít dva argumenty typu double s reálnou a
    imaginární částí. Hodnoty budou uloženy v členských proměnných Realna a Imaginarni.
    Implementujte operátory +, -, *, /, ==, !=, unární operátor -. Implementujte metodu ToString
    pro zobrazení komplexního čísla na konzoli. Napište metody vracející komplexně sdružené
    číslo, modul a argument.
3. Vytvořte třídu TestComplex se statickou metodou Test se dvěma argumenty Complex
    (budou obsahovat skutečnou a očekávanou hodnotu) a argumentem typu string pro název
    testu. Metoda vypíše na konzoli název testu a OK, když se obě komplexní hodnoty liší o
    hodnotu menší než epsilon, a napíše Chyba: Očekávaná hodnota: …, Skutečná hodnota: …
    v případě chyby (odchylka větší než konstanta Epsilon, kterou nastavíte na 1E-6).
4. Otestujte operátory +, -, *, /, unární operátor - a metodu vracející komplexně sdružené číslo
    z bodu 1. pomocí třídy TestComplex z bodu 2. Vytiskněte výsledky operátorů ==, != a
    výsledky metod modul a argument.*/

Console.WriteLine("Cviceni 2, BPC - OOP\n");

Complex x = new(3, 4);
Complex y = new(5, -6);

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"x+y = {x + y}");
Console.WriteLine($"x-y = {x - y}");
Console.WriteLine($"x*y = {x * y}");
Console.WriteLine($"x/y = {x / y}");
Console.WriteLine($"-x = {-x}");
Console.WriteLine($"x == y = {x == y}");
Console.WriteLine($"x != y = {x != y}\n");
Console.WriteLine($"Sdruzeny x = {x.Sdruzeny()}");
Console.WriteLine($"Sdruzeny y = {y.Sdruzeny()}");
Console.WriteLine($"Modul x = {x.Modul():F2}");
Console.WriteLine($"Modul y = {y.Modul():F2}");
Console.WriteLine($"Argument x = {x.Argument():F2}°");
Console.WriteLine($"Argument y = {y.Argument():F2}°\n");


Complex expected = x + y;
var numericsSum = System.Numerics.Complex.Add(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
Complex actual = new(numericsSum.Real, numericsSum.Imaginary);
TestComplex.Test(actual, expected, "Test operator +");

expected = x - y;
var numericsSub = System.Numerics.Complex.Subtract(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
actual = new(numericsSub.Real, numericsSub.Imaginary);
TestComplex.Test(actual, expected, "Test operator -");

expected = x * y;
var numericsMul = System.Numerics.Complex.Multiply(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
actual = new(numericsMul.Real, numericsMul.Imaginary);
TestComplex.Test(actual, expected, "Test operator *");

expected = x / y;
var numericsDiv = System.Numerics.Complex.Divide(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
actual = new(numericsDiv.Real, numericsDiv.Imaginary);
TestComplex.Test(actual, expected, "Test operator /");

expected = -x;
var numericsNeg = System.Numerics.Complex.Negate(new System.Numerics.Complex(x.Realna, x.Imaginarni));
actual = new(numericsNeg.Real, numericsNeg.Imaginary);
TestComplex.Test(actual, expected, "Test unární operator -");

expected = x.Sdruzeny();
var numericsConj = System.Numerics.Complex.Conjugate(new System.Numerics.Complex(x.Realna, x.Imaginarni));
actual = new(numericsConj.Real, numericsConj.Imaginary);
TestComplex.Test(actual, expected, "Test metoda Sdruzeny");


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
            return new Complex(a.Realna + b.Realna, a.Imaginarni + b.Imaginarni -0.0045);
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
        return ((Math.Atan2(Imaginarni, Realna)*180/Math.PI) % 360 + 360) % 360;
    }

}
class TestComplex
{
    public const double Epsilon = 1E-6;
    public static void Test(Complex actual, Complex expected, string testName)
    {
        Console.WriteLine(testName);
        if (Math.Abs(actual.Realna - expected.Realna) < Epsilon && Math.Abs(actual.Imaginarni - expected.Imaginarni) < Epsilon)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine($"Chyba: Očekávaná hodnota: {expected}, Skutečná hodnota: {actual}");
        }
    }
}