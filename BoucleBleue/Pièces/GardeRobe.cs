using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class GardeRobe : Room
    {
        internal override void ViewDescription()
        {
            Console.WriteLine("Le garde-robe semble normal au départ. Tu vois 2 clés, une rouge, grande, et une bleue, très petite. Dès que tu les prends, les ours en peluche deviennent vivants et t'enferment dans le garde-robe. Un liquide noir coule sur les murs, tu entends une voix rire. Tu pousses la porte du garde-robe, mais tu n'arrives pas à l'ouvrir.");

            Jeu.HasRedKey = true;
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cle rouge":
                        Console.WriteLine("La clé rouge est juste assez grande pour passer à travers la petite ouverture inégale et pousser la porte du garde-robe.");

                        Jeu.nextRoom = "Jaune";
                    break;
                case "cle bleue":
                    Console.WriteLine("La clé est trop petite pour faire quoi que ce soit.");
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }

    }
}
