using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCycles
{
    class LerningCyrcles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше прошение");
            string inputMessage = Console.ReadLine();
            Console.WriteLine("Сколько раз повторить ваше прошение?");
            int repeatMessage = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < repeatMessage; i++)
            {
                Console.WriteLine(inputMessage);
            }
        }
    }
}
