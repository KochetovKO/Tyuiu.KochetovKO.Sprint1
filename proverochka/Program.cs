using System;

public class MainClass
{
    public static void Main()
    {
        int x = 7;
        int y = x++ + ++x * 2;
        Console.WriteLine(y);
    }
}