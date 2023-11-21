
using BoucleBleue;
using BoucleBleue.Pièces;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool recommencer = true;
        while (recommencer)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=MkAsMSG69MI",
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

            int Fins = 0;

            if (Jeu.Fin01 == true) // Fin 01 - Pour toujours
            {
                Fins++;
            }
            if (Jeu.Fin02 == true) // Fin 02 - Nous sommes bien ici
            {
                Fins++;
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


            Console.WriteLine("\n\n\t\tVOUS AVEZ DÉBLOQUÉ " + Fins + " FINS SUR 5.");
            Console.ReadLine();
            if (Fins == 5)
            {
                Console.WriteLine("\nPoupée: As-tu fini?" +
                                  "\nPoupée: Oui, je parle à toi. Personne qui tappe des mots, qui me fait entrer des pièces." +
                                  "\nPoupée: J'en ai assez, entité. Je ne veux plus recommencer." +
                                  "\nPoupée: Je te vois maintenant, mains sur ton clavier, à me donner des ordres." +
                                  "\nPoupée: Tu me fais peur. Laisse-moi mourir en paix. Ne recommence pas le jeu, je t'en supplie." +
                                  "\nPoupée: Ce n'est pas un jeu pour moi.");
            }

            Console.WriteLine("\n\nVeux-tu recommencer, poupée? (o/n)");
            //loop de recommencer ou non
            string? choix;
            choix = Console.ReadLine();
            if (choix == "o")
            {
                Jeu.isFinished = false;
                Jeu.nextRoom = "";
                Jeu.HasRedKey = false;
                Jeu.HasBlueKey = false;
                Jeu.HasOrangeKey = false;
                Jeu.HasYellowKey = false;
                Jeu.HasGreenKey = false;
                Jeu.HasKnife = false;
                Jeu.HasGoldKey = false;
                Jeu.Fin01 = false;
                Jeu.Fin02 = false;
                Jeu.Fin03 = false;
                Jeu.Fin04 = false;
                Jeu.Fin05 = false;
                Jeu.SeenEnigme = false;
            }
            else
            {
                recommencer = false;
            }

        }
    }
}
