namespace Assignment__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Monster Hunter";

            var heroName = "oOFtIN";
            var heroWeapons = "Great Sword";
            int heroMRLevel = 99;
            float critChance = 99.5f;
            double AttackPower = 1260.5;
            bool isdieable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name   : {heroName}");
            Console.WriteLine($"Weapons     : {heroWeapons}");
            Console.WriteLine($"Level       : {heroMRLevel}");
            Console.WriteLine($"Crit Chance : {critChance}");
            Console.WriteLine($"Attack Power: {AttackPower}");
            Console.WriteLine($"Dieable    : {isdieable}");
            Console.WriteLine();

            double heroMRLevelAsDouble = heroMRLevel;
            Console.WriteLine($"Level as double (implicit): {heroMRLevelAsDouble}");

            int staminaTruncated = (int)AttackPower;              
            int staminaRounded = Convert.ToInt32(AttackPower);     
            Console.WriteLine($"Attack Power cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Attack Power Convert (rounds)  : {staminaRounded}");
        }
    }
}
