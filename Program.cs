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
            int remainImage = imageCount % 3;
            Console.WriteLine(fullRowsCount);
            Console.WriteLine(remainImage);
        }
    }
}
