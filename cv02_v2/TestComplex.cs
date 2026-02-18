
class TestComplex
{
    private const double Epsilon = 1E-6;
    public static void Test(Complex skutecna, Complex ocekavana, string nazev)
    {
        if(Math.Abs(skutecna.Realna - ocekavana.Realna) < Epsilon && Math.Abs(skutecna.Imaginarni - ocekavana.Imaginarni) < Epsilon)
        {
            Console.WriteLine("Test {0} : OK.", nazev);
        }
        else
        {
            Console.WriteLine("Test {0} : Chyba. Ocekavano: {1}, Skutecne: {2}", nazev, ocekavana, skutecna);
        }
    }
}

