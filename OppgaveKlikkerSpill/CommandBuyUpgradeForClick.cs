namespace OppgaveKlikkerSpill
{
    internal class CommandBuyUpgradeForClick : ICommand
    {
        private ClickerGame _game;
        public char Char { get; } = 'k';


        public CommandBuyUpgradeForClick(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            if (_game.Points >= 10)
            {
                _game.Points -= 10;
                _game.PointsPerClick += _game.PointsPerClickIncrease;
            }
        }
    }
}
