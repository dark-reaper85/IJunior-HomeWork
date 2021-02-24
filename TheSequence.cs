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
            int stepValue = 7;
            int stepCount = 14;
            int value = minValue;
            for (int i = 0; i < stepCount; i++)
            {
                Console.Write(" " + value);
                value += stepValue;
            }
        }
    }
}
