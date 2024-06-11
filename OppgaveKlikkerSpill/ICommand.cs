namespace OppgaveKlikkerSpill
{
    internal interface ICommand
    {
        char Char { get; }

        void Run();
    }
}
