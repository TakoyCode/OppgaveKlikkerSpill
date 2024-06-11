namespace OppgaveKlikkerSpill
{
    internal class CommandBuyUpgradeForUpgrade : ICommand
    {
        private ClickerGame _game;
        public char Char { get; } = 's';

        public CommandBuyUpgradeForUpgrade(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            if (_game.Points >= 100)
            {
                _game.Points -= 100;
                _game.PointsPerClickIncrease++;
            }
        }
    }
}
