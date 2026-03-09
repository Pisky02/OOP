//BPC - OOP – 5.Cvičení
//2. Vytvořte základní třídu Auto a z něj odvozené třídy Nakladni a Osobni.
//3. Vytvořte v třídě Auto vnořený výčtový typ TypPaliva, který bude reprezentovat typ paliva (Benzin, Nafta).
//4. Vhodně rozdělte následující členy do výše uvedených tříd dle pravidel OOP.
    //Odhadněte které členy jsou společné a které jsou spíše specifické pro daný typ vozidla.
    
    //Vlastnosti:
    //VelikostNadrze, StavNadrze, Palivo, MaxOsob, MaxNaklad, PrepravovanyNaklad, PrepravovaneOsoby.
    //U vlastností, které by se zvenku neměly měnit nastavte set na private nebo protected.
    //Kontrolujte nastavení vlastností PrepravovanyNaklad a PrepravovaneOsoby a v případě pokusu o nastavení vyšší hodnoty vyvolejte výjimku.
    //Přidejte metodu Natankuj s argumenty typPaliva a mnozstvi, která zvýší StavNadrze a
    //v případě, že by měla přetéct nebo při pokusu o natankování nesprávného paliva vyvolejte výjimku.

//5. Vytvořte konstruktory odvozených tříd s argumenty, které budou nastavovat vlastnosti, které
    //jsou pevně dané (jako např. MaxOsob) a budou inicializovat vlastnosti, které se mohou měnit (jako např. inicializace PrepravovaneOsoby na hodnotu 0).

//6. Vytvořte třídu Autoradio. Zakomponujte následující členy s využitím znalostí o zapouzdření.
    //Vlastnosti: NaladenyKmitocet a RadioZapnuto.Metody:
    //NastavPredvolbu s argumenty cislo a kmitocet (interně si předvolby ukládejte do privátního členu typu Dictionary<int, double>)
    //a metodu PreladNaPredvolbu s argumentem cislo (tato nastaví NaladenyKmitocet na předem uloženou hodnotu z NastavPredvolbu).
//7. Zakomponujte pomocí vhodného vztahu Autoradio do Auto a zveřejněte potřebné členy.
//8. Do tříd Nakladni, Osobni a Autoradio doplňte metodu ToString, která bude zobrazovat
    //informace o stavu objektu (u aut např. stav nádrže, počet osob nebo nákladu atd.)
//9. Do metody Main napište ukázku na použití výše uvedených odvozených tříd (základní třídy
    //neinstancujte), nastavení a čtení jejich vlastností a provolání metod. Případné výjimky
    //zachyťte a zobrazte. Stav zobrazujte pomocí provolání ToString.