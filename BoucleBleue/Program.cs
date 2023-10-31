
using BoucleBleue;
using BoucleBleue.Pièces;

var game = new Jeu();
game.Add(new Blanche());
game.Add(new Bleue());
game.Add(new GardeRobe());
game.Add(new Jaune());
game.Add(new Noire());
game.Add(new Rose());

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

            Console.WriteLine("FIN");
            Console.ReadLine();
     
