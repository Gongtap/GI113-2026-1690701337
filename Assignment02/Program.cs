/*
 * Student ID :1690701337
 * Name       :Gongtap Panawas
 * Section    :129B
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Copper";
            const double SmeltingRate = 0.35;
            const double SalvageRate = 0.5;
            const double MaxBatch = 200;


            Console.WriteLine("               |------------------|                                  |---|             ");
            Console.WriteLine("               |-   THE FORGE    -|                                  |   |======*        ");
            Console.WriteLine("               |------------------|                                  |---|             ");
            Console.WriteLine(" ________________________________________________________");
            Console.WriteLine("|Menu                                                    |       ____________         ");
            Console.WriteLine($"|Iron Smelting {SmeltingRate} / Salvage {SalvageRate}                        |      |            |        ");
            Console.WriteLine("|Key 'S' for Smelt (Ore -> Ingot)                        |      |=__________=|        ");
            Console.WriteLine("|Key 'B' for Breakdown (Ingot -> Ore)                    |       |__________|         ");
            Console.WriteLine("|________________________________________________________|");
            Console.Write("Choose Menu: ");
            bool isKeyValid = char.TryParse(Console.ReadLine(), out char Key);
           
            if (isKeyValid)
            {
                Console.Write("How much you like:");
                bool isAmountValid = double.TryParse(Console.ReadLine(), out double amount);
                
                if (isAmountValid == true && 0 < amount && amount <= MaxBatch)
                {
                    if (Key == 'S' || Key == 's')
                    {
                        double result = amount * SmeltingRate;
                        Console.WriteLine($"{amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} ingot");
                    }
                    else if (Key == 'B' || Key == 'b')
                    {
                        double result = amount / SalvageRate;
                        Console.WriteLine($"{amount:F2} {MaterialName} ingot = {result:F2} {MaterialName} Ore");
                    }
                    else
                    {
                        Console.WriteLine("error: Invalid  Key");
                    }
                }
                else 
                {
                    Console.WriteLine("error: Invalid Amount");
                }
            }
            else
            {
                Console.WriteLine("error: Invalid Amount");
            }
        }
    }
}
