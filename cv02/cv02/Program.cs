/*
BPC-OOP – 2. Cvičení (nehodnoceno)
1. Vytvořte nový projekt podle šablony „Console App“ (pozor! Nepoužívejte starší „Console App
    (.NET Framework)“). Target Framework zvolte .NET 8.0.
2. Vytvořte vlastní třídu Complex pro práci s komplexními čísly (nepoužívejte Complex z
    System.Numerics). Konstruktor třídy bude mít dva argumenty typu double s reálnou a
    imaginární částí. Hodnoty budou uloženy v členských proměnných Realna a Imaginarni.
    Implementujte operátory +, -, *, /, ==, !=, unární operátor -. Implementujte metodu ToString
    pro zobrazení komplexního čísla na konzoli. Napište metody vracející komplexně sdružené
    číslo, modul a argument.
3. Vytvořte třídu TestComplex se statickou metodou Test se dvěma argumenty Complex
    (budou obsahovat skutečnou a očekávanou hodnotu) a argumentem typu string pro název
    testu. Metoda vypíše na konzoli název testu a OK, když se obě komplexní hodnoty liší o
    hodnotu menší než epsilon, a napíše Chyba: Očekávaná hodnota: …, Skutečná hodnota: …
    v případě chyby (odchylka větší než konstanta Epsilon, kterou nastavíte na 1E-6).
4. Otestujte operátory +, -, *, /, unární operátor - a metodu vracející komplexně sdružené číslo
    z bodu 1. pomocí třídy TestComplex z bodu 2. Vytiskněte výsledky operátorů ==, != a
    výsledky metod modul a argument.*/

Console.WriteLine("Cviceni 2, BPC - OOP\n");

Complex x = new(3, 4);
Complex y = new(5, -6);

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"x+y = {x + y}");
Console.WriteLine($"x-y = {x - y}");
Console.WriteLine($"x*y = {x * y}");
Console.WriteLine($"x/y = {x / y}");
Console.WriteLine($"-x = {-x}");
Console.WriteLine($"x == y = {x == y}");
Console.WriteLine($"x != y = {x != y}\n");
Console.WriteLine($"Sdruzeny x = {x.Sdruzeny()}");
Console.WriteLine($"Sdruzeny y = {y.Sdruzeny()}");
Console.WriteLine($"Modul x = {x.Modul():F2}");
Console.WriteLine($"Modul y = {y.Modul():F2}");
Console.WriteLine($"Argument x = {x.Argument():F2}°");
Console.WriteLine($"Argument y = {y.Argument():F2}°\n");


Complex expected = x + y;
var numericsSum = System.Numerics.Complex.Add(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
Complex actual = new(numericsSum.Real, numericsSum.Imaginary);
TestComplex.Test(actual, expected, "operator +");

expected = x - y;
var numericsSub = System.Numerics.Complex.Subtract(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
actual = new(numericsSub.Real, numericsSub.Imaginary);
TestComplex.Test(actual, expected, "operator -");

expected = x * y;
var numericsMul = System.Numerics.Complex.Multiply(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
actual = new(numericsMul.Real, numericsMul.Imaginary);
TestComplex.Test(actual, expected, "operator *");

expected = x / y;
var numericsDiv = System.Numerics.Complex.Divide(new System.Numerics.Complex(x.Realna, x.Imaginarni), new System.Numerics.Complex(y.Realna, y.Imaginarni));
actual = new(numericsDiv.Real, numericsDiv.Imaginary);
TestComplex.Test(actual, expected, "operator /");

expected = -x;
var numericsNeg = System.Numerics.Complex.Negate(new System.Numerics.Complex(x.Realna, x.Imaginarni));
actual = new(numericsNeg.Real, numericsNeg.Imaginary);
TestComplex.Test(actual, expected, "operator -");

expected = x.Sdruzeny();
var numericsConj = System.Numerics.Complex.Conjugate(new System.Numerics.Complex(x.Realna, x.Imaginarni));
actual = new(numericsConj.Real, numericsConj.Imaginary);
TestComplex.Test(actual, expected, "metoda Sdruzeny");



