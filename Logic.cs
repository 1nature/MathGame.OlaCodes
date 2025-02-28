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
                    score++;
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
                    score++;
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
                    score++;

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
               
                    int firstNum = random.Next(1, 99);
                    int secondNum = random.Next(1, 99);

                while (firstNum % secondNum == 0)
                {
                    Interface.ShowDivisionMessage(firstNum, secondNum);
                    int answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == firstNum / secondNum)
                    {
                        Interface.ShowCorrectAnswerMessage(answer);
                        score++;
                    }
                    else
                    {
                        Interface.ShowIncorrectAnswerMessage();
                        score++;

                    }
                }
            }
            Interface.ShowGameOverMessage(score, numberOfRounds);
        }

        //Need to break this up into 2

    }
}
