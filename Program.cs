using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 переменных для первого ДЗ
            int equipmentCapacity;
            byte aggressiveCount;
            sbyte kindness;
            uint stepsCount;
            float mountSpeed;
            decimal accountBalance;
            string title;
            bool isFullInventory;
            double hipotenuse;
            char persent;
            // Проверка вывода 2-е ДЗ
            int a = 10;
            int b = 38 * 17;
            int c = (31 - 5 * a) / b;
            Console.WriteLine(c);
            /* ДЗ № 3. На экране, в специальной зоне, выводятся картинки, по 3 в ряд. Всего у пользователя в альбоме 52 картинки.
            Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.
            В качестве решения ожидаются объявленные переменные с необходимыми значениями и, основываясь на значениях переменных, вывод необходимых данных.*/
            int imageCount = 52;
            int imagesInRow = 3;
            int fullRowsCount = imageCount / imagesInRow;
            int remainImage = imageCount % imagesInRow;
            Console.WriteLine(fullRowsCount);
            Console.WriteLine(remainImage);
            /* ДЗ № 4.
             * Легенда:
            Вы приходите в магазин и хотите купить за своё золото кристаллы. 
            В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить?
            После сделки у вас остаётся какое-то количество золота и появляется какое-то количество кристаллов.

            Формально:

            При старте программы пользователь вводит начальное количество золота.
            Потом ему предлагается купить какое-то количество кристаллов по цене N(задать в программе самому).
            Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран. */
            int goldCount = 100;
            int gemCost = 4;
            Console.WriteLine("Сколько кристаллов хотите приобрести?");
            int gemsToBuyValue = Convert.ToInt32(Console.ReadLine());
            int goldAfterPurchase = goldCount - gemCost * gemsToBuyValue;
            Console.WriteLine($"У вас: {goldAfterPurchase} золота и {gemsToBuyValue} кристалов");
            
            /*ДЗ № 5.
             * Легенда:

            Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.

            Формально:
            Пользователь вводит кол-во людей в очереди.
            Фиксированное время приема одного человека всегда равно 10 минутам.
            Пример ввода: Введите кол-во старушек: 14
            Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут." */
            Console.WriteLine("Сколько людей в очереди?");
            int peopleInQueue = Convert.ToInt32(Console.ReadLine());
            int timeForPatient = 10;
            int hoursInQueue = peopleInQueue * timeForPatient / 60;
            int minutesInQueue = peopleInQueue * timeForPatient % 60;
            Console.WriteLine(@"Вы должны отстоять в очереди {0} часа и {1} минут", hoursInQueue , minutesInQueue);
            /*ДЗ № 6.
             * Вы задаете вопросы пользователю, по типу "как вас зовут", "какой ваш знак зодиака" и тд, 
             * после чего, по данным, которые он ввел, формируете небольшой текст о пользователе.

            "Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе." */
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Как ваша фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            string company = Console.ReadLine();
            Console.WriteLine("На какой должности?");
            string post = Console.ReadLine();
            Console.WriteLine($"Вас зовут {surname} {name}, вы работаете в компании {company} на должности {post}.");
        }
    }
}
