using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputName
{
    class OutputName
    {
        static void Main(string[] args)
        {
            char frameSymbol;
            string userName;
            Console.WriteLine("Введите символ для рамочки:");
            frameSymbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите имя");
            userName = Console.ReadLine();
            for (int i = 0; i < userName.Length + 2; i++)
            {
                Console.Write(frameSymbol);
            }
            Console.WriteLine();
            Console.Write(frameSymbol);
            Console.Write(userName);
            Console.Write(frameSymbol);
            Console.WriteLine();
            for (int i = 0; i < userName.Length + 2; i++)
            {
                Console.Write(frameSymbol);
            }
        }
    }
}
