int[] ints = { 1, 3, 5, 7, 9 };
string[] strings = { "pes", "kocka", "e", "popokatepetl" };

Kruh[] kruhy = { new Kruh(1), new Kruh(2.5), new Kruh(0.7) };
Obdelnik[] obdelniky = { new Obdelnik(2, 3), new Obdelnik(5, 1), new Obdelnik(4, 4) };

Objekt2D[] objekty = {
            new Kruh(1.2),
            new Obdelnik(2,2),
            new Elipsa(1,2),
            new Trojuhelnik(3,4),
            new Ctverec(2.5)
        };

Console.WriteLine("Int - nejvetsi: " + Extremy.Nejvetsi(ints));
Console.WriteLine("Int - nejmensi: " + Extremy.Nejmensi(ints));

Console.WriteLine("String - nejvetsi: " + Extremy.Nejvetsi(strings));
Console.WriteLine("String - nejmensi: " + Extremy.Nejmensi(strings));

Console.WriteLine("Kruhy - nejvetsi: " + Extremy.Nejvetsi(kruhy));
Console.WriteLine("Kruhy - nejmensi: " + Extremy.Nejmensi(kruhy));

Console.WriteLine("Obdelniky - nejvetsi: " + Extremy.Nejvetsi(obdelniky));
Console.WriteLine("Obdelniky - nejmensi: " + Extremy.Nejmensi(obdelniky));

Console.WriteLine("Objekty - nejvetsi: " + Extremy.Nejvetsi(objekty));
Console.WriteLine("Objekty - nejmensi: " + Extremy.Nejmensi(objekty));

var filtrovane = ints.Where(x => x >= 4 && x <= 8);
Console.WriteLine("Filtrovane (4 az 8): " + string.Join(", ", filtrovane));
