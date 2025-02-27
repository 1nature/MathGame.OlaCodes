using System.Security.Cryptography.X509Certificates;

namespace MathGame.OlaCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface.WelcomeMessage();
            Interface.ShowOperationMenu();
            //Logic.Addition();
            //Logic.Multiplication();
            Logic.Subtraction();
        }
    }
}
