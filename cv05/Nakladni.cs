public class Nakladni : Auto
{
    public double MaxNaklad { get; protected set; }

    private double prepravovanyNaklad;
    public double PrepravovanyNaklad
    {
        get { return prepravovanyNaklad; }
        set
        {
            if (value > MaxNaklad)
                throw new ArgumentOutOfRangeException("Byla překročena maximální nosnost nákladu!");
            prepravovanyNaklad = value;
        }
    }

    public Nakladni(double velikostNadrze, TypPaliva palivo, double maxNaklad) : base(velikostNadrze, palivo)
    {
        MaxNaklad = maxNaklad;
        PrepravovanyNaklad = 0;
    }

    public override string ToString()
    {
        return $"[Nákladní Auto] Palivo: {Palivo}, Nádrž: {StavNadrze}/{VelikostNadrze} l, Náklad: {PrepravovanyNaklad}/{MaxNaklad} kg, Rádio: {Radio}";
    }
}