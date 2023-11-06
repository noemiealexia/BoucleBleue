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
                Console.WriteLine("\n\tTu retournes dans la chambre rose. " +
                    "\n\tElle n'est plus rose. Les murs sont noirs maintenant. " +
                    "\n\tLes lumières qui éclairaient la pièce semblent sombres maintenant. Tu as du mal à voir autour de toi. " +
                    "\n\tLorsque tes yeux s'ajustent, tu vois les fleurs maintenant fannées, leurs pétales sur le sol." +
                    "\n\tLes papillons qui volaient autour de toi sont morts. Tu regardes les insectes immobiles sur le sol qui ne voleront plus jamais. " +
                    "\n\tIl n'y a plus de joie dans cette pièce. Tu frissonnes, tu n'as pourtant pas froid. Tu te demandes ce qui se passe." +
                    "\n\tAu sud, tu aperçois la [porte bleue]. À l'ouest, la [porte jaune].\n");

            }
            else
            {
                Console.WriteLine("\n\tTes yeux de poupée s'ouvrent sur une belle chambre rose. " +
                    "\n\tLa pièce est adornée de beaux meubles qui s'agencent aux murs roses." +
                    "\n\tÀ travers la pièce, de grandes fleurs vibrantes se reposent et des papillons s'excitent tout autour de toi." +
                    "\n\tÀ ta droite se trouve une [porte jaune], devant toi une [porte bleue]\n");

            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte bleue":
                    if (Jeu.HasBlueKey)
                    {
                        Console.WriteLine("\nTu déverouilles la porte bleue et tu y entres.");
                        Jeu.nextRoom = "Bleue";
                    }
                    else
                    {
                        Console.WriteLine("\nLa porte est verrouillée.");
                    }
                    break;
                case "porte jaune":
                    Console.WriteLine("\nTu ouvres la porte et entres dans la pièce.");
                    // nextRoomToGo = "Jaune";
                    Jeu.nextRoom = "Jaune";
                    break;
                default:
                    Console.WriteLine("\nCommande invalide.");
                    break;

            }
        }

    }
}
