/*
 * Student ID : 1690701352
 * Name       : Lab02
 * Section    : 129b
 * No.        : N/A
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
            Console.WriteLine($"Name; {bossName}");
            Console.WriteLine($"Rank; {rank}");
            Console.WriteLine($"Hp; {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power; {attackPower}");
            Console.WriteLine($"Is Boss; {isBoss}");

            int hpPercent = currentHp * 100 / maxHp; // คำนวณเปอร์เซ็น
            Console.WriteLine($"Hp Percent; {hpPercent}");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp = 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE ====="); 
            Console.WriteLine($"HP: {currentHp}/{maxHp}"); hpPercent = currentHp * 100 / maxHp; 
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine($"===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Hp; {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}$");

            string bossName2 = "Mamar";
            char rank2 = 'Z';
            int level2 = 999999999;
            int maxHp2 = 999999999;
            int currentHp2 = 999999999;
            float attackPower2 = 999999999.999999999f;
            double critMultiplier2 = 999999999.999999999;
            bool isBoss2 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name; {bossName2}");
            Console.WriteLine($"Rank; {rank2}");
            Console.WriteLine($"Hp; {currentHp2} / {maxHp2}");
            Console.WriteLine($"Attack Power; {attackPower2}");
            Console.WriteLine($"Is Boss; {isBoss2}");

            string bossName3 = "Tutu";
            char rank3 = 'S';
            int level3 = 777;
            int maxHp3 = 777;
            int currentHp3 = 707;
            float attackPower3 = 777.777f;
            double critMultiplier3 = 77.7;
            bool isBoss3 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name; {bossName3}");
            Console.WriteLine($"Rank; {rank3}");
            Console.WriteLine($"Hp; {currentHp3} / {maxHp3}");
            Console.WriteLine($"Attack Power; {attackPower3}");
            Console.WriteLine($"Is Boss; {isBoss3}");

            string bossName4 = "Bob";
            char rank4 = 'F';
            int level4 = 10;
            int maxHp4 = 50;
            int currentHp4 = 2;
            float attackPower4 = 7.5f;
            double critMultiplier4 = 1.5;
            bool isBoss4 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name; {bossName4}");
            Console.WriteLine($"Rank; {rank4}");
            Console.WriteLine($"Hp; {currentHp4} / {maxHp4}");
            Console.WriteLine($"Attack Power; {attackPower4}");
            Console.WriteLine($"Is Boss; {isBoss4}");

            string bossName5 = "Bob the god slayer";
            char rank5 = 'A';
            int level5 = 500;
            int maxHp5 = 5000;
            int currentHp5 = 4500;
            float attackPower5 = 500.005f;
            double critMultiplier5 = 500.005;
            bool isBoss5 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name; {bossName5}");
            Console.WriteLine($"Rank; {rank5}");
            Console.WriteLine($"Hp; {currentHp5} / {maxHp5}");
            Console.WriteLine($"Attack Power; {attackPower5}");
            Console.WriteLine($"Is Boss; {isBoss5}");
        }
    }
}
