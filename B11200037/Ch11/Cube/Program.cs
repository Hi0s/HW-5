using System;
public class MyMath {
    static public int Cube(int x)
    {
        return x * x * x;
    }
    static public double Cube(double x)
    {
        return x * x * x;
    }
    static public int MinElement(int a,int b,int c) {
        int min = (a <= b && a <= c) ? a : (b <= a && b <= c) ? b : c;
        return min;
    }
    static public int MinElement(int a, int b, int c, int d) {
        int min = a;
        if (min > b) min = b;
        if (min > c) min = c;
        if (min > d) min = d;
        return min;
    }
}


class Program
{
    static void Main(string[] args) {
        Console.WriteLine($"Cube of the number 9 = {MyMath.Cube(9)}\n" +
            $"And cube of number 3.75 = {MyMath.Cube(3.75):00.00}\n" +
            $"Min value of three numbers [100,50,75] = {MyMath.MinElement(100,50,75)}\n" +
            $"Min value of four numbers [30,75,2,2000] = {MyMath.MinElement(30,75,2,2000)}");
    }
}