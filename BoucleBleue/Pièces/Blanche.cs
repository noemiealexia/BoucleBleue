using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Blanche : Room
    {
        internal override void ViewDescription()
        {
            if (Jeu.HasYellowKey)
            {
                Console.WriteLine("description deuxieme version");


            }
            else
            {
                Console.WriteLine("\n\tLa pièce est complètement sombre." +
                                  "\n\tTu ne vois que la [porte jaune] derrière toi." +
                                  "\n\tTu pourrais aussi [explorer].");
            }
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte noire":
                    Console.WriteLine("Tu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Noire";
                    break;
                case "porte jaune":
                    Console.WriteLine("Tu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Jaune";
                    break;
                case "lumière":
                    Console.WriteLine("Tu allumes la lumière et l'intérieur de la pièce est révélé.");
                    break;
                case "qqch autre?":
                    Console.WriteLine("\n");
                    break;
                case "mot secret":
                    if (Jeu.HasGreenKey)
                    {
                        Console.WriteLine("\nTrue ending");
                        Console.WriteLine("\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 03:   - - -");
                        Jeu.Fin03 = true;
                        Jeu.isFinished = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Tu sors par la porte rouge.");
                        Console.WriteLine("\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 02:   - - -");
                        Jeu.Fin02 = true;
                        Jeu.isFinished = true;
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }
    }
}
