using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue.Pièces
{
    internal class Jaune : Room
    {

        bool table = false;

        internal override void ViewDescription()
        {
            Console.WriteLine( "La chambre est jaune, il y a des ours en peluche à tous les coins de la piéce." +
            "Ils te regardent avec un sourire." +
            "Il y a une grande commode, des chaises, un ballon gonflable et des petites tables." +
            " Une nouvelle porte se trouve devant toi." +
            "[porte blanche] [porte rose]");
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte blanche":
                    Console.WriteLine("La porte est verrouillée.");
                    break;
                case "porte rose":
                    Console.WriteLine("Tu ouvres la porte et entres dans la chambre rose.");
                    // nextRoomToGo = "Jaune";
                    Jeu.nextRoom = "Rose";
                    break;
                case "chaises":
                    Console.WriteLine("Tu t'assoies à côté d'un ours.");
                    break;
                case "ballon":
                    Console.WriteLine("Tu sautes sur le ballon pendant quelques minutes.");
                    break;
                case "tables":
                    Console.WriteLine("Tu montes sur la table et la vue d'en haut te permet de remarquer quelque chose.");
                    table = true;
                    break;
                case "commode":
                    if (table == true)
                    {
                        Console.WriteLine("Tu pousses la commode pour révéler la petite ouverture inégale que tu as vue quand tu étais monté sur la table. C'est en fait une porte vers une garde-robe secrète.");

                        Jeu.nextRoom = "GardeRobe";
                    }
                    else
                    {
                        Console.WriteLine("Tu ouvres les tiroirs de la commode, mais il n'y a rien à l'intérieur.");
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }

        }

         
    }
}
