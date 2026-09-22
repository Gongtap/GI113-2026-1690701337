/*
 * Student ID :1690701337
 * Name       :Gongtap Panawas
 * Section    :129B
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 5;

            //if (lives <= 0) // ในวงเล็บคือเงื่อนไขที่ต้องเป็นจริง
            //{
            //    // บล็อคของโค้ดที่จะทำงาน เมื่อเงื่อนไขเป็นจริง
            //    Console.WriteLine("game over");
            //}
            //else
            //{
            //    Console.WriteLine("continue to play!");
            //}

            //// เมื่อเงื่อนไขทำงานเสร็จแล้ว หรือ เงื่อนไขไม่ตรงเลยโค้ดทำงานต่อ
            //    Console.WriteLine("continue to run");

            //// int level = 10;

            //bool isPoisoned = false;
            //if (isPoisoned) { } // ได้เท็จ เพราะ isPoisoned = false
            //if (!isPoisoned) { } // ได้จริง เพราะ isPoisoned = false
            //bool hasKey = false;


            //Console.Write("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid Level Input.");
            //}
            //else if (level >= 10 && hasKey) // && และ กับ || หรือ
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5) // ต้องมี level 5 ขึ้นไป
            //{
            //    if (hasKey == true) // และต้องมีกุญแจ กุญแจเป็นจริง
            //    {
            //        Console.WriteLine("The door opens.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Locked. Find a key.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut.");
            //}
            int heroHp = 123;
            int monHp = 200;
            int heroAtk = 75;
            int potionBuffDmg = 25;
            int potionHp = 50;
            string heroName = "Youypouy";
<<<<<<< Updated upstream
            
=======

>>>>>>> Stashed changes
            Console.WriteLine("|===================================|      |====|| ");
            Console.WriteLine("|| Game title: Youypouy the slayer ||      ||      ");
            Console.WriteLine("||       Found the monster         ||      |====|| ");
            Console.WriteLine("||  Action1: Attack                ||           || ");
            Console.WriteLine("||  Action2: Cast Magic Spell      ||      ||====| ");
            Console.WriteLine("||  Action3: Used Potion HP        ||");
            Console.WriteLine("|===================================|");

            Console.Write($"{heroName} Choose Action[1-3]: ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid Input, Enter Action Between 1 to 3");
            }
            else if (choice == 1)
            {
                monHp -= heroAtk;
                if (monHp <= 0)
                {
                    Console.WriteLine($"Youypouy attacked the monster with {heroAtk} DMG, Monster is dead");
                }
                else
                {
                    Console.WriteLine($"Youypouy attacked the monster with {heroAtk} DMG, Monster current Hp {monHp} HP left");
                }
            }
            else if (choice == 2)
            {
                monHp -= MagicSpell;
                if (monHp <= 0)
                {
                    Console.WriteLine($"Youypouy attacked the monster with {MagicSpell} DMG, Monster is dead");
                }
                else
                {
                    Console.WriteLine($"Youypouy attacked the monster with {MagicSpell} DMG, Monster current Hp {monHp} HP left");
                }
            }
            else if (choice == 3)
            {
                heroHp += potionHp;
                Console.WriteLine($"Youypouy Drank a Potion of HP, Regen HP now {heroHp} HP");
            }
        }
    }
}
