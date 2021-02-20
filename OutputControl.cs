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
            string userInput;
            while (true)
            {
                Console.WriteLine("Введите пароль или exit для продолжения");
                userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    break;
                }
            }
        }
    }
}
