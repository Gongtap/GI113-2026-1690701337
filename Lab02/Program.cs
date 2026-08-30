/*
 * Student ID :1690701337
 * Name       :Gongtap Panawas
 * Section    :129B
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */ 

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp; // คำนวณเปอร์เซ็น
            Console.WriteLine($"HP Percent: {hpPercent}");
            Console.WriteLine();

            Console.WriteLine($"KIrin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

                        string player1Name = "Kunyouypouy";
            string className1 = "warrior";
            int level = 99;
            int maxHpPlayer1 = 690;
            float attackPowerPlayer1 = 71f;

            Console.WriteLine($"===== PLAYER 1 STATUS =====");
            Console.WriteLine($"Name: {player1Name}");  // แสดงชื่อผู้เล่น 1
            Console.WriteLine($"Class: {className1}");  // แสดงอาชีพของผู้เล่น 1    
            Console.WriteLine($"Level: {level}");  // แสดงเลเวลของผู้เล่น 1
            Console.WriteLine($"Max HP: {maxHpPlayer1}");  // แสดงค่า HP สูงสุดของผู้เล่น 1
            Console.WriteLine($"Attack Power: {attackPowerPlayer1}");  // แสดงค่าพลังโจมตีของผู้เล่น 1
            Console.WriteLine();

            string player2Name = "Memon";
            string className2 = "Assassin";
            char DangerLevel = 'Z';
            float attackPowerPlayer2 = 39f;
            double critMultiplierPlayer2 = 2.14;

            Console.WriteLine($"===== PLAYER 2 STATUS =====");
            Console.WriteLine($"Name: {player2Name}");  // แสดงชื่อผู้เล่น 2
            Console.WriteLine($"Class: {className2}");  // แสดงอาชีพของผู้เล่น 2
            Console.WriteLine($"Danger Level: {DangerLevel}");  // แสดงระดับอันตรายของผู้เล่น 2
            Console.WriteLine($"Attack Power: {attackPowerPlayer2}");  // แสดงค่าพลังโจมตีของผู้เล่น 2
            Console.WriteLine($"Crit Multiplier: {critMultiplierPlayer2}");  // แสดงค่าการคูณคริติคัลของผู้เล่น 2
            Console.WriteLine();

            string player3Name = "TourpoohGammer";
            string weaponType = "HugeHammer";
            float attackPowerPlayer3 = 96f;
            double critMultiplierPlayer3 = 1.47;
            bool isPlayer3Alive = true;

            Console.WriteLine($"===== PLAYER 3 STATUS =====");
            Console.WriteLine($"Name: {player3Name}");  // แสดงชื่อผู้เล่น 3
            Console.WriteLine($"Weapon Type: {weaponType}"); // แสดงประเภทอาวุธของผู้เล่น 3
            Console.WriteLine($"Attack Power: {attackPowerPlayer3}");  // แสดงค่าพลังโจมตีของผู้เล่น 3
            Console.WriteLine($"Crit Multiplier: {critMultiplierPlayer3}");  // แสดงค่าการคูณคริติคัลของผู้เล่น 3
            Console.WriteLine($"Is Alive: {isPlayer3Alive}");  // แสดงสถานะการมีชีวิตของผู้เล่น 3
            Console.WriteLine();

            string player4Name = "Pheskungz";
            string className4 = "Necromancer";
            string specialAbility = "Summon Skeletons";
            int levelPlayer4 = 88;
            int capSummonedSkeletons = 10;

            Console.WriteLine($"===== PLAYER 4 STATUS =====");
            Console.WriteLine($"Name: {player4Name}");  // แสดงชื่อผู้เล่น 4
            Console.WriteLine($"Class: {className4}");  // แสดงอาชีพของผู้เล่น 4
            Console.WriteLine($"Special Ability: {specialAbility}");  // แสดงความสามารถพิเศษของผู้เล่น 4
            Console.WriteLine($"Level: {levelPlayer4}");  // แสดงเลเวลของผู้เล่น 4
            Console.WriteLine($"Capacity for Summoned Skeletons: {capSummonedSkeletons}");  // แสดงจำนวนสูงสุดในการเรียกโครงกระดูกของผู้เล่น 4
            Console.WriteLine();
        }
    }
}
