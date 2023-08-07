// creating a Room class that will be used to create many rooms in the game. Wich means different methods.
using System.Threading;

namespace Escape
{
    public class Room : ICartography
    {
        private string _userName;
        Map map = new Map();
        Tips tips = new Tips();
        FightGuard fightGuard = new FightGuard();

        public Room(string userName)
        {
            _userName = userName;
        }


        public void UserName()
        {
            Console.WriteLine($"Welcome {_userName} to the great escape game ever created.");
            Thread.Sleep(1000);

            Console.WriteLine($"You're now called: '{_userName}'!\n");
            Console.WriteLine("Let's start!\n");
            Console.WriteLine("You have been challenged to manage to get out of the building you are currently in.\n");
            Console.WriteLine("To start, you will have to solve a challenge. To do so, type 'start'.\n");
            Thread.Sleep(1000);

            string userInput = Console.ReadLine();

            if (userInput == "start")
            {
                FirstRoom();
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("You are a coward. Goodbye!");
                Thread.Sleep(3000);
            }
        }

        public void FirstRoom()
        {
            map.Cart();
            Console.WriteLine("You are in a dark room. There is a door to your right (red) and left (blue).\n");
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("Type 'r' to go right or 'l' to go left.\n");
            string userInput = Console.ReadLine();

            if (userInput == "r")
            {
                Console.WriteLine("The room you steped in is red, like it was painted with blood.\n");
                Console.WriteLine("You freaked out and managed to get out of the red room before the door closed itself.\n");
                Thread.Sleep(2000);
                BlueRoom();
            };
            if (userInput == "l")
            {
                BlueRoom();
                Thread.Sleep(2000);
            }
        }

        public void BlueRoom()
        {
            Console.WriteLine($"\nCongratulations, \"{_userName}\", you made the right choice. Maybe the color of the door gave it away.");
            Console.WriteLine("\nAn old man is standing in front of you. He says, 'Welcome to the room, stranger.'\n");
            Thread.Sleep(2000);

            map.OldMan();
            Thread.Sleep(2000);

            Console.WriteLine("\n\"In order to get out of this room, you have to answer a difficult riddle.\" he says.\n");
            Console.WriteLine("\"Spelled forwards I’m what you do every day, spelled backward I’m something you hate. What am I?\"");

            while (true)
            {
                string answer = "live";
                Console.Write(">> ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == answer)
                {
                    Console.WriteLine("\"You are correct! You are now free to leave the room,\" he says with a deep voice.\n");
                    Thread.Sleep(2000);
                    break;
                }
                else if (userInput != answer)
                {
                    Console.WriteLine("\"You are wrong. Try again.\" he says.\n");
                    Console.WriteLine("\"Do you want a Tip? (y or n)\", he asks\n");

                    Console.Write(">> ");
                    string tip = Console.ReadLine().ToLower();

                    if (tip == "y")
                    {
                        tips.FirstRoomTips("Try to think about the opposie of 'die'.");
                    }
                    else if (tip == "n")
                    {
                        Console.WriteLine("\"Alright. Good luck then!\"");
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("You have to answer the riddle if you want to leave the room.\n");
                    Thread.Sleep(4000);
                }
            }
        }

        public string TreeRoom()
        {
            Console.WriteLine("Full of happiness, you leave the room and the old man.\n\n");
            Console.WriteLine("Suddenly, you are not in a dark room anymore. You are in a forest... or what looks like a forest...\n");
            Console.WriteLine("In front of you stands a tree. You can see a path to the left and right.\n\n");

            map.Tree();
            Thread.Sleep(4000);

            Console.WriteLine("As you try to take a road, you see two guards standing in front of each path.\n\n");

            map.Guards();
            Thread.Sleep(2000);

            Console.WriteLine("\nA voice then echoes from the tree.\n");

            string userChoice;
            string result = "";

            do
            {
                Console.WriteLine("Choose a path: 'left' or 'right'? (Write 'l' or 'r')\n");

                Console.Write(">> ");
                userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "l":
                        result = fightGuard.FightGuards("left", "slash", "stab", "block", "dodge");
                        break;

                    case "r":
                        result = fightGuard.FightGuards("right", "slash", "stab", "block", "dodge");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. You stumble and lose your way. Try again.\n");
                        break;
                }
            } while (userChoice != "l" && userChoice != "r");

            return result;
        }

        public void SeaAnimalRoom()
        {
            List<string> seaAnimals = new List<string> { "Fish", "Sea Turtle" };

            Console.WriteLine("Welcome to the Sea Animal Room! Choose a sea animal:");

            for (int i = 0; i < seaAnimals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {seaAnimals[i]}");
            }

            int userChoice;

            while (true)
            {
                Console.Write(">> ");
                if (int.TryParse(Console.ReadLine(), out userChoice) && userChoice >= 1 && userChoice <= seaAnimals.Count)
                {
                    string chosenAnimal = seaAnimals[userChoice - 1];
                    Console.WriteLine($"You chose {chosenAnimal}! Something happens...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }
    }
}