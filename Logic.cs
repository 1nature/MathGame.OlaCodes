namespace MathGame.OlaCodes
{
    internal class Logic
    {
        public static List<string> Addition()
        {
            Random random = new Random();
            List<string> gameHistory = new List<string>();
            string gameName = "Addition";

            int score = 0;

            Interface.ShowPlayTimesMessage();
            int numberOfRounds = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfRounds; i++)
            {
                int firstNum = random.Next(1, 9);
                int secondNum = random.Next(1, 9);

                Interface.ShowAdditionMessage(firstNum, secondNum);
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == firstNum + secondNum)
                {
                    Interface.ShowCorrectAnswerMessage(answer);
                    score++;
                }
                else
                {
                    Interface.ShowIncorrectAnswerMessage();
                }
            }
            Interface.ShowGameOverMessage(score, numberOfRounds);

            gameHistory.Add($"{gameName} game: Played {numberOfRounds} times, " +
                    $"Final score = {score}/{numberOfRounds}.");
            

            return gameHistory;

            //foreach (string game in gameHistory)
            //{
            //    Console.WriteLine(game);
            //}

            
        }

        public static List<string> Multiplication()
        {
            Random random = new Random();
            int score = 0;

            List<string> gameHistory = new List<string>();
            string gameName = "Multiplication";


            Interface.ShowPlayTimesMessage();
            int numberOfRounds = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfRounds; i++)
            {
                int firstNum = random.Next(1, 9);
                int secondNum = random.Next(1, 9);
                Interface.ShowMultiplicationMessage(firstNum, secondNum);
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == firstNum * secondNum)
                {
                    Interface.ShowCorrectAnswerMessage(answer);
                    score++;
                }
                else
                {
                    Interface.ShowIncorrectAnswerMessage();
                }

            }
            Interface.ShowGameOverMessage(score, numberOfRounds);

            gameHistory.Add($"{gameName} game: Played {numberOfRounds} times, " +
                   $"Final score = {score}/{numberOfRounds}.");


            return gameHistory;
            //Each game has to RETURN something, maybe a string
            //That will be used to form somethi
        }

        public static List<string> Subtraction()
        {
            Random random = new Random();
            List<string> gameHistory = new List<string>();
            string gameName = "Subtraction";

            int score = 0;

            Interface.ShowPlayTimesMessage();
            int numberOfRounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRounds; i++)
            {
                int firstNum = random.Next(1, 9);
                int secondNum = random.Next(1, 9);

                Interface.ShowSubtractionMessage(firstNum, secondNum);
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == firstNum - secondNum)
                {
                    Interface.ShowCorrectAnswerMessage(answer);
                    score++;
                }
                else
                {
                    Interface.ShowIncorrectAnswerMessage();
                }
            }
            Interface.ShowGameOverMessage(score, numberOfRounds);

            gameHistory.Add($"{gameName} game: Played {numberOfRounds} times, " +
                  $"Final score = {score}/{numberOfRounds}.");


            return gameHistory;
        }

        public static List<string> Division()
        {
            Random random = new Random();
            List<string> gameHistory = new List<string>();
            string gameName = "Division";

            int score = 0;

            Interface.ShowPlayTimesMessage();
            int numberOfRounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRounds; i++)
            {

                var divisionNumbers = GetDivisionNumbers();
                Interface.ShowDivisionMessage(divisionNumbers[0], divisionNumbers[1]);
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == divisionNumbers[0] / divisionNumbers[1])
                {
                    Interface.ShowCorrectAnswerMessage(answer);
                    score++;
                }
                else
                {
                    Interface.ShowIncorrectAnswerMessage();
                }


            }
            Interface.ShowGameOverMessage(score, numberOfRounds);
            gameHistory.Add($"{gameName} game: Played {numberOfRounds} times, " +
                 $"Final score = {score}/{numberOfRounds}.");


            return gameHistory;
        }

        public static int[] GetDivisionNumbers()
        {
            Random random = new Random();

            int firstNum = random.Next(1, 99);
            int secondNum = random.Next(1, 99);

            var result = new int[2];

            while (firstNum % secondNum != 0)
            {
                firstNum = random.Next(1, 99);
                secondNum = random.Next(1, 99);
               
            }

            result[0] = firstNum;
            result[1] = secondNum;

            return result;
        }

        public static void GameOptions()
        {
            string choice = Interface.SelectGameOption();
            List<string> storeGames = new List<string>();

            switch (choice)
            {
                case "A":
                    storeGames = Addition();
                    Interface.ShowGamesHistory(storeGames);
                    break;
                case "B":
                    storeGames = Subtraction();
                    Interface.ShowGamesHistory(storeGames);
                    break;
                case "C":
                    storeGames = Multiplication();
                    Interface.ShowGamesHistory(storeGames);
                    break;
                case "D":
                    storeGames = Division();
                    Interface.ShowGamesHistory(storeGames);
                    break;
                case "E":
                    break;
                default:
                    Interface.ShowWrongInputMessage();
                    break;
            }
            Interface.QuitGameMessage(choice);
        }

    }
}
