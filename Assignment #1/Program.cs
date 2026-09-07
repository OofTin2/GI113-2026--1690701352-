namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Monster Hunter";

            int HunterRank = 999;
            int Health = 120;
            int Stamina = 100;
            var WeaponsTypeBonus = "Less Phys Damage Taken";
            double AttackPower = 1260.5;
            var Sharpness = "|=|=====/";
            float Affinity = 99.5f;
            var Element = "None";
            bool isdieable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Level       : {HunterRank}");
            Console.WriteLine($"Health      : {Health}");
            Console.WriteLine($"Stamina     : {Stamina}");
            Console.WriteLine($"Weapons     : {WeaponsTypeBonus}");
            Console.WriteLine($"===== ATTACK STATS =====");
            Console.WriteLine($"Attack Power: {AttackPower}");
            Console.WriteLine($"Affinity    : {Affinity}");
            Console.WriteLine($"Element     : {Element}");
            Console.WriteLine($"Dieable     : {isdieable}");
            Console.WriteLine();

            double HunterRankAsDouble = HunterRank;
            Console.WriteLine($"Level as double (implicit): {HunterRankAsDouble}");

            int staminaTruncated = (int)AttackPower;              
            int staminaRounded = Convert.ToInt32(AttackPower);     
            Console.WriteLine($"Attack Power cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Attack Power Convert (rounds)  : {staminaRounded}");
        }
    }
}
