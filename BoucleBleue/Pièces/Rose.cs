using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Rose : Room
    {
        internal override void ViewDescription()
        {
            if (Jeu.HasRedKey)
            {
                Console.WriteLine(@"Quand tu retournes dans la chambre 'rose', elle n'est plus rose.
                 Tu ne vois plus le rose. La chambre est devenue trop sombre, les fleurs de décoration sont devenues fanées, leurs pétales sont sur le sol. Les dessins des papillons, qui étaient en train de voler, sont des dessins d'insectes morts. Tu es pris de frissons, mais tu restes calme et tu essayes de passer dans la prochaine chambre.
                [porte bleue] [porte jaune]");

            }
            else
            {
                Console.WriteLine(@"Tes yeux s'ouvrent sur une belle chambre rose.
                À côté de toi se trouvent de beaux meubles,
                décorés de fleurs et de dessins de papillons.
                Tu contemples cette piéce avant d'apercevoir deux portes.
                [porte bleue] [porte jaune]");

            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte bleue":
                    if (Jeu.HasBlueKey)
                    {
                        Console.WriteLine("Tu déverouilles la porte bleue et tu y entres.");
                        Jeu.nextRoom = "Bleue";
                    }
                    else
                    {
                        Console.WriteLine("La porte est verrouillée.");
                    }
                    break;
                case "porte jaune":
                    Console.WriteLine("Tu ouvres la porte et entre dans la chambre jaune.");
                    // nextRoomToGo = "Jaune";
                    Jeu.nextRoom = "Jaune";
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }

    }
}
