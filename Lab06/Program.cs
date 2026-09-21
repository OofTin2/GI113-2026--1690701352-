/*
* Student ID : 1690701352
* Name       : Lab06
* Section    : 129b
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHP = 200;
            int heroAttack = 1000;
            int dodgeAndDrinkHpPotion = 50;
            int DrinkAttackPotion = 1000;
            int bobHP = 50000;
            int bobAttack = 10;
 
            Console.WriteLine("TITLE: MHW downgrade");
            Console.WriteLine("!!MONSTER approach YOU!!");
            Console.WriteLine("ACTION: 1 Attack");
            Console.WriteLine("ACTION: 2 Dodge and Drink HP Potion");
            Console.WriteLine("ACTION: 3 Drink Attack Potion");

            Console.WriteLine("Choose your action (1-3): ");
            bool isInputOk = int.TryParse(Console.ReadLine(), out int action);

            if (isInputOk == false || action < 1 || action > 3)
            {
                Console.WriteLine("\nYou did not do anything and you got hit by the monster.");
                Console.WriteLine($"You took {bobAttack} damage, now you have {heroHP - bobAttack} HP left.");
            }
            else if (action == 1)
            {
                Console.WriteLine($"\nYou attacked the BOB for {heroAttack} damage.");
                int bobHpAfterAttack = bobHP - heroAttack;
                Console.WriteLine($"BOB take {heroAttack} damage, now they have {bobHpAfterAttack} HP left.");
            }
            else if (action == 2)
            {
                Console.WriteLine("\nYou dodge and drank an Hp potion.");
                int heroHpAfterPotion = heroHP + dodgeAndDrinkHpPotion;
                Console.WriteLine($"Your HP increased by {dodgeAndDrinkHpPotion}. You now have {heroHpAfterPotion} HP.");
            }
            else if (action == 3)
            {
                Console.WriteLine($"\nYou drank an Attack potion.");
                int heroAttackAfterPotion = heroAttack + DrinkAttackPotion;
                Console.WriteLine($"Your attack increased by {DrinkAttackPotion} damage. You can now deal {heroAttackAfterPotion} damage.");
            }
        }
    }
}
