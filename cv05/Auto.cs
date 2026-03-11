public class Auto
{
    public enum TypPaliva { Benzin, Nafta }

    public double VelikostNadrze { get; protected set; }
    public double StavNadrze { get; private set; }
    public TypPaliva Palivo { get; protected set; }

    private Autoradio autoradio;
    public Autoradio Radio => autoradio;
    public Auto( double velikostNadrze, TypPaliva palivo) { 
        autoradio = new Autoradio();
        VelikostNadrze = velikostNadrze;
        Palivo = palivo;
        StavNadrze = 0;
    }


    public void Natankuj(TypPaliva typPaliva, double mnozstvi)
    {
        if (typPaliva != Palivo)
        {
            throw new ArgumentException($"Nesprávný typ paliva. Očekáváno: {Palivo}, ale bylo zadáno: {typPaliva}.");
        }
        if (StavNadrze + mnozstvi > VelikostNadrze)
        {
            throw new InvalidOperationException("Nelze natankovat, nádrž by přetekla.");
        }
        StavNadrze += mnozstvi;
    }
}