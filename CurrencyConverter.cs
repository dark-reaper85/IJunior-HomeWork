using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            float rubBalance = 1000;
            float usdBalance = 100;
            float eurBalance = 100;
            float rubToUsd = 73.98f;
            float eurToRub = 89.66f;
            float usdToEur = 0.83f;
            float sumToConvert;
            int inputOperation = 0;
            while (inputOperation != 7)
            {
                Console.Clear();
                Console.WriteLine($"Ваш баланс: { rubBalance,-5 } рублей");
                Console.WriteLine($"Ваш баланс: { usdBalance,-5 } долларов");
                Console.WriteLine($"Ваш баланс: { eurBalance,-5 } евро");
                Console.WriteLine("Список возможных операций:");
                Console.WriteLine("Введите номер операции:");
                Console.WriteLine("1 - Конвертация рублей в доллары ");
                Console.WriteLine("2 - Конвертация долларов в рубли ");
                Console.WriteLine("3 - Конвертация рублей в евро ");
                Console.WriteLine("4 - Конвертация евро в рубли ");
                Console.WriteLine("5 - Конвертация долларов в евро ");
                Console.WriteLine("6 - Конвертация евро в доллары ");
                Console.WriteLine("7 - Выход из конвертера ");
                Console.WriteLine("Введите номер операции");
                inputOperation = Convert.ToInt32(Console.ReadLine());
                switch (inputOperation)
                {
                    case 1:
                        Console.WriteLine("Какую сумму в рублях хотите обменять?");
                        sumToConvert = Convert.ToSingle(Console.ReadLine());
                        if (sumToConvert > rubBalance)
                            Console.WriteLine("Сумма превышает ваш баланс");
                        rubBalance -= sumToConvert;
                        usdBalance += sumToConvert / rubToUsd;
                        break;
                    case 2:
                        Console.WriteLine("Какую сумму в долларах хотите обменять?");
                        sumToConvert = Convert.ToSingle(Console.ReadLine());
                        if (sumToConvert > usdBalance)
                            Console.WriteLine("Сумма превышает ваш баланс");
                        usdBalance -= sumToConvert;
                        rubBalance += sumToConvert * rubToUsd;
                        break;
                    case 3:
                        Console.WriteLine("Какую сумму в рублях хотите обменять?");
                        sumToConvert = Convert.ToSingle(Console.ReadLine());
                        if (sumToConvert > rubBalance)
                            Console.WriteLine("Сумма превышает ваш баланс");
                        rubBalance -= sumToConvert;
                        eurBalance += sumToConvert / eurToRub;
                        break;
                    case 4:
                        Console.WriteLine("Какую сумму в евро хотите обменять?");
                        sumToConvert = Convert.ToSingle(Console.ReadLine());
                        if (sumToConvert > eurBalance)
                            Console.WriteLine("Сумма превышает ваш баланс");
                        eurBalance -= sumToConvert;
                        rubBalance += sumToConvert * eurToRub;
                        break;
                    case 5:
                        Console.WriteLine("Какую сумму в долларах хотите обменять?");
                        sumToConvert = Convert.ToSingle(Console.ReadLine());
                        if (sumToConvert > usdBalance)
                            Console.WriteLine("Сумма превышает ваш баланс");
                        usdBalance -= sumToConvert;
                        eurBalance += sumToConvert * usdToEur;
                        break;
                    case 6:
                        Console.WriteLine("Какую сумму в евро хотите обменять?");
                        sumToConvert = Convert.ToSingle(Console.ReadLine());
                        if (sumToConvert > eurBalance)
                            Console.WriteLine("Сумма превышает ваш баланс");
                        eurBalance -= sumToConvert;
                        usdBalance += sumToConvert / usdToEur;
                        break;
                    default:
                        if (inputOperation == 7)
                            break;
                        Console.WriteLine("Неизвестная операция");
                        break;
                }
            }
        }
    }
}
