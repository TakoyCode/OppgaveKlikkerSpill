namespace OppgaveKlikkerSpill
{
    internal class CommandSet
    {
        private ClickerGame _game;
        private List<ICommand> _commands;

        public CommandSet(ClickerGame game)
        {
            _game = game;
            _commands = new()
            {
                new CommandExit(),
                new CommandClick(_game),
                new CommandBuyUpgradeForClick(_game),
                new CommandBuyUpgradeForUpgrade(_game),
            };
        }

        public void RunCommandFirstTry(char userInput)
        {
            if (userInput == 'x') _commands[0].Run();
            else if (userInput == ' ') _commands[1].Run();
            else if (userInput == 'k') _commands[2].Run();
            else if (userInput == 's') _commands[3].Run();
        }

        public void RunCommand(char userInput)
        {
            foreach (var command in _commands)
            {
                if(command.Char == userInput) command.Run();
            }
        }
    }
}
