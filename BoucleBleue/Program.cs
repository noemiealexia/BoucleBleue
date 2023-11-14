
using BoucleBleue;
using BoucleBleue.Pièces;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        System.Diagnostics.Process.Start(new ProcessStartInfo
        {
            FileName = "https://www.youtube.com/watch?v=yz3YrfQpEM8&list=PLU4ktq2pWONu-4wKzJIXbdvNNDhVxQM3I",
            UseShellExecute = true
        });

        var game = new Jeu();

        Room Rose = new Rose();
        Room Jaune = new Jaune();
        Room Bleue = new Bleue();
        Room Noire = new Noire();
        Room Blanche = new Blanche();
        Room Coffre = new Coffre();
        Room Fin = new Fin();

        game.Add(Blanche);
        game.Add(Bleue);
        game.Add(Coffre);
        game.Add(Jaune);
        game.Add(Noire);
        game.Add(Rose);
        game.Add(Fin);

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

        if (Jeu.Fin01 == true) // Fin 01 - Pour toujours
        {
            Fins++;
        }

        if (Jeu.Fin02 == true) // Fin 02 - Nous sommes bien ici
        {
            Fins ++;        
        }
        if (Jeu.Fin03 == true) // Fin 03 - Mauvais choix
        {
            Fins++;
        }
        if (Jeu.Fin04 == true) // Fin 04 - Fin normale
        { 
            Fins++; 
        }
        if (Jeu.Fin05 == true) // Fin 05 - Vraie fin
        {
            Fins++;
        }


        Console.WriteLine("\n\n\t\tVOUS AVEZ DÉBLOQUÉ " + Fins +" FINS SUR 5.");
        Console.ReadLine();
        Console.WriteLine("\n\nVeux-tu recommencer, poupée? (o/n)");
        //loop de recommencer ou non

    }
}