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

internal class Matrix
{ 
    private double[,] matrix;

    public Matrix(double[,] matrix)
    {
        this.matrix = matrix;
    }

    private int Rows
    {
        get { return matrix.GetLength(0); }
    }
    private int Cols
    {
        get { return matrix.GetLength(1); }
    }

    //Operatory +, -, *, ==, !=, unární operator -
    public static Matrix operator +(Matrix a, Matrix b)
    {
        if(a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new Exception("Nekompatibilní rozměry matic pro sčítání.");
        }
        double[,] result = new double[a.Rows, a.Cols];
        for(int rowIndex = 0; rowIndex < a.Rows; rowIndex++)
        {
            for(int colIndex = 0; colIndex < a.Cols; colIndex++)
            {
                result[rowIndex, colIndex] = a.matrix[rowIndex, colIndex] + b.matrix[rowIndex, colIndex];
            }
        }
        return new Matrix(result);
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if(a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new Exception("Nekompatibilní rozměry matic pro odčítání.");
        }
        double[,] result = new double[a.Rows, a.Cols];
        for(int rowIndex = 0; rowIndex < a.Rows; rowIndex++)
        {
            for(int colIndex = 0; colIndex < a.Cols; colIndex++)
            {
                result[rowIndex, colIndex] = a.matrix[rowIndex, colIndex] - b.matrix[rowIndex, colIndex];
            }
        }
        return new Matrix(result);
    }
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if(a.Cols != b.Rows)
        {
            throw new Exception("Nekompatibilní rozměry matic pro násobení.");
        }

        double[,] result = new double[a.Rows, b.Cols];

        for(int rowIndex = 0; rowIndex < a.Rows; rowIndex++)
        {
            for(int colIndex = 0; colIndex < b.Cols; colIndex++)
            {
                double sum = 0;
                for(int sumIndex = 0; sumIndex < a.Cols; sumIndex++)
                {
                    sum += a.matrix[rowIndex, sumIndex] * b.matrix[sumIndex, colIndex];
                }

                result[rowIndex, colIndex] = sum;
            }
        }
        return new Matrix(result);
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if(a.Rows != b.Rows || a.Cols != b.Cols)
        {
            return false;
        }
        for(int rowIndex = 0; rowIndex < a.Rows; rowIndex++)
        {
            for(int colIndex = 0; colIndex < a.Cols; colIndex++)
            {
                if(a.matrix[rowIndex, colIndex] != b.matrix[rowIndex, colIndex])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        return !(a == b);
    }

    public static Matrix operator -(Matrix a)
    {
        double[,] result = new double[a.Rows, a.Cols];
        for(int rowIndex = 0; rowIndex < a.Rows; rowIndex++)
        {
            for(int colIndex = 0; colIndex < a.Cols; colIndex++)
            {
                result[rowIndex, colIndex] = -a.matrix[rowIndex, colIndex];
            }
        }
        return new Matrix(result);
    }

    //ToString pro zobrazení matice na konzoli
    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                // result += string.Format("{0,10:F2}", matrix1[i, j]);
                result += $"{matrix[i, j], 10:F2}";
            }
            result += Environment.NewLine;
        }
        return result;
    }

    //Metoda vracející determinant matice pro rozměry do velikosti 3x3
    public double Determinant()
    {
        if(Rows != Cols)
        {
            throw new Exception("Matice není čtvercová.");
        }
        if(Rows > 3)
        {
            throw new Exception("Matice může být nanejvýš rozměru 3x3.");
        }
        if(Rows == 1)
        {
            return matrix[0, 0];
        }
        else if(Rows == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else 
        {
            double a = matrix[0, 0], b = matrix[0, 1], c = matrix[0, 2];
            double d = matrix[1, 0], e = matrix[1, 1], f = matrix[1, 2];
            double g = matrix[2, 0], h = matrix[2, 1], i = matrix[2, 2];
            return (a*e*i + d*h*c + g*b*f) - (g*e*c + a*f*h + b*d*i);
        }
    
    }
}