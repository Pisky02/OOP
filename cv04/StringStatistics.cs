//2. Vytvořte vlastní třídu StringStatistics pro statistické vyhodnocování řetězců. Vytvořte
//konstruktor s jedním argumentem typu string.
//3. Vytvořte metody vracející počet slov, počet řádků, počet vět, pole nejdelších slov, pole
//nejkratších slov, pole nejčetnějších slov a setříděné pole slov dle abecedy. Pro rozdělení na
//slova zohledněte existenci interpunkčních znamének v textu. Konec řádku je reprezentován
//znakem \n. Konec věty identifikujte jako tečku, vykřičník či otazník, za nimiž následuje velké
//písmeno nebo konec řetězce.
using System.Runtime.CompilerServices;

class StringStatistics
{


    private string text;
    public StringStatistics(string text)
    {
        this.text = text;
    }

    //metoda pro rozdeleni textu na slova/vetz/radky, pouzivam ji v vice metodach, proto je private
    private string[] Rozdelit(char[] oddelovace, string text)
    {
        return text.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);
    }

    public string[] Slova()
    {
        char[] oddelovace = new char[] { ' ', '\n', '\t', '.', ',', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}', '"', '\'' };
        return Rozdelit(oddelovace, text);
    }
    public int PocetSlov()
    {
        return Slova().Length;
    }
    public int PocetRadku()
    {
        char[] oddelovace = new char[] { '\n' };
        return Rozdelit(oddelovace, text).Length;
    }
    public int PocetVet()
    {
        //string test = "12345";
        //Console.WriteLine(test.Length);
        string bezMezer = this.text; //prace s kopii textu, abych nemodifikoval original
        bezMezer = bezMezer.Replace(" ", ""); //odstraneni mezer 
        bezMezer = bezMezer.Replace("\n", ""); //odstraneni radku
        //Console.WriteLine(Environment.NewLine) ;
        //Console.WriteLine(text);
        for (int i = 0; i < bezMezer.Length-1; i++)
        {
            //kontrola pro zamezeni spolecneho pouziti tecky a vykricniku/otazniku v zkratce
            if ((bezMezer[i] == '.' || bezMezer[i] == '!' || bezMezer[i] == '?' ) && char.IsLower(bezMezer[i + 1]))
            {
                bezMezer = bezMezer.Remove(i, 1); //odstraneni tecky ze zkratky
            }
        }
        char[] oddelovace = new char[] { '.', '!', '?' };
        return Rozdelit(oddelovace, bezMezer).Length; 

    }
    public string[] NejdelsiSlova()
    {
        string[] slova = Slova();
        int maxLen = 0;
        int count = 0;
        //najdu delku nejdelsich slov
        for (int i = 0; i < slova.Length; i++)
        {
            if( slova[i].Length > maxLen)
                maxLen = slova[i].Length;
        }
        //zjistim kolik jich je a vytvorim pole pro nejdelsi slova
        for (int j = 0; j < slova.Length; j++)
        {
            if(slova[j].Length == maxLen)
            {
                count++;
            }
        }
        //vytvorim pole velikosti count a vlozim do nej ty nejdelsi slova
        string[] nejdelsiSlova = new string[count];
        int index = 0;
        for (int k = 0; k < slova.Length; k++)
        {
            if (slova[k].Length == maxLen)
            {
                nejdelsiSlova[index] = slova[k];
                index++;
            }
        }
        return nejdelsiSlova; 
    }
    public string[] NejkratsiSlova()
    {
        string[] slova = Slova();
        int minLen = slova[0].Length; //vezmu delku prvniho slova jako pocatecni minimum
        int count = 0;
        //najdu nejmensi slovo
        for (int i = 0; i < slova.Length; i++)
        {
            if (slova[i].Length < minLen)
                minLen = slova[i].Length;
        }
        //zjistim kolik jich je a vytvorim pole pro nejdelsi slova
        for (int j = 0; j < slova.Length; j++)
        {
            if (slova[j].Length == minLen)
            {
                count++;
            }
        }
        //vytvorim pole velikosti count a vlozim do nej ty nejdelsi slova
        string[] nejkratsiSlova = new string[count];
        int index = 0;
        for (int k = 0; k < slova.Length; k++)
        {
            if (slova[k].Length == minLen)
            {
                nejkratsiSlova[index] = slova[k];
                index++;
            }
        }
        return nejkratsiSlova;
    }
    public string[] NejcastejsiSlova() 
    {
        string[] slova = Slova();
        string[,] slovnik = new string[slova.Length, 2];
        
        for (int i = 0; i < slova.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (slova[i] == slovnik[j, 0])
                {
                    int pocet = 0;
                    int.TryParse(slovnik[j, 1], out pocet);
                    pocet++;
                    slovnik[j, 1] = pocet.ToString();
                    break;
                }
            }
            slovnik[i, 0] = slova[i];
        }

        int maxPocet = 0;
        for (int k = 0; k < slova.Length; k++)
        {
            if (!string.IsNullOrEmpty(slovnik[k, 1]))
            {
                int pocet = int.Parse(slovnik[k, 1]);
                if (pocet > maxPocet) maxPocet = pocet;
            }
        }

        int count = 0;
        for (int k = 0; k < slova.Length; k++)
        {
            if (!string.IsNullOrEmpty(slovnik[k, 1]))
            {
                int pocet = int.Parse(slovnik[k, 1]);
                if (pocet == maxPocet) count++;
            }
        }
        string[] nejcastejsiSlova = new string[count];
        int index = 0;
        for (int k = 0; k < slova.Length; k++)
        {
            if (!string.IsNullOrEmpty(slovnik[k, 1]))
            {
                int pocet = int.Parse(slovnik[k, 1]);
                if (pocet == maxPocet)
                {
                    nejcastejsiSlova[index] = slovnik[k, 0];
                    index++;
                }
            }
        }
        return nejcastejsiSlova;
    }




    public string[] PodleAbecedy()
    {
        string [] slova = Slova();
        slova = slova.Order().ToArray(); //serazeni pole podle abecedy
        return slova;
    }   
}
