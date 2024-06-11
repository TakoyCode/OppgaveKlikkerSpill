namespace OppgaveKlikkerSpill
{
    internal class ClickerGame
    {
        public int Points;
        public int PointsPerClick = 1;
        public int PointsPerClickIncrease = 1;

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:");
            Console.WriteLine("- SPACE = klikk (og få poeng)");
            Console.WriteLine("- k = kjøp oppgradering øker poeng per klikk. koster 10 poeng");
            Console.WriteLine("- s = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng");
            Console.WriteLine("- x = avslutt applikasjonen");
            Console.WriteLine($"Du har {Points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
        }

    }
}
