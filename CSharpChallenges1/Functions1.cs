using System;
using System.Diagnostics;

namespace CSharpChallenges1
{
    public class Functions1
    {
        static int sum(int a, int b)
        {
            return a + b;
        }
        public static void Main()
        {
            Console.WriteLine(sum(1, 2) == 3);
        }
    }

    // As lambda
    public class FunctionsLambda
    {
    }
    public static void Main()
    {
        Func<int, int, int> sum = (int a, int b) => a + b;
        Console.WriteLine(sum(1, 2) == 3);
    }
}