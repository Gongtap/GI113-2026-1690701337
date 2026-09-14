/*
 * Student ID :1690701337
 * Name       :Gongtap Panawas
 * Section    :129B
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Apex Legends";
            const int MaxHp = 100;
            const int AbilityCapacity = 1;
            const int UltimateCapacity = 1;
            const string PassiveAbility = "Climb higher and crouch walk faster";

            var nameLegends = "Revenant";
            string typeOfLegends = "Assault";
            var inputKeyAbility = 'Q';
            char inputKeyUltimate = 'T';
            int maxAmmoSmgandLmgInInventory = 80;
            int reCastTimeAbility = 25;
            int reCastTimeUltimate = 180;
            float abilityChargeTime = 3.0f;
            float ultilityDuration = 25.0f;
            float passiveCouchWalkSpeedMultiplier = 1.35f;
            double pickedRate = 1.8;
            bool isPickedPlayable = true;

            Console.WriteLine($"+-----------------------------------------------------------------------+");
            Console.WriteLine($"|                   |------------------------------|                    |");
            Console.WriteLine($"|                   =          {GameTitle}        =                    |");
            Console.WriteLine($"|                   |------------------------------|                    |");
            Console.WriteLine($"+-----------------------------------------------------------------------+");

            Console.WriteLine($"|                ======================================                 |");
            Console.WriteLine($"|                ======================================                 |");
            Console.WriteLine($"|                ==================+*==================                 |");
            Console.WriteLine($"|                =================+##*=================                 |");
            Console.WriteLine($"|                ================+####*================                 |");
            Console.WriteLine($"|                ===============*######*===============                 |");
            Console.WriteLine($"|                ==============*#########==============                 |");
            Console.WriteLine($"|                =============*###########+============                 |");
            Console.WriteLine($"|                ============######++######============                 |");
            Console.WriteLine($"|                ===========######====######+==========                 |");
            Console.WriteLine($"|                =========+######======######+=========                 |");
            Console.WriteLine($"|                ========+######========######+========                 |");
            Console.WriteLine($"|                =======+######=========*######*=======                 |");
            Console.WriteLine($"|                ======+#####*============*#####*======                 |");
            Console.WriteLine($"|                =====*#########*======*#########*=====                 |");
            Console.WriteLine($"|                ======#######+===========*######+=====                 |");
            Console.WriteLine($"|                =======+##+================+##+=======                 |");
            Console.WriteLine($"|                ======================================                 |");
            Console.WriteLine($"|                ======================================                 |");
            Console.WriteLine($"|                ======================================                 |");
            Console.WriteLine($"+-----------------------------------------------------------------------+");

            Console.WriteLine($"|      Legends Name         :{nameLegends}                                   |");
            Console.WriteLine($"|      Legends Type         :{typeOfLegends}                                    |");
            Console.WriteLine($"|      Ability Key          :{inputKeyAbility}                                          |");
            Console.WriteLine($"|      Ultimate Key         :{inputKeyUltimate}                                          |");
            Console.WriteLine($"|      Max HP               :{MaxHp}                                        |");
            Console.WriteLine($"|      Ability Capacity     :{AbilityCapacity}                                          |");
            Console.WriteLine($"|      Ultimate Capacity    :{UltimateCapacity}                                          |");
            Console.WriteLine($"|      Passive Ability      :{PassiveAbility}        |");
            Console.WriteLine($"|      Max Ammo SMG and     :{maxAmmoSmgandLmgInInventory}                                         |");
            Console.WriteLine($"|      LMG in Inventory                                                 |");
            Console.WriteLine($"|      Re Cast Time Ability :{reCastTimeAbility}                                         |");
            Console.WriteLine($"|      Re Cast Time Ultimate:{reCastTimeUltimate}                                        |");
            Console.WriteLine($"|      Charge Time Ability  :{abilityChargeTime}                                          |");
            Console.WriteLine($"|      Ultility Duration    :{ultilityDuration}                                         |");
            Console.WriteLine($"|      Passive Couch Walk   :{passiveCouchWalkSpeedMultiplier}                                       |");
            Console.WriteLine($"|      Speed Multiplier                                                 |");
            Console.WriteLine($"|      Picked Rate          :{pickedRate}%                                       |");
            Console.WriteLine($"|      is Picked Playable   :{isPickedPlayable}                                       |");
            Console.WriteLine($"+-----------------------------------------------------------------------+");

            double reCastTimeAbilityAsDouble = reCastTimeAbility;
            Console.WriteLine($"|      Re Cast Time Ability As Double :{reCastTimeAbilityAsDouble}                               |");

            int pickedRateTruncated = (int)pickedRate;
            int pickedRateRounded = Convert.ToInt32(pickedRate);
            Console.WriteLine($"|      Picked Rate Cast(Truncated) :{pickedRateTruncated}                                   |");
            Console.WriteLine($"|      Picked Rate Convert(Rounded):{pickedRateRounded}                                   |");
            Console.WriteLine($"+-----------------------------------------------------------------------+");
        }
    }
}