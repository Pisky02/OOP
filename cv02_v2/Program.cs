
//kod se da zakomentovat zkratkou ctrl+k+c a odkomentovat zkratkou ctrl+k+u

//Complex cislo = new Complex(2.0,-3.2);

TestComplex.Test(new Complex(3.0,5.0), 
    new Complex(2.0,1.0) + new Complex(1.0,4.0), "operator +");

Console.WriteLine("Operator ==: {0}",
    new Complex(2.0,1.0) == new Complex(2.0,1.0));

Console.WriteLine("Operator ==: {0}",
    new Complex(2.0,1.0) == new Complex(2.0,7.0));
//Console.WriteLine(cislo);
//Console.WriteLine(cislo.Sdruzene());

