/*
BPC-OOP cv3

1. Vytvořte nový projekt podle šablony „Console App“. Target Framework zvolte .NET 8.0.
2. Vytvořte vlastní třídu Matrix pro práci s maticemi. Hodnoty v matici budou typu double.
    Vnitřně matici ukládejte do datového členu, který bude typu double[,]. Vytvořte konstruktor
    s jedním argumentem typu dvourozměrné pole double[,].
3. Implementujte operátory +, -, *, ==, !=, unární operátor -. Implementujte metodu ToString
    pro zobrazení matice na konzoli. Napište metodu vracející determinant matice pro rozměry
    do velikosti 3x3. Chybové stavy (např. nekompatibilita matic při operacích, u determinantu
    pokud není matice čtvercová či je větší než 3x3) ošetřete výjimkami.
4. V metodě Main provolejte jednotlivé operátory a metody a s využitím Matlabu ověřte
    správnost výpočtů v těchto operátorech a metodách 
 */

Matrix matrixA = new Matrix(new double[,] { { 1, -2 ,5 }, { -3, 4, 8  }, { 2, 5, 9 } });
Matrix matrixB = new Matrix(new double [,] { { 5, 6 }, { 7, 8 } });
Matrix matrixC = new Matrix(new double [,] { { 8 } });
Matrix matrixD = new Matrix(new double [,] { { 5, 6, 9, 6 }, { 7, 8, 10 , 2}, { 5, 6, 9, 6 }, { 7, 8, 10, 2 }});

Matrix matrixE = new Matrix(new double [,] { { 5, 6, -9 }, { 7, 2, 10 }, { 4, 6, 8} });
Matrix matrixF = new Matrix(new double [,] { { 7, 1 }, { -8, 10 } });
Matrix matrixG = new Matrix(new double [,] { { 5 } });
Matrix matrixH = new Matrix(new double [,] { { 5, 2 }, { 7, 4 }, { 5, 6} });

Console.WriteLine("Matrix A + Matrix E (3x3): \n{0}", matrixA + matrixE);
Console.WriteLine("Matrix B - Matrix F (2x2): \n{0}", matrixB - matrixF);
Console.WriteLine("Matrix A * Matrix E (3x3): \n{0}", matrixA * matrixE);
Console.WriteLine("Matrix C == Matrix C (1x1): \n{0}", matrixC == matrixC);
Console.WriteLine("Matrix C != Matrix G (1x1): \n{0}", matrixC != matrixG);
Console.WriteLine("-Matrix A: \n{0}", -matrixA);
Console.WriteLine("Determinant of Matrix A (3x3): \n{0}", matrixA.Determinant());
Console.WriteLine("Determinant of Matrix B (2x2): \n{0}", matrixB.Determinant());
Console.WriteLine("Determinant of Matrix C (1x1): \n{0}", matrixC.Determinant());

try
{
 
    Console.WriteLine("Determinant of Matrix H (2x3): \n{0}", matrixH.Determinant());
}
catch(Exception ex)
{
    Console.WriteLine("Chyba: {0}", ex.Message);
}
try
{

    Console.WriteLine("Determinant of Matrix D (4x4): \n{0}", matrixD.Determinant());
}
catch (Exception ex)
{
    Console.WriteLine("Chyba: {0}", ex.Message);
}
try
{

    Console.WriteLine("Matrix A * Matrix B (3x3): \n{0}", matrixA * matrixB);
}
catch (Exception ex)
{
    Console.WriteLine("Chyba: {0}", ex.Message);
}
try
{

    Console.WriteLine("Matrix B + Matrix E (3x3): \n{0}", matrixB + matrixE);
}
catch (Exception ex)
{
    Console.WriteLine("Chyba: {0}", ex.Message);
}






