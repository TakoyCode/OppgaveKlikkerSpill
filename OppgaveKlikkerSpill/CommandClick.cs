namespace OppgaveKlikkerSpill
{
    internal class CommandClick : ICommand
    {
        private ClickerGame _game;
        public char Char { get; } = ' ';

        public CommandClick(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.Points += _game.PointsPerClick;
        }
    }
}
