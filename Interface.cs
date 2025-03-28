﻿namespace MathGame.OlaCodes
{
    internal class Interface
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Hello! This is your math's game. " +
               "That's great that you're working on improving yourself'\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void ShowOperationMenu()
        {
            Console.WriteLine("Please select an operation or exit the game: \n" +
                "\nA = Addition Game," +
                "\nB = Subtraction Game," +
                "\nC = Multiplication Game," +
                "\nD = Division Game" +
                "\nE = Quit");
        }

        public static void ContinuePlaying()
        {
            string option = Logic.GameOptions();
            

            Console.WriteLine("Enter 'Y' to play another game or 'N' to quit");
            string answer = Console.ReadLine().ToUpper();
            while (answer == "Y")
            {
                Logic.GameOptions();
            }

            while (answer == "N" || answer != "Y")
            {
                Console.WriteLine("You decided to quit");
                break;
            }

            
        }

        public static void ShowPlayTimesMessage() 
        {
            Console.WriteLine("How many times do you want to play: ");
        }

        public static void ShowAdditionMessage(int num_1, int num_2) 
        {
            Console.WriteLine($"What is {num_1} + {num_2}");
        }

        public static void ShowMultiplicationMessage(int num_1, int num_2)
        {
            Console.WriteLine($"What is {num_1} * {num_2}");
        }

        public static void ShowSubtractionMessage(int num_1, int num_2)
        {
            Console.WriteLine($"What is {num_1} - {num_2}");
        }

        public static void ShowDivisionMessage(int num_1, int num_2)
        {
            Console.WriteLine($"What is {num_1} / {num_2}");
        }

        public static void ShowCorrectAnswerMessage(int answer)
        {
            Console.WriteLine($"Your answer was correct. {answer}");
        }

        public static void ShowIncorrectAnswerMessage()
        {
            Console.WriteLine($"Your answer was incorrect.");
        }

        public static void ShowGameOverMessage(int score, int rounds)
        {
            Console.WriteLine($"Game over. Your final score is {score} out of {rounds}");
        }

        public static void ShowWrongInputMessage()
        {
            Console.WriteLine("You entered a wrong input");
        }

        public static string SelectGameOption()
        {
            Console.WriteLine("Select the Game you want to play: ");
            string selectedGame = Console.ReadLine().ToUpper();
            return selectedGame;
        }

        public static void QuitGameMessage(string choice)
        {
            if (choice == "E")
            {
                Console.WriteLine("You quit");
            }
        }

        public static void ShowGamesHistory(List<string>history)
        {
            foreach (string game in history)
            {
                Console.WriteLine(game);
            }
            // List<string> gameHistory = new List<string>();
        }

    }
}
