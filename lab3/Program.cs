using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        ushort x = (ushort)rnd.Next(1, 63), y = (ushort)rnd.Next(1, x);
        Console.WriteLine("x =" + x + " y =" + y);
        Console.WriteLine("x =" + new RomanNumber(x) + " y =" + new RomanNumber(y));
        Console.WriteLine("x + y = " + x + " + " + y + " = " + (new RomanNumber(x) + new RomanNumber(y)) + "(" + (x + y) + ")");
        Console.WriteLine("x - y = " + x + " - " + y + " = " + (new RomanNumber(x) - new RomanNumber(y)) + "(" + (x - y) + ")");
        Console.WriteLine("x * y = " + x + " * " + y + " = " +  new RomanNumber(x) * new RomanNumber(y) + "(" + (x * y) + ")");
        Console.WriteLine("x / y = " + x + " / " + y + " = " +  new RomanNumber(x) / new RomanNumber(y) + "(" + (x / y) + ")");
        Console.WriteLine();

        ushort[] Arr = new ushort[5];
        RomanNumber[] RomanArr = new RomanNumber[5];

        Console.WriteLine("Unsorted arr: ");

        for (int i = 0; i < 5; i++)
        {
            Arr[i] = (ushort)(rnd.Next(1, 3999));
            RomanArr[i] = new RomanNumber(Arr[i]);
            Console.Write(Arr[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
            Console.Write(RomanArr[i] + " ");

        Console.WriteLine();
        Console.WriteLine();

        Array.Sort(Arr);
        Array.Sort(RomanArr);

        Console.WriteLine("Sorted arr: ");

        for (int i = 0; i < 5; i++)
            Console.Write(Arr[i] + " ");
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
            Console.Write(RomanArr[i] + " ");
        Console.WriteLine();
    }
}

