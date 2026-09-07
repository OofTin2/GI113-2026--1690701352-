/*
 * Student ID : 1690701352
 * Name       : Lab04
 * Section    : 129b
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|      RATE THIS LEVEL       |");
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("rate this level (0.0-5.0): ");
            bool isValid1 = double.TryParse(Console.ReadLine(), out double rating);
            Console.WriteLine($"Valid input: {isValid1}");
            Console.WriteLine($"Rating: {rating}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");
        }
    }
}
