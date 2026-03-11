public class Autoradio 
{
    public double NaladenyKmitocet { get; private set; }
    public bool RadioZapnuto { get; set; }

    private Dictionary<int, double> predvolby = new Dictionary<int, double>(); 

    public void NastavPredvolbu(int cislo, double kmitocet)
    {
        predvolby[cislo] = kmitocet;
    }

    public void PreladNaPredvolbu(int cislo)
    {
        if (predvolby.ContainsKey(cislo))
        {
            NaladenyKmitocet = predvolby[cislo];
        }
        else
        {
            throw new ArgumentException($"Předvolba číslo {cislo} není nastavena.");   
        }
    }

    public override string ToString()
    {
        return RadioZapnuto ? $"Zapnuto (Frekvence: {NaladenyKmitocet} MHz)" : "Vypnuto";
    }
}