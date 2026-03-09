//1.Vytvořte nový projekt podle šablony „Console App“. Target Framework zvolte .NET 8.0.
//2. Vytvořte vlastní třídu StringStatistics pro statistické vyhodnocování řetězců. Vytvořte
//konstruktor s jedním argumentem typu string.
//3. Vytvořte metody vracející počet slov, počet řádků, počet vět, pole nejdelších slov, pole
//nejkratších slov, pole nejčetnějších slov a setříděné pole slov dle abecedy. Pro rozdělení na
//slova zohledněte existenci interpunkčních znamének v textu. Konec řádku je reprezentován
//znakem \n. Konec věty identifikujte jako tečku, vykřičník či otazník, za nimiž následuje velké
//písmeno nebo konec řetězce.
//4. V metodě Main inicializujte instanci StringStatistics vzorovým textem textem a provolejte
//jednotlivé metody a výsledky zobrazte na konzoli. Použijte následující vzorový text:

string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
+ "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
+ "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
+ "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
+ "posledni veta!";

StringStatistics statistika = new StringStatistics(testovaciText);
Console.WriteLine(testovaciText);
Console.WriteLine(Environment.NewLine);

Console.WriteLine( "Pocet slov: {0}", statistika.PocetSlov());
Console.WriteLine("Pocet radku: {0}", statistika.PocetRadku());
Console.WriteLine("Pocet vet: {0}", statistika.PocetVet());

Console.WriteLine(Environment.NewLine);
Console.WriteLine("Nejdelsi slova: " );
foreach (string s in statistika.NejdelsiSlova())
{
    Console.WriteLine(s);
}

Console.WriteLine(Environment.NewLine);
Console.WriteLine("Nejkratsi slova:");
foreach (string s in statistika.NejkratsiSlova())
{
    Console.WriteLine(s);
}


Console.WriteLine(Environment.NewLine);
Console.WriteLine("Nejcastejsi slova:");
foreach (string s in statistika.NejcastejsiSlova())
{
    Console.WriteLine(s);
}


Console.WriteLine(Environment.NewLine); 
Console.WriteLine("Serazeni podle abecedy:");
foreach (string s in statistika.PodleAbecedy())
{
    Console.WriteLine(s);
}
