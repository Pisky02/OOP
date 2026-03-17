//1.Vytvořte nový projekt podle šablony „Console App“. Target Framework zvolte .NET 8.0.
//2.Vytvořte abstraktní základní třídu GrObjekt a z něj odvozené abstraktní třídy Objekt2D a Objekt3D.
//3. Vytvořte polymorfní rozhraní v GrObjekt.
//Bude definováno bezargumentovou metodou bez návratové hodnoty s názvem Kresli.
//4. Vytvořte polymorfní rozhraní v Objekt2D.
//Bude definováno bezargumentovou metodou s návratovou hodnotou typu double a názvem SpoctiPlochu.
//5. Vytvořte polymorfní rozhraní v Objekt3D. Bude definováno dvěma bezargumentovými metodami s návratovou hodnotou typu double a názvy SpoctiPovrch a SpoctiObjem.
//6. Vytvořte třídy: Kruh, Obdelnik, Elipsa, Trojuhelnik, Kvadr, Valec, Koule a Jehlan odvozené
//z Objekt2D či Objekt3D. Vytvořte nezbytné datové členy popisující rozměry objektu a
//vytvořte konstruktory, které tyto datové členy naplní. Ve třídách pak implementujte metody
//požadované polymorfním rozhraním.
//7. Pozn.: Metoda Kresli bude pro jednoduchost psát na konzolu např. text typu: „Valec(r = 1, 54; v = 5,41)“
//8.Do metody Main napište ukázku naplnění pole typů GrObjekt konkrétními grafickými
//objekty. Procházejte pole, provolávejte metodu Kresli a s využitím operátoru is sečtěte
//celkovou plochu, celkový povrch a celkový objem.

using cv06;

GrObjekt[] objekty =
    {
        new Kruh(3),
        new Obdelnik(4, 5),
        new Elipsa(2, 6),
        new Trojuhelnik(3, 4, 5),

        new Kvadr(2, 3, 4),
        new Valec(1.5, 5),
        new Koule(2.2),
        new Jehlan(3, 4)
    };

double celkovaPlocha = 0;
double celkovyPovrch = 0;
double celkovyObjem = 0;

foreach (var obj in objekty)
{
    obj.Kresli();

    if (obj is Objekt2D o2d)
    {
        celkovaPlocha += o2d.SpoctiPlochu();
    }

    if (obj is Objekt3D o3d)
    {
        celkovyPovrch += o3d.SpoctiPovrch();
        celkovyObjem += o3d.SpoctiObjem();
    }
}

Console.WriteLine(Environment.NewLine);
Console.WriteLine($"Celková plocha 2D objektů: {celkovaPlocha}");
Console.WriteLine($"Celkový povrch 3D objektů: {celkovyPovrch}");
Console.WriteLine($"Celkový objem 3D objektů: {celkovyObjem}");
