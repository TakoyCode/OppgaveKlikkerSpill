namespace OppgaveKlikkerSpill
{
    internal class CommandExit : ICommand
    {
        public char Char { get; } = 'x';

        public void Run()
        {
            Environment.Exit(404);
        }
    }
}
