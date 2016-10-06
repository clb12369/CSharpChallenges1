using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChallenges1
{
    class ScalingRandomNumbers
    {
        static int random(int min, int max)
        {
            Random r = new Random();
            double rand1 = r.NextDouble() * (max - min) + min;
            return (int)rand1;
        }
        public static void Main()
        {
            Console.WriteLine(random(1, 2) <= 2 && random(1, 2) >= 1);
            Console.WriteLine(random(-11, 22) <= 22 && random(-11, 22) >= -11);
        }
    }
}
