using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    class BossFight
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int round = 1;
            int bossHealth = 1000;
            int maxBossHealth = 1000;
            int simpleBossDamage = 70;
            int bossDamage = simpleBossDamage;
            bool isEnraged = false;
            float enrageTrigger = 0.1f;

            int heroHealth = 100;
            int simpleDamage = 25;
            
            int familiarHealth = 125;
            int maxFamiliarHealth = 125;
            int familiarColdown = 4;
            bool familiarReady = true;
            int simpleFamiliarDamage = 25;
            bool isFamiliarSummoned = false;

            
            while (bossHealth > 0 && heroHealth > 0)
            {
                int powerShotModifier = random.Next(5, 10);
                int powerShotDamage = simpleDamage * powerShotModifier;
                int familiarDamageModifier = random.Next(3, 8);
                int familiarDamage = familiarDamageModifier * simpleFamiliarDamage;
                int enrageDamageModifier = random.Next(5, 10);
                if (bossHealth <= enrageTrigger * maxBossHealth) 
                {
                    Console.WriteLine("Босс в ярости");
                    isEnraged = true; 
                }
                    

                if (round > 1)
                {
                    familiarReady = round % familiarColdown == 0;
                }
                Console.WriteLine("Раунд " + round);
                if (!isFamiliarSummoned && familiarReady)
                {
                    Console.WriteLine("Герой призывает фамильяра");
                    isFamiliarSummoned = true;
                    Console.WriteLine("Фамильяр наносит урон по боссу: " + familiarDamage);
                    bossHealth -= familiarDamage;
                    if (bossHealth < 0)
                        bossHealth = 0;

                    Console.WriteLine("Здоровье босса: " + bossHealth);
                    Console.WriteLine("Герой применяет PowerShot и наносит " + powerShotDamage + "урона по боссу");
                    bossHealth -= powerShotDamage;
                    if (bossHealth < 0)
                        bossHealth = 0;
                    Console.WriteLine("Здоровье босса: " + bossHealth);
                }
                else if (isFamiliarSummoned) 
                {
                    Console.WriteLine("Герой применяет PowerShot и наносит " + powerShotDamage + "урона по боссу");
                    bossHealth -= powerShotDamage;
                    if (bossHealth < 0)
                        bossHealth = 0;
                    Console.WriteLine("Здоровье босса: " + bossHealth);
                } 
                else
                {
                    Console.WriteLine("Герой наносит урон: " + simpleDamage );
                    bossHealth -= simpleDamage;
                    Console.WriteLine("Здоровье босса " + bossHealth);
                }
                
                if (isEnraged)
                    bossDamage = simpleBossDamage * enrageDamageModifier;
                if (isFamiliarSummoned)
                {
                    Console.WriteLine("Босс наносит урок по фамильяру: " + bossDamage);
                    familiarHealth -= bossDamage;
                    if (familiarHealth < 0)
                    {
                        Console.WriteLine("Фамильяр умирает");
                        isFamiliarSummoned = false;
                        familiarHealth = maxFamiliarHealth;
                    }
                }
                else
                {
                    Console.WriteLine("Босс атакует героя");
                    Console.WriteLine("Босс наносит урон: " + bossDamage + "по герою");
                    heroHealth -= bossDamage;
                    if (heroHealth < 0)
                        heroHealth = 0;
                    Console.WriteLine("Здоровье героя: " + heroHealth);
                }
                if (bossHealth == 0 && heroHealth == 0)
                    Console.WriteLine("Ничья");
                else if (bossHealth == 0)
                    Console.WriteLine("Босс повержен");
                else if (heroHealth == 0)
                    Console.WriteLine("Герой пал смертью храбрых");
                round++;
                Console.WriteLine();
            }
        }
    }
}
