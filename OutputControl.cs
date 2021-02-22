using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputControl
{
    class OutputControl
    {
        static void Main(string[] args)
        {
            string userInput = null;
            while (userInput != "exit")
            {
                Console.WriteLine("Введите exit для завершения");
                userInput = Console.ReadLine();
            }
        }
    }
}
