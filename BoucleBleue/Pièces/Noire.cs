using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Noire : Room
    {
        internal override void ViewDescription()
        {
            Console.WriteLine("\n\t description");
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte blanche":
                    Console.WriteLine("Tu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Blanche";
                    break;
                case "couteau":
                    Console.WriteLine("Tu prends le couteau.");
                    Jeu.HasYellowKey = true;
                    break;
                case "qqch autre":
                    Console.WriteLine("\n");
                    break;
                case "note":
                    Console.WriteLine("\n La note dit qu'il faut couper le ventre de quelque chose");
                    break;
                case "mannequin":
                    if (Jeu.HasYellowKey)
                    {
                       Console.WriteLine("\n Tu coupes le ventre du mannequin.");
                       Console.WriteLine("\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 01: POUR TOUJOURS  - - -");
                       Jeu.Fin01 = true;
                       Jeu.isFinished = true;
                    }
                    else
                    {
                       Console.WriteLine("\n");
                    }
                    break;
                case "qqch autre?":
                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }
    }
}
