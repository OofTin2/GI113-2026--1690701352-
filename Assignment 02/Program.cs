/*
* Student ID : 1690701352
* Name       : Assignment_02
* Section    : 129b
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Ore = "Stellarium";
            const double smeltingRate = 0.1;
            const double salvageRate = 0.25;
            const int smeltCapacity = 1000;

            Console.WriteLine(@"------------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"| \-------------------    -----------|   -------    ________  |--------\  |------------|   ___/\___  |");
            Console.WriteLine(@"|  \----L____     __/    |   |-------| /         \ |   _____) |  |---(__) |   |====----|  |        | |");
            Console.WriteLine(@"|            )   (       | F |___      |    O    | |  R  \    |  | G ____ |  E    |        ---||---  |");
            Console.WriteLine(@"|           /     \      |   |---|     \         / |   \  \   |  |____) | |   |====____|      ||     |");
            Console.WriteLine(@"|          )_______(     |___|           -------   |___|\__\  \________/  |____________|      []     |");
            Console.WriteLine(@"------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Stellarium Smelting 0.25 / Salvage 0.3");
            Console.WriteLine("Smelting Capacity: 1000");
            Console.WriteLine("=> Key 'S' to Smelt(Ore->Ingot)");
            Console.WriteLine("=> Key 'B' to Breakdown (Ingot -> Ore)");

            bool ChoiceOk = char.TryParse(Console.ReadLine(), out char Choice);

            Console.WriteLine("How much Stellarium Ore or Ingot you want to process: ");

            bool amountOk = double.TryParse(Console.ReadLine(), out double Amount);

            if (amountOk == true && Amount > 0 && Amount <= smeltCapacity)
            {
                if (Choice == 'S' || Choice == 's')
                {
                    Console.WriteLine("You heat the Furnace and prepare to smelt the Stellarium ore into Ingot.");

                    double ingotAmount = Amount * smeltingRate;
                    Console.WriteLine($"You have smelted {Amount} Stellarium Ore into {ingotAmount} Stellarium Ingots.");
                }
                else if (Choice == 'B' || Choice == 'b')
                {
                    Console.WriteLine("You set grinder to work and prepare to breakdown the Stellarium Ingot into ore.");

                    double oreAmount = Amount / salvageRate;
                    Console.WriteLine($"You have broken down {Amount} Stellarium Ingots into {oreAmount} Stellarium Ore.");
                }
                else
                {
                    Console.WriteLine("You stand there, unsure of what to do.");
                }
            }
            else
            {
                Console.WriteLine("You put to much or too little ore/ingot.");
            }
        }

    }

}
