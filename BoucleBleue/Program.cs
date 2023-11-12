
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
        Room Coffre = new Coffre();

        game.Add(Blanche);
        game.Add(Bleue);
        game.Add(Coffre);
        game.Add(Jaune);
        game.Add(Noire);
        game.Add(Rose);

        game.SetCurrentRoom(Rose);

        while (!game.IsGameOver())
        {
            Console.WriteLine(" ");
            game.CurrentRoomDescription();
            string? choice = Console.ReadLine()?.ToLower() ?? "";
            Console.Clear();
            game.ReceiveChoice(choice);
            game.CheckTransition();
        }

        int Fins= 0;

        if (Jeu.Fin01 == true) //fin terrifiante = pour toujours
        {
            Fins++;
        }
        if (Jeu.Fin02 == true) //fin normale
        {
            Fins ++;        
        }
        if (Jeu.Fin03 == true) //vraie fin
        {
            Fins++;
        }

        Console.WriteLine("\n\n\t\tVOUS AVEZ DÉBLOQUÉ " + Fins +" FINS SUR 3.");
        Console.ReadLine();
        Console.WriteLine("\n\nVeux-tu recommencER, poupée? (o/n)");
        //loop de recommencer ou non

    }
}