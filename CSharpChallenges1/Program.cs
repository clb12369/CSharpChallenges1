
using System;
using System.Diagnostics;

public class Program
{
    static float vectorLength(float[,] vecs)
    {
        double x1 = vecs[0, 0];
        double y1 = vecs[0, 1];
        double x2 = vecs[1, 0];
        double y2 = vecs[1, 1];
        double squares = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        float answer = (float)Math.Sqrt(squares);

        return answer;
    }
    public static void Main()
    {
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 3 }, { 4, 0 } }) == 5);
        Console.WriteLine(vectorLength(new float[2, 2] { { 1, -1 }, { 1, -1 } }) == 0);
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);
        Console.ReadLine();
    }
}

