namespace Escape
{
    public class AnimalRoom : IAnimals
    {
        public void AnimalChoice()
        {
            List<string> seaAnimals = new() { "Fish", "Sea Turtle", "Octopus", "Shark", "Dolphin" };

            Console.WriteLine("You are in a room filled with sea animals. You can choose one of them. That's your first task.\n");
            Console.WriteLine("\nChoose a sea animal:");

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
                    Console.WriteLine($"You chose {chosenAnimal}! Let's see if you can get out of this room.\n");

                    AskQuizQuestion(chosenAnimal); // Call the method to ask quiz question
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }

        public void AskQuizQuestion(string chosenAnimal)
        {
            // Define quiz questions and answers based on the chosen animal
            Dictionary<string, Tuple<string, string>> quizData = new Dictionary<string, Tuple<string, string>>
    {
        { "Fish", new Tuple<string, string>("Question about fish: What is the largest species of fish?", "Whale Shark") },
        { "Sea Turtle", new Tuple<string, string>("Question about sea turtles: How many species of sea turtles are there?", "7") },
        { "Octopus", new Tuple<string, string>("Question about octopuses: How many hearts does an octopus have?", "3") },
        { "Shark", new Tuple<string, string>("Question about sharks: What is the largest species of shark?", "Whale Shark") },
        { "Dolphin", new Tuple<string, string>("Question about dolphins: What is the maximum speed a dolphin can reach?", "60 km/h") }
    };

            if (quizData.TryGetValue(chosenAnimal, out var questionAndAnswer))
            {
                string question = questionAndAnswer.Item1;
                string correctAnswer = questionAndAnswer.Item2;

                while (true)
                {
                    Console.WriteLine(question);
                    Console.Write("Your answer: ");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Correct! You've completed the quiz successfully.");
                        break; // Exit the loop when the user gives the correct answer
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer. Try again.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid animal choice for quiz questions.");
            }
        }

    }
}