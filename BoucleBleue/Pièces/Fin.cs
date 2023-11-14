using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Fin : Room
    {
        internal override void ViewDescription()
        {
                Console.WriteLine("description deuxieme version");
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
                    Console.WriteLine("\nDans la noirceur, tu mets tes mains sur le mur pour te retrouver. Tu sens tes mains tachée d'un liquide." +
                                      "\nTu les mets près de ton visage et tu réalises que c'est du sang." +
                                      "\nLe mur est couvert de sang. Tu recules.");
                    break;
                case "boucle":
                    if (Jeu.HasGreenKey)
                    {
                        Console.WriteLine("\nTrue ending");
                        Console.WriteLine("\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 05: Vraie fin - - -");
                        Jeu.Fin05 = true;
                        Jeu.isFinished = true;
                    }
                    else
                    {
                        Console.WriteLine("\nTu utilises la clé en or." +
                                          "\nTu sors par la porte rouge.\nPourquoi t'es tu réveillée ici? Qui était la poupée que tu as tué?" +
                                          "\nCe sont des questions pour plus tard. Enfin libre. Tu es fatiguée, tu t'endors.");
                        Console.WriteLine("\n\n\t\tJeu écrit par Noémie-Alexia Prévost et Kseniya Finchenko\n\t\t- - - FIN 03: Fin normale - - -");
                        Jeu.Fin04 = true;
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
