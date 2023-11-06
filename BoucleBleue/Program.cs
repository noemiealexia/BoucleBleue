
using BoucleBleue;
using BoucleBleue.Pièces;

class Program
{
    static void Main(string[] args)
    {
        var game = new Jeu();

        Room Rose = new Rose();
        Room Jaune = new Jaune();
        Room Bleue = new Bleue();
        Room Noire = new Noire();
        Room Blanche = new Blanche();
        Room GardeRobe = new GardeRobe();

        game.Add(Blanche);
        game.Add(Bleue);
        game.Add(GardeRobe);
        game.Add(Jaune);
        game.Add(Noire);
        game.Add(Rose);

        game.SetCurrentRoom(Rose);

        while (!game.IsGameOver())
        {
            Console.WriteLine("--");
            game.CurrentRoomDescription();
            string? choice = Console.ReadLine()?.ToLower() ?? "";
            Console.Clear();
            game.ReceiveChoice(choice);
            game.CheckTransition();
        }

        Console.WriteLine("FIN");
        Console.ReadLine();
    }
}