namespace Escape
{
    public class FightGuard : IFights
    {
        public string FightGuards(string path)
        {
            string[] attackOptions = { "slash", "stab", "block", "dodge" };
            Random random = new Random();

            string guardAttack = attackOptions[random.Next(attackOptions.Length)];
            string userAttack;

            do
            {
                Console.WriteLine($"The guard appears on the {path} path!\n");
                Console.WriteLine("He gives you a sword. You have to fight him!\n");

                Console.WriteLine("Choose your attack: slash, stab, block, dodge");

                Console.Write(">> ");
                userAttack = Console.ReadLine().ToLower();

                if (Array.IndexOf(attackOptions, userAttack) == -1)
                {
                    Console.WriteLine("Invalid attack option. Try again.\n");
                }
            } while (Array.IndexOf(attackOptions, userAttack) == -1);

            Console.WriteLine($"You chose '{userAttack}' and the guard chose '{guardAttack}'.");

            // Implement logic to determine the outcome of the fight
            string fightResult = DetermineFightOutcome(userAttack, guardAttack);

            return fightResult;
        }

        public string DetermineFightOutcome(string userAttack, string guardAttack)
        {
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