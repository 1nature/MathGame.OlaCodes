namespace MathGame.OlaCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface.WelcomeMessage();
            Interface.ShowOperationMenu();
            Logic.PlayGames();

            //quit game yet to be fixed
            //incorporate AI?
            //Other things like storing games
            //Adopt .Net Maui
        }
    }
}
