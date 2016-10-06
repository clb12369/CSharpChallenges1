using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChallenges1
{
    class Tweeter
    {
        static string tweeter(string text)
        {
            int napsIndex = text.IndexOf("naps");
            while (napsIndex != -1)
            {
                text = text.Remove(napsIndex, 4);
                text = text.Insert(napsIndex, "maps");
                napsIndex = text.IndexOf("naps");
            }
            return text;
        }
        public static void Main()
        {
            Console.WriteLine(tweeter("I really like naps") == "I really like maps");
            Console.WriteLine(tweeter("I really like naps"));
            Console.WriteLine(tweeter("naps maps naps maps") == "maps maps maps maps");
            Console.WriteLine(tweeter("naps maps naps maps"));
        }
    }
}
