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
            int stepValue = 7;
            for (int value = minValue; value <= maxValue; value += stepValue)
            {
                Console.Write(" " + value);
            }
        }
    }
}
