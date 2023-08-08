namespace Escape
{
    public class FightGuard : IFights
    {
        Map map = new Map();

        public string FightGuards(string path)
        {
            string[] attackOptions = { "slash", "stab", "block", "dodge" };
            Random random = new Random();

            string guardAttack = attackOptions[random.Next(attackOptions.Length)];
            string userAttack;
            bool guardCounterattack = false;

            do
            {
                Console.WriteLine($"The guard appears on the {path} path!\n");
                Console.WriteLine("He gives you a sword. You have to fight him!\n");

                if (guardCounterattack)
                {
                    Console.WriteLine("The guard is countering your attack!\n");
                }

                Console.WriteLine("Choose your attack: slash, stab, block, dodge");

                Console.Write(">> ");
                userAttack = Console.ReadLine().ToLower();

                if (Array.IndexOf(attackOptions, userAttack) == -1)
                {
                    Console.WriteLine("Invalid attack option. Try again.\n");
                }
                else if (guardCounterattack && (userAttack == "block" || userAttack == "dodge"))
                {
                    Console.WriteLine("You can't block or dodge during the guard's counterattack!\n");
                }
            } while (Array.IndexOf(attackOptions, userAttack) == -1 || (guardCounterattack && (userAttack == "block" || userAttack == "dodge")));

            Console.WriteLine($"You chose '{userAttack}' and the guard chose '{guardAttack}'.");

            // Implement logic to determine the outcome of the fight
            string fightResult = DetermineFightOutcome(userAttack, guardAttack);
            Console.WriteLine(fightResult); // display the fight result

            // Check if the guard countered the user's attack
            guardCounterattack = fightResult == "The guard dodged your attack and counterattacked!" || fightResult == "The guard blocked your attack and is preparing to strike back!";

            // If the user lost, they have to choose their attack again
            while (fightResult == "The guard dodged your attack and counterattacked!" || fightResult == "The guard blocked your attack and is preparing to strike back!")
            {
                Console.WriteLine("The guard counters your attack! Choose your attack: slash, stab, block, dodge");
                Console.Write(">> ");
                userAttack = Console.ReadLine().ToLower();

                if (Array.IndexOf(attackOptions, userAttack) == -1)
                {
                    Console.WriteLine("Invalid attack option. Try again.\n");
                }
                else if (guardCounterattack && (userAttack == "block" || userAttack == "dodge"))
                {
                    Console.WriteLine("You can't block or dodge during the guard's counterattack!\n");
                }

                Console.WriteLine($"You chose '{userAttack}' and the guard chose '{guardAttack}'.");
                fightResult = DetermineFightOutcome(userAttack, guardAttack);
                Console.WriteLine(fightResult); // display the fight result
                guardCounterattack = fightResult == "The guard dodged your attack and counterattacked!" || fightResult == "The guard blocked your attack and is preparing to strike back!";
            }

            return fightResult;
        }

        public string DetermineFightOutcome(string userAttack, string guardAttack)
        {
            map.Weapons();

            if (userAttack == guardAttack)
            {
                return "The fight ends in a draw.";
            }
            else if ((userAttack == "slash" && guardAttack == "stab") ||
                     (userAttack == "stab" && guardAttack == "block") ||
                     (userAttack == "block" && guardAttack == "dodge") ||
                     (userAttack == "dodge" && guardAttack == "slash"))
            {
                return "You win the fight!";
            }
            else if ((userAttack == "slash" && guardAttack == "dodge") ||
                     (userAttack == "stab" && guardAttack == "slash") ||
                     (userAttack == "block" && guardAttack == "stab") ||
                     (userAttack == "dodge" && guardAttack == "block"))
            {
                return "The guard dodged your attack and counterattacked!";
            }
            else if ((userAttack == "slash" && guardAttack == "block") ||
                     (userAttack == "stab" && guardAttack == "dodge") ||
                     (userAttack == "block" && guardAttack == "slash") ||
                     (userAttack == "dodge" && guardAttack == "stab"))
            {
                return "The guard blocked your attack and is preparing to strike back!";
            }
            else
            {
                return "The guard wins the fight.";
            }
        }
    }
}
