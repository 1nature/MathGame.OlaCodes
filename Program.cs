namespace MathGame.OlaCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface.WelcomeMessage();
            Interface.ShowOperationMenu();
            Interface.ContinuePlaying();
            Console.WriteLine("Finished or not?");
        }
    }
}
