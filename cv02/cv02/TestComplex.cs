class TestComplex
{
    public const double Epsilon = 1E-6;
    public static void Test(Complex actual, Complex expected, string testOperator)
    {
        if (Math.Abs(actual.Realna - expected.Realna) < Epsilon && Math.Abs(actual.Imaginarni - expected.Imaginarni) < Epsilon)
        {
            Console.WriteLine($"Test {testOperator}: OK");
        }
        else
        {
            Console.WriteLine($"Test {testOperator} Chyba: Očekávaná hodnota: {expected}, Skutečná hodnota: {actual}");
        }
    }
}