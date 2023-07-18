using System;

public class Divide
{
    public void DivideByTwo(int data, out int result)
    {
        result = data / 2;
        Console.WriteLine(result);
    }
    public static void DivideByTwo(double data, out double result)
    {
        result = data / 2.0;
    }
}
