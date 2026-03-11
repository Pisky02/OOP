public class Osobni : Auto
{
    public int MaxOsob { get; private set; }

    private int prepravovaneOsoby;
    public int PrepravovaneOsoby
    {
        get { return prepravovaneOsoby; }
        set
        {
            if (value > MaxOsob)
            {
                throw new InvalidOperationException($"Nelze nastavit počet přepravovaných osob na {value}, překračuje maximální kapacitu {MaxOsob}.");
            }
            prepravovaneOsoby = value;
        }
    }

    public Osobni(double velikostNadrze, TypPaliva palivo, int maxOsob) : base(velikostNadrze, palivo)
    {
        MaxOsob = maxOsob;
        PrepravovaneOsoby = 0;
    }

    public override string ToString()
    {
        return $"[Osobní Auto] Palivo: {Palivo}, Nádrž: {StavNadrze}/{VelikostNadrze} l, Osoby: {PrepravovaneOsoby}/{MaxOsob}, Radio: {Radio}";
    }

}