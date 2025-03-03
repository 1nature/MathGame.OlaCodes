using MathGame.OlaCodes;
using static System.Formats.Asn1.AsnWriter;

namespace MathGame.OlaCodes
{
    internal class Logic
    {
        public static void Addition()
        {
            Random random = new Random();

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
        }

        public static void Multiplication()
        {
            Random random = new Random();
            int score = 0;
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
        }

        public static void Subtraction()
        {
            Random random = new Random();

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
        }

        public static void Division()
        {
            Random random = new Random();

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

        public static void PlayGames()
        {
            string choice = Interface.SelectGameOption();

            switch (choice)
            {
                case "A":
                    Logic.Addition();
                    break;
                case "B":
                    Logic.Subtraction();
                    break;
                case "C":
                    Logic.Multiplication();
                    break;
                case "D":
                    Logic.Division();
                    break;
                default:
                    Interface.ShowWrongInputMessage();
                    break;
            }
        }

    }
}
