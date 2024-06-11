namespace OppgaveKlikkerSpill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clickerGame = new ClickerGame();
            var command = new CommandSet(clickerGame);

            while (true)
            {
                clickerGame.ShowMenu();
                var userCommand = Console.ReadKey().KeyChar;
                command.RunCommand(userCommand);
            }
        }
    }
}
