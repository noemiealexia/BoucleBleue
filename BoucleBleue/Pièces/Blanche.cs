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
                    Console.WriteLine("\nTu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Noire";
                    break;
                case "porte jaune":
                    Console.WriteLine("\nTu ouvres la porte et entres dans la pièce.");
                    Jeu.nextRoom = "Jaune";
                    break;
                case "explorer":
                    Console.WriteLine("\nVeux-tu aller au [nord], à l'[est], au [sud] ou à l'[ouest]");
                    break;
                case "nord":
                    Console.WriteLine("\nTu sens une grande porte. Beaucoup plus grande que les autres. Elle est vérouillée.");
                    break;
                case "est":
                    Console.WriteLine("\nC'est la porte jaune, d'où tu proviens.");
                    break;
                case "sud":
                    Console.WriteLine("\nIl y a une [porte noire] dans laquelle tu peux entrer.");
                    break;
                case "ouest":
                    Console.WriteLine("\nDans la noirceur, tu mets tes mains sur le mur pour te retrouver.");
                    break;
                case "boucle":
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
