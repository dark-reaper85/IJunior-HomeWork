using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class ConsoleMenu
    {
        static void Main(string[] args)
        {
            string userChangeMenu = null;
            string changedColor;
            bool enteredCorrectPassword = false;
            string validPassword = "qwert";
            string userName = "User";
            while (userChangeMenu != "ESC")
            {
                Console.Clear();
                Console.WriteLine("ChangeBackgroundColor     - Изменить цвет фона консоли");
                Console.WriteLine("ChangeFontColor           - Изменить цвет шрифта");
                if (enteredCorrectPassword == false)
                    Console.WriteLine("EnterPassword             - Введите пароль");
                else if (enteredCorrectPassword)
                {
                    Console.WriteLine("SetUserName               - Установить имя пользователя");
                    Console.WriteLine("SetPassword               - Установить новый пароль");
                    Console.WriteLine("WriteUserName             - Вывести имя пользователя");
                }
                Console.WriteLine("ESC                       - Выход из программы");
                userChangeMenu = Console.ReadLine();
                switch (userChangeMenu)
                {
                    case "ChangeBackgroundColor":
                        Console.Clear();
                        Console.WriteLine("Выберите цвет фона:");
                        Console.WriteLine("Red     - Красный");
                        Console.WriteLine("Yellow  - Желтый");
                        Console.WriteLine("Green   - Зеленый");
                        Console.WriteLine("Default - Стандартные настройки");
                        Console.WriteLine("Back   - Вернуться в основное меню");
                        changedColor = Console.ReadLine();
                        switch (changedColor)
                        {
                            case "Red":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "Yellow":
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case "Green":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Back":
                                break;
                            case "Default":
                                Console.ResetColor();
                                break;
                            default:
                                Console.WriteLine("Недопустимый цвет");
                                break;
                        }
                        break;
                    case "ChangeFontColor":
                        Console.Clear();
                        Console.WriteLine("Выберите цвет шрифта:");
                        Console.WriteLine("Red    - Красный");
                        Console.WriteLine("Yellow - Желтый");
                        Console.WriteLine("Green  - Зеленый");
                        Console.WriteLine("Default - Стандартные настройки");
                        Console.WriteLine("Back   - Вернуться в основное меню");
                        changedColor = Console.ReadLine();
                        switch (changedColor)
                        {
                            case "Red":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "Yellow":
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case "Green":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Back":
                                break;
                            case "Default":
                                Console.ResetColor();
                                break;
                            default:
                                Console.WriteLine("Недопустимый цвет");
                                break;
                        }
                        break;
                    case "EnterPassword":
                        string inputPassword = Console.ReadLine();
                        if (inputPassword == validPassword)
                            enteredCorrectPassword = true;
                        else
                            Console.WriteLine("Неверный пароль");
                        break;
                    case "SetUserName":
                        if (enteredCorrectPassword)
                        {
                            Console.WriteLine("Введите Имя пользователя:");
                            userName = Console.ReadLine();
                        }
                        else 
                            Console.WriteLine("Авторизуйтеь для доступа к расширенной функциональности");
                        break;
                    case "SetPassword":
                        if (enteredCorrectPassword)
                        {
                            validPassword = Console.ReadLine();
                        }
                        else
                            Console.WriteLine("Авторизуйтеь для доступа к расширенной функциональности");
                        break;
                    case "WriteUserName":
                        if (enteredCorrectPassword)
                        {
                            Console.WriteLine("Имя пользователя: " + userName);
                        }
                        else 
                            Console.WriteLine("Авторизуйтеь для доступа к расширенной функциональности");
                        break;
                    case "ESC":
                        break;
                    default:
                        Console.WriteLine("Данный пункт меню отсутствует");
                        break;
                }
            }
        }
    }
}
