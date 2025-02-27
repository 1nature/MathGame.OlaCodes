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
                int secondNum = random.Next(1, 19);

                if (firstNum > secondNum || firstNum == secondNum)
                {
                    Interface.ShowSubtractionMessage(firstNum, secondNum);
                }
                else if (secondNum > firstNum)
                {
                    Interface.ShowSubtractionMessage(secondNum, firstNum);
                }

                // should not need a condition showing which is greater btw firstNum & secondNum?
                int answer = Convert.ToInt32(Console.ReadLine());

                if (firstNum > secondNum || firstNum == secondNum)
                {
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
                else if (secondNum > firstNum)
                {
                    if (answer == secondNum - firstNum)
                    {
                        Interface.ShowCorrectAnswerMessage(answer);
                        score++;
                    }
                    else 
                    { Interface.ShowIncorrectAnswerMessage();
                        score++;
                    }
                }
                
            }
            Interface.ShowGameOverMessage(score, numberOfRounds);
        }
    }
}
