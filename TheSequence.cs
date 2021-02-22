using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSequence
{
    class TheSequence
    {
        static void Main(string[] args)
        {
            int minValue = 7;
            int maxValue = 98;
            int stepCount = 7;
            int value = minValue;
            while (value <= maxValue)
            {
                Console.Write(" " + value);
                value += stepCount;
            }
            Console.WriteLine();
            for (value = minValue; value <= maxValue; value += stepCount)
            {
                Console.Write(" " + value);
            }
        }
    }
}
