using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderPasswordProgram
{
    class UnderPasswordProgram
    {
        static void Main(string[] args)
        {
            string validPassword = "qwert";
            int maxAttemptsCount = 3;
            string userInput;
            int attemptCount;
            bool isPassed = false;
            for (attemptCount = 0; attemptCount < maxAttemptsCount; attemptCount++)
            {
                Console.WriteLine("Попытка №" + (attemptCount + 1));
                Console.WriteLine("Введите пароль");
                userInput = Console.ReadLine();
                if (userInput == validPassword)
                {
                    Console.WriteLine("Пароль угадан. Вы молодец!!!");
                    Console.ReadLine();
                    isPassed = true;
                    break;
                }
            }
            if (!isPassed && attemptCount == maxAttemptsCount)
            {
                Console.WriteLine("Попытики закончены. Вы провалились.");
                Console.ReadLine();
            }

        }
    }
}
